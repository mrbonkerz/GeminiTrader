using System;
using System.Text;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GeminiTrader
{
    public class TickerPrice
    {
        public class CryptoAPI
        {
            public double ask { get; set; } //sell
            public double bid { get; set; } //buy
            public double last { get; set; }
        }

        public class CryptoAPI2
        {
            public string base_currency { get; set; }
            public string min_order_size { get; set; }
            public double quote_increment { get; set; }
            public double tick_size { get; set; }
        }

        public class CryptoAPI3
        {
            public CryptoAPI3A[] asks { get; set; }
            public CryptoAPI3A[] bids { get; set; }
        }

        public class CryptoAPI3A
        {
            public double price { get; set; }
            public double amount { get; set; }
        }

        public static Task<CryptoAPI> TickerGetPrice(string symbol)
        {
            CryptoAPI cryptoAPI = null;
            int count = 0;
            return Task.Factory.StartNew(() =>
            {
                while (cryptoAPI == null)
                {
                    string requestUriString = "";
                    double value = 1;
                    try
                    {
                        if (count == 0)
                        {
                            requestUriString = "https://api.gemini.com/v1/pubticker/" + symbol;
                        }
                        else
                        {
                            requestUriString = "https://api.gemini.com/v1/pubticker/" + symbol;
                        }

                        HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
                        httpWebRequest.Proxy = null;
                        httpWebRequest.UserAgent = "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0)";
                        HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                        Encoding aSCII = Encoding.ASCII;
                        string text = default(string);
                        using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), aSCII))
                        {
                            text = streamReader.ReadToEnd();
                        }
                        cryptoAPI = JsonConvert.DeserializeObject<CryptoAPI>(text.ToString());

                        value = Math.Min(Math.Min(cryptoAPI.ask, cryptoAPI.bid), cryptoAPI.last);

                        if (value == 0)
                        {
                            throw new System.Exception("value = 0 exception");
                        }
                    }
                    catch
                    {
                        count++;

                        if (count == 2)
                        {
                            break;
                        }

                        System.Threading.Thread.Sleep(500);

                        cryptoAPI = null;
                    }
                }

                return cryptoAPI;
            });
        }

        public static Task<CryptoAPI2> TickerGetInfo(string symbol)
        {
            CryptoAPI2 cryptoAPI = null;
            int count = 0;
            return Task.Factory.StartNew(() =>
            {
                while (cryptoAPI == null)
                {
                    string requestUriString = "";
                    try
                    {
                        if (count == 0)
                        {
                            requestUriString = "https://api.gemini.com/v1/symbols/details/" + symbol;
                        }
                        else
                        {
                            requestUriString = "https://api.gemini.com/v1/symbols/details/" + symbol;
                        }

                        HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
                        httpWebRequest.Proxy = null;
                        httpWebRequest.UserAgent = "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0)";
                        HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                        Encoding aSCII = Encoding.ASCII;
                        string text = default(string);
                        using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), aSCII))
                        {
                            text = streamReader.ReadToEnd();
                        }
                        cryptoAPI = JsonConvert.DeserializeObject<CryptoAPI2>(text.ToString());
                    }
                    catch
                    {
                        count++;

                        if (count == 2)
                        {
                            break;
                        }

                        System.Threading.Thread.Sleep(500);

                        cryptoAPI = null;
                    }
                }

                return cryptoAPI;
            });
        }

        public static Task<CryptoAPI3> orderBooks(string symbol)
        {
            CryptoAPI3 cryptoAPI = null;
            int count = 0;

            return Task.Factory.StartNew(() =>
            {
                while (cryptoAPI == null)
                {
                    string requestUriString = "";
                    double value = 1;
                    try
                    {
                        if (count == 0)
                        {
                            requestUriString = "https://api.gemini.com/v1/book/" + symbol;
                        }
                        else
                        {
                            requestUriString = "https://api.gemini.com/v1/book/" + symbol;
                        }

                        HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
                        httpWebRequest.Proxy = null;
                        httpWebRequest.UserAgent = "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0)";
                        HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                        Encoding aSCII = Encoding.ASCII;
                        string text = default(string);
                        using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), aSCII))
                        {
                            text = streamReader.ReadToEnd();
                        }
                        cryptoAPI = JsonConvert.DeserializeObject<CryptoAPI3>(text.ToString());

                        if (value == 0)
                        {
                            throw new System.Exception("value = 0 exception");
                        }
                    }
                    catch
                    {
                        count++;

                        if (count == 2)
                        {
                            break;
                        }

                        System.Threading.Thread.Sleep(500);

                        cryptoAPI = null;
                    }
                }

                return cryptoAPI;
            });
        }

        public static Task<string> getSymbols()
        {
            string cryptoAPI = null;
            int count = 0;
            return Task.Factory.StartNew(() =>
            {
                while (cryptoAPI == null)
                {
                    string requestUriString = "";
                    double value = 1;
                    try
                    {
                        if (count == 0)
                        {
                            requestUriString = "https://api.gemini.com/v1/symbols";
                        }
                        else
                        {
                            requestUriString = "https://api.gemini.com/v1/symbols";
                        }

                        HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
                        httpWebRequest.Proxy = null;
                        httpWebRequest.UserAgent = "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0)";
                        HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                        Encoding aSCII = Encoding.ASCII;
                        string text = default(string);
                        using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), aSCII))
                        {
                            text = streamReader.ReadToEnd();
                        }
                        cryptoAPI = text.ToString();

                        if (value == 0)
                        {
                            throw new System.Exception("value = 0 exception");
                        }
                    }
                    catch
                    {
                        count++;

                        if (count == 2)
                        {
                            break;
                        }

                        System.Threading.Thread.Sleep(500);

                        cryptoAPI = null;
                    }
                }

                return cryptoAPI;
            });
        }
    }
}
