using System;
using System.Windows.Forms;
using System.Globalization;
using GeminiApi;

namespace GeminiTrader
{
    public partial class Main : Form
    {
        GeminiApi.GeminiRequest geminiRequest;
        Timer timer;
        TickerPrice.CryptoAPI2 tickerInfoResults;

        public Main()
        {
            InitializeComponent();

            string[] args = Environment.GetCommandLineArgs();

            if(args.Length != 3)
            {
                MessageBox.Show("Add Key and Secret in Target. e.g " + args[0].Replace("dll", "exe") + " Key Secret ");
            }
            else
            {
                geminiRequest = new GeminiRequest(args[1], args[2], "https://api.gemini.com");
            }

            getActiveOrders();
            getBalance();
            getOrderBook();
            getSymbols();
            toggleMarket();

            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            getOrderBook();
        }

        private void getActiveOrders()
        {
            activeOrdersLV.Items.Clear();

            foreach (GeminiApi.Models.Responses.OrderResponse str in geminiRequest.GetActiveOrders())
            {
                ListViewItem listViewItem = new ListViewItem(str.OrderId);
                listViewItem.SubItems.Add(DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt32(str.Timestamp)).DateTime.ToLocalTime().ToString());
                listViewItem.SubItems.Add(str.Symbol.ToUpper());
                listViewItem.SubItems.Add(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.Side));
                listViewItem.SubItems.Add(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.Type));
                listViewItem.SubItems.Add(string.Concat("$ ", str.Price.ToString(), " ", str.Symbol.Substring(str.Symbol.Length / 2)).ToUpper());
                listViewItem.SubItems.Add(string.Concat(str.OriginalAmount.ToString(), " ", str.Symbol.Substring(0, str.Symbol.Length / 2)).ToUpper());
                listViewItem.SubItems.Add((str.Price * str.OriginalAmount).ToString("F2"));
                listViewItem.SubItems.Add(string.Concat((1 - str.RemainingAmount / str.OriginalAmount) * 100, "% Filled"));

