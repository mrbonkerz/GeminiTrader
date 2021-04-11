
namespace GeminiTrader
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.activeOrdersLV = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cancelOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.marketCB = new System.Windows.Forms.ComboBox();
            this.orderTypeGB = new System.Windows.Forms.GroupBox();
            this.orderCB = new System.Windows.Forms.ComboBox();
            this.priceGB = new System.Windows.Forms.GroupBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.quantityGB = new System.Windows.Forms.GroupBox();
            this.fiatLabel = new System.Windows.Forms.Label();
            this.coinLabel = new System.Windows.Forms.Label();
            this.quantityFiatTB = new System.Windows.Forms.TextBox();
            this.quantityCoinTB = new System.Windows.Forms.TextBox();
            this.tradeGB = new System.Windows.Forms.GroupBox();
            this.totalValue = new System.Windows.Forms.Label();
            this.feesValue = new System.Windows.Forms.Label();
            this.subtotalValue = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.feesLabel = new System.Windows.Forms.Label();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.executeOrderButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ordersGB = new System.Windows.Forms.GroupBox();
            this.buysellButton = new System.Windows.Forms.Button();
            this.orderBookGB = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bidOBLV = new System.Windows.Forms.ListView();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.askOBLV = new System.Windows.Forms.ListView();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1.SuspendLayout();
            this.orderTypeGB.SuspendLayout();
            this.priceGB.SuspendLayout();
            this.quantityGB.SuspendLayout();
            this.tradeGB.SuspendLayout();
            this.ordersGB.SuspendLayout();
            this.orderBookGB.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // activeOrdersLV
            // 
            this.activeOrdersLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.activeOrdersLV.ContextMenuStrip = this.contextMenuStrip1;
            this.activeOrdersLV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.activeOrdersLV.FullRowSelect = true;
            this.activeOrdersLV.HideSelection = false;
            this.activeOrdersLV.Location = new System.Drawing.Point(6, 26);
            this.activeOrdersLV.Name = "activeOrdersLV";
            this.activeOrdersLV.Size = new System.Drawing.Size(1058, 187);
            this.activeOrdersLV.TabIndex = 0;
            this.activeOrdersLV.UseCompatibleStateImageBehavior = false;
            this.activeOrdersLV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Text = "orderID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Name = "columnHeader2";
            this.columnHeader2.Text = "Date";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Name = "columnHeader3";
            this.columnHeader3.Text = "Order Book";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Name = "columnHeader4";
            this.columnHeader4.Text = "Side";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Name = "columnHeader5";
            this.columnHeader5.Text = "Order Type";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 140;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Name = "columnHeader6";
            this.columnHeader6.Text = "Price";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 140;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Name = "columnHeader7";
            this.columnHeader7.Text = "Quantity";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 140;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Name = "columnHeader8";
            this.columnHeader8.Text = "Total";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Name = "columnHeader9";
            this.columnHeader9.Text = "Status";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 140;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelOrder});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 28);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // cancelOrder
            // 
            this.cancelOrder.Name = "cancelOrder";
            this.cancelOrder.Size = new System.Drawing.Size(164, 24);
            this.cancelOrder.Text = "Cancel Order";
            // 
            // marketCB
            // 
            this.marketCB.FormattingEnabled = true;
            this.marketCB.Location = new System.Drawing.Point(12, 27);
            this.marketCB.Name = "marketCB";
            this.marketCB.Size = new System.Drawing.Size(151, 28);
            this.marketCB.TabIndex = 1;
            this.marketCB.Text = "BTCUSD";
            this.marketCB.SelectedIndexChanged += new System.EventHandler(this.marketCB_SelectedValueChanged);
            // 
            // orderTypeGB
            // 
            this.orderTypeGB.Controls.Add(this.orderCB);
            this.orderTypeGB.Location = new System.Drawing.Point(7, 184);
            this.orderTypeGB.Name = "orderTypeGB";
            this.orderTypeGB.Size = new System.Drawing.Size(250, 64);
            this.orderTypeGB.TabIndex = 2;
            this.orderTypeGB.TabStop = false;
            this.orderTypeGB.Text = "ORDER TYPE";
            // 
            // orderCB
            // 
            this.orderCB.Enabled = false;
            this.orderCB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderCB.FormattingEnabled = true;
            this.orderCB.Items.AddRange(new object[] {
            "Limit",
            "Stop-Limit",
            "Maker-or-Cancel (MOC)",
            "Immediate-or-Cancel (IOC)",
            "Fill-or-Kill (FOK)",
            "Market"});
            this.orderCB.Location = new System.Drawing.Point(6, 26);
            this.orderCB.Name = "orderCB";
            this.orderCB.Size = new System.Drawing.Size(238, 28);
            this.orderCB.TabIndex = 2;
            this.orderCB.Text = "Limit";
            // 
            // priceGB
            // 
            this.priceGB.Controls.Add(this.priceLabel);
            this.priceGB.Controls.Add(this.priceTB);
            this.priceGB.Location = new System.Drawing.Point(7, 254);
            this.priceGB.Name = "priceGB";
            this.priceGB.Size = new System.Drawing.Size(250, 64);
            this.priceGB.TabIndex = 3;
            this.priceGB.TabStop = false;
            this.priceGB.Text = "PRICE";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.Location = new System.Drawing.Point(186, 26);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(13, 20);
            this.priceLabel.TabIndex = 10;
            this.priceLabel.Text = ".";
            // 
            // priceTB
            // 
            this.priceTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceTB.Location = new System.Drawing.Point(6, 26);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(174, 27);
            this.priceTB.TabIndex = 3;
            this.priceTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // quantityGB
            // 
            this.quantityGB.Controls.Add(this.fiatLabel);
            this.quantityGB.Controls.Add(this.coinLabel);
            this.quantityGB.Controls.Add(this.quantityFiatTB);
            this.quantityGB.Controls.Add(this.quantityCoinTB);
            this.quantityGB.Location = new System.Drawing.Point(7, 324);
            this.quantityGB.Name = "quantityGB";
            this.quantityGB.Size = new System.Drawing.Size(250, 96);
            this.quantityGB.TabIndex = 3;
            this.quantityGB.TabStop = false;
            this.quantityGB.Text = "QUANTITY";
            // 
            // fiatLabel
            // 
            this.fiatLabel.AutoSize = true;
            this.fiatLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fiatLabel.Location = new System.Drawing.Point(186, 62);
            this.fiatLabel.Name = "fiatLabel";
            this.fiatLabel.Size = new System.Drawing.Size(13, 20);
            this.fiatLabel.TabIndex = 12;
            this.fiatLabel.Text = ".";
            // 
            // coinLabel
            // 
            this.coinLabel.AutoSize = true;
            this.coinLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.coinLabel.Location = new System.Drawing.Point(186, 29);
            this.coinLabel.Name = "coinLabel";
            this.coinLabel.Size = new System.Drawing.Size(13, 20);
            this.coinLabel.TabIndex = 11;
            this.coinLabel.Text = ".";
            // 
            // quantityFiatTB
            // 
            this.quantityFiatTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantityFiatTB.Location = new System.Drawing.Point(6, 59);
            this.quantityFiatTB.Name = "quantityFiatTB";
            this.quantityFiatTB.Size = new System.Drawing.Size(174, 27);
            this.quantityFiatTB.TabIndex = 5;
            this.quantityFiatTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantityFiatTB.Validated += new System.EventHandler(this.quantityFiatTB_Validated);
            // 
            // quantityCoinTB
            // 
            this.quantityCoinTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantityCoinTB.Location = new System.Drawing.Point(6, 26);
            this.quantityCoinTB.Name = "quantityCoinTB";
            this.quantityCoinTB.Size = new System.Drawing.Size(174, 27);
            this.quantityCoinTB.TabIndex = 4;
            this.quantityCoinTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantityCoinTB.Validated += new System.EventHandler(this.quantityCoinTB_Validated);
            // 
            // tradeGB
            // 
            this.tradeGB.Controls.Add(this.totalValue);
            this.tradeGB.Controls.Add(this.feesValue);
            this.tradeGB.Controls.Add(this.subtotalValue);
            this.tradeGB.Controls.Add(this.totalLabel);
            this.tradeGB.Controls.Add(this.feesLabel);
            this.tradeGB.Controls.Add(this.subTotalLabel);
            this.tradeGB.Controls.Add(this.balanceLabel);
            this.tradeGB.Controls.Add(this.executeOrderButton);
            this.tradeGB.Controls.Add(this.orderTypeGB);
            this.tradeGB.Controls.Add(this.quantityGB);
            this.tradeGB.Controls.Add(this.priceGB);
            this.tradeGB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tradeGB.Location = new System.Drawing.Point(6, 61);
            this.tradeGB.Name = "tradeGB";
            this.tradeGB.Size = new System.Drawing.Size(263, 553);
            this.tradeGB.TabIndex = 4;
            this.tradeGB.TabStop = false;
            this.tradeGB.Text = "BUY";
            // 
            // totalValue
            // 
            this.totalValue.AutoSize = true;
            this.totalValue.Location = new System.Drawing.Point(100, 463);
            this.totalValue.Name = "totalValue";
            this.totalValue.Size = new System.Drawing.Size(13, 20);
            this.totalValue.TabIndex = 18;
            this.totalValue.Text = ".";
            // 
            // feesValue
            // 
            this.feesValue.AutoSize = true;
            this.feesValue.Location = new System.Drawing.Point(100, 443);
            this.feesValue.Name = "feesValue";
            this.feesValue.Size = new System.Drawing.Size(13, 20);
            this.feesValue.TabIndex = 17;
            this.feesValue.Text = ".";
            // 
            // subtotalValue
            // 
            this.subtotalValue.AutoSize = true;
            this.subtotalValue.Location = new System.Drawing.Point(100, 423);
            this.subtotalValue.Name = "subtotalValue";
            this.subtotalValue.Size = new System.Drawing.Size(13, 20);
            this.subtotalValue.TabIndex = 16;
            this.subtotalValue.Text = ".";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalLabel.Location = new System.Drawing.Point(13, 463);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(48, 20);
            this.totalLabel.TabIndex = 15;
            this.totalLabel.Text = "Total:";
            // 
            // feesLabel
            // 
            this.feesLabel.AutoSize = true;
            this.feesLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.feesLabel.Location = new System.Drawing.Point(13, 443);
            this.feesLabel.Name = "feesLabel";
            this.feesLabel.Size = new System.Drawing.Size(44, 20);
            this.feesLabel.TabIndex = 14;
            this.feesLabel.Text = "Fees:";
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subTotalLabel.Location = new System.Drawing.Point(13, 423);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(72, 20);
            this.subTotalLabel.TabIndex = 13;
            this.subTotalLabel.Text = "Subtotal:";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.balanceLabel.Location = new System.Drawing.Point(6, 32);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(131, 20);
            this.balanceLabel.TabIndex = 8;
            this.balanceLabel.Text = "Available to trade:";
            // 
            // executeOrderButton
            // 
            this.executeOrderButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.executeOrderButton.Location = new System.Drawing.Point(6, 498);
            this.executeOrderButton.Name = "executeOrderButton";
            this.executeOrderButton.Size = new System.Drawing.Size(251, 49);
            this.executeOrderButton.TabIndex = 6;
            this.executeOrderButton.Text = "EXECUTE BUY";
            this.executeOrderButton.UseVisualStyleBackColor = true;
            this.executeOrderButton.Click += new System.EventHandler(this.executeOrderButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1355, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 619);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1355, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ordersGB
            // 
            this.ordersGB.Controls.Add(this.activeOrdersLV);
            this.ordersGB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ordersGB.Location = new System.Drawing.Point(275, 395);
            this.ordersGB.Name = "ordersGB";
            this.ordersGB.Size = new System.Drawing.Size(1070, 219);
            this.ordersGB.TabIndex = 7;
            this.ordersGB.TabStop = false;
            this.ordersGB.Text = "OPEN ORDERS";
            // 
            // buysellButton
            // 
            this.buysellButton.Location = new System.Drawing.Point(179, 27);
            this.buysellButton.Name = "buysellButton";
            this.buysellButton.Size = new System.Drawing.Size(90, 28);
            this.buysellButton.TabIndex = 0;
            this.buysellButton.Text = "Sell";
            this.buysellButton.UseVisualStyleBackColor = true;
            this.buysellButton.Click += new System.EventHandler(this.buysellButton_Click);
            // 
            // orderBookGB
            // 
            this.orderBookGB.Controls.Add(this.groupBox3);
            this.orderBookGB.Controls.Add(this.groupBox2);
            this.orderBookGB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderBookGB.Location = new System.Drawing.Point(281, 27);
            this.orderBookGB.Name = "orderBookGB";
            this.orderBookGB.Size = new System.Drawing.Size(1064, 362);
            this.orderBookGB.TabIndex = 10;
            this.orderBookGB.TabStop = false;
            this.orderBookGB.Text = "ORDER BOOK";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bidOBLV);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(538, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(520, 330);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bid";
            // 
            // bidOBLV
            // 
            this.bidOBLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.bidOBLV.ContextMenuStrip = this.contextMenuStrip1;
            this.bidOBLV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bidOBLV.FullRowSelect = true;
            this.bidOBLV.HideSelection = false;
            this.bidOBLV.Location = new System.Drawing.Point(6, 26);
            this.bidOBLV.Name = "bidOBLV";
            this.bidOBLV.Size = new System.Drawing.Size(508, 298);
            this.bidOBLV.TabIndex = 1;
            this.bidOBLV.UseCompatibleStateImageBehavior = false;
            this.bidOBLV.View = System.Windows.Forms.View.Details;
            this.bidOBLV.SelectedIndexChanged += new System.EventHandler(this.bidOBLV_SelectedIndexChanged);
            // 
            // columnHeader13
            // 
            this.columnHeader13.Name = "columnHeader13";
            this.columnHeader13.Text = "Price";
            this.columnHeader13.Width = 140;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Name = "columnHeader14";
            this.columnHeader14.Text = "Quantity";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader14.Width = 160;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Name = "columnHeader15";
            this.columnHeader15.Text = "Cumulative Qty.";
            this.columnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader15.Width = 160;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.askOBLV);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(6, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 330);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ask";
            // 
            // askOBLV
            // 
            this.askOBLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.askOBLV.ContextMenuStrip = this.contextMenuStrip1;
            this.askOBLV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.askOBLV.FullRowSelect = true;
            this.askOBLV.HideSelection = false;
            this.askOBLV.Location = new System.Drawing.Point(6, 26);
            this.askOBLV.Name = "askOBLV";
            this.askOBLV.Size = new System.Drawing.Size(508, 298);
            this.askOBLV.TabIndex = 1;
            this.askOBLV.UseCompatibleStateImageBehavior = false;
            this.askOBLV.View = System.Windows.Forms.View.Details;
            this.askOBLV.SelectedIndexChanged += new System.EventHandler(this.askOBLV_SelectedIndexChanged);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Name = "columnHeader10";
            this.columnHeader10.Text = "Price";
            this.columnHeader10.Width = 140;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Name = "columnHeader11";
            this.columnHeader11.Text = "Quantity";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader11.Width = 160;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Name = "columnHeader12";
            this.columnHeader12.Text = "Cumulative Qty.";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader12.Width = 160;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 641);
            this.Controls.Add(this.orderBookGB);
            this.Controls.Add(this.buysellButton);
            this.Controls.Add(this.ordersGB);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tradeGB);
            this.Controls.Add(this.marketCB);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Gemini Trading";
            this.contextMenuStrip1.ResumeLayout(false);
            this.orderTypeGB.ResumeLayout(false);
            this.priceGB.ResumeLayout(false);
            this.priceGB.PerformLayout();
            this.quantityGB.ResumeLayout(false);
            this.quantityGB.PerformLayout();
            this.tradeGB.ResumeLayout(false);
            this.tradeGB.PerformLayout();
            this.ordersGB.ResumeLayout(false);
            this.orderBookGB.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView activeOrdersLV;
        private System.Windows.Forms.ComboBox marketCB;
        private System.Windows.Forms.GroupBox orderTypeGB;
        private System.Windows.Forms.ComboBox orderCB;
        private System.Windows.Forms.GroupBox priceGB;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.GroupBox quantityGB;
        private System.Windows.Forms.TextBox quantityFiatTB;
        private System.Windows.Forms.TextBox quantityCoinTB;
        private System.Windows.Forms.GroupBox tradeGB;
        private System.Windows.Forms.Button executeOrderButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.GroupBox ordersGB;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Button buysellButton;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label fiatLabel;
        private System.Windows.Forms.Label coinLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label feesLabel;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label totalValue;
        private System.Windows.Forms.Label feesValue;
        private System.Windows.Forms.Label subtotalValue;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cancelOrder;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox orderBookGB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView bidOBLV;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView askOBLV;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}