                activeOrdersLV.Items.Add(listViewItem);
            }
        }

        private void getBalance()
        {
            string concat = "";
            foreach (GeminiApi.Models.Responses.BalancesResponse bal in geminiRequest.GetAvailableBalances())
            {
                if (marketCB.Text.Contains(bal.Currency) && bal.Available > 0) concat = string.Concat(concat, "\n", bal.Currency, ": ", bal.Available);
            }

            balanceLabel.Text = string.Concat("Available to trade:", concat);
        }

        private async void getOrderBook()
        {
            TickerPrice.CryptoAPI3 orderBookData = await TickerPrice.orderBooks(marketCB.Text);

            double cumulative = 0;
            int count = 0;
            askOBLV.BeginUpdate();
            bidOBLV.BeginUpdate();

            askOBLV.Items.Clear();

            foreach (TickerPrice.CryptoAPI3A data in orderBookData.asks)
            {
                if (count > 20) break;
                count++;

                cumulative = cumulative + data.amount;

                ListViewItem listViewItem = new ListViewItem(data.price.ToString());
                listViewItem.SubItems.Add(data.amount.ToString());
                listViewItem.SubItems.Add(cumulative.ToString("F8"));
                askOBLV.Items.Add(listViewItem);
            }

            cumulative = 0;
            count = 0;
            bidOBLV.Items.Clear();

            foreach (TickerPrice.CryptoAPI3A data in orderBookData.bids)
            {
                if (count > 20) break;
                count++;

                cumulative = cumulative + data.amount;

                ListViewItem listViewItem = new ListViewItem(data.price.ToString());
                listViewItem.SubItems.Add(data.amount.ToString());
                listViewItem.SubItems.Add(cumulative.ToString("F8"));
                bidOBLV.Items.Add(listViewItem);
            }

            askOBLV.EndUpdate();
            bidOBLV.EndUpdate();
        }

        private async void getSymbols()
        {
            string symbols = await TickerPrice.getSymbols();

            symbols = symbols.Replace("[\"", "");
            symbols = symbols.Replace("\"]", "");
            symbols = symbols.Replace("\"", "");

            foreach (string str in symbols.Split(","))
            {
                marketCB.Items.Add(str.ToUpper());
            }
        }

        private void updateTotal()
        {
            subtotalValue.Text = quantityFiatTB.Text;
            feesValue.Text = (Convert.ToDouble(quantityFiatTB.Text) * 0.001).ToString("F2");
            totalValue.Text = (Convert.ToDouble(quantityFiatTB.Text) + Convert.ToDouble(quantityFiatTB.Text) * 0.001).ToString("F2");
        }

        private async void toggleMarket()
        {
            orderBookGB.Text = string.Concat("ORDER BOOK (", marketCB.Text, ")".ToUpper());

            if (buysellButton.Text == "Sell")
            {
                tradeGB.Text = string.Concat("Buy (", marketCB.Text, ")".ToUpper());
                executeOrderButton.Text = "Execute Buy".ToUpper();
            }
            else
            {
                tradeGB.Text = string.Concat("Sell (", marketCB.Text, ")".ToUpper());
                executeOrderButton.Text = "Execute Sell".ToUpper();
            }

            getActiveOrders();
            getBalance();

            TickerPrice.CryptoAPI results = await TickerPrice.TickerGetPrice(marketCB.Text);
            tickerInfoResults = await TickerPrice.TickerGetInfo(marketCB.Text);

            quantityGB.Text = string.Concat("QUANTITY (min ", tickerInfoResults.min_order_size, ")");
            priceLabel.Text = marketCB.Text.Substring(marketCB.Text.Length - 3, 3).ToUpper();
            fiatLabel.Text = marketCB.Text.Substring(marketCB.Text.Length - 3, 3).ToUpper();
            coinLabel.Text = marketCB.Text.Substring(0, marketCB.Text.Length - 3).ToUpper();
            priceTB.Text = results.ask.ToString();
        }

        private void buysellButton_Click(object sender, EventArgs e)
        {
            if (buysellButton.Text == "Buy")
            {
                buysellButton.Text = "Sell";
            }
            else
            {
                buysellButton.Text = "Buy";
            }
            toggleMarket();
        }

        private void marketCB_SelectedValueChanged(object sender, EventArgs e)
        {
            toggleMarket();
        }

        private void quantityCoinTB_Validated(object sender, EventArgs e)
        {
            if (quantityCoinTB.Text == "") return;

            quantityFiatTB.Text = (Convert.ToDouble(quantityCoinTB.Text) * Convert.ToDouble(priceTB.Text)).ToString("F2");
            updateTotal();
        }

        private void quantityFiatTB_Validated(object sender, EventArgs e)
        {
            if (quantityFiatTB.Text == "") return;
            string float_ = "8";
            switch (tickerInfoResults.tick_size.ToString())
            {
                case "1E-1":
                    float_ = "1";
                    break;
                case "1E-2":
                    float_ = "2";
                    break;
                case "1E-3":
                    float_ = "3";
                    break;
                case "1E-4":
                    float_ = "4";
                    break;
                case "1E-5":
                    float_ = "5";
                    break;
                case "1E-6":
                    float_ = "6";
                    break;
                case "1E-7":
                    float_ = "7";
                    break;
                case "1E-8":
                    float_ = "8";
                    break;
            }

            quantityCoinTB.Text = Math.Max(Convert.ToDouble(tickerInfoResults.min_order_size), (Convert.ToDouble(quantityFiatTB.Text) / Convert.ToDouble(priceTB.Text))).ToString("F" + float_);
            updateTotal();
        }

        private void executeOrderButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(quantityCoinTB.Text) < Convert.ToDouble(tickerInfoResults.min_order_size))
            {
                MessageBox.Show("Minimum order size required: " + tickerInfoResults.min_order_size);
                quantityCoinTB.Text = tickerInfoResults.min_order_size;
            }
            else
            {
                if (buysellButton.Text == "Buy")
                {//sell
                    geminiRequest.CreateNewOrder(Convert.ToDecimal(priceTB.Text), Convert.ToDecimal(quantityCoinTB.Text), "sell", marketCB.Text);
                }
                else
                {//buy
                    geminiRequest.CreateNewOrder(Convert.ToDecimal(priceTB.Text), Convert.ToDecimal(quantityCoinTB.Text), "buy", marketCB.Text);
                }

                getActiveOrders();
            }
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Cancel Order")
            {
                string focusedItem = activeOrdersLV.FocusedItem.SubItems[0].Text;
                geminiRequest.CancelOrder(focusedItem);
                getActiveOrders();
            }
        }

        private void askOBLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            priceTB.Text = askOBLV.FocusedItem.SubItems[0].Text;
        }

        private void bidOBLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            priceTB.Text = bidOBLV.FocusedItem.SubItems[0].Text;
        }
    }
}
