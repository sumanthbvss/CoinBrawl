using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace WindowsFormsApplication1
{
    class CookieAwareWebClient : WebClient
    {
        public static String POST = "POST";
        public static String GET = "GET";        
        public String CSRF_Token;
        public String Method;
        public bool clickFight;
        public CookieContainer CookieContainer { get; set; }
        public Uri Uri { get; set; }

        public CookieAwareWebClient(CookieContainer cookies)
        {
            this.CookieContainer = cookies;
        }

        protected override WebRequest GetWebRequest(Uri address)
        {
            WebRequest request = base.GetWebRequest(address);
            if (request is HttpWebRequest)
            {
                (request as HttpWebRequest).CookieContainer = this.CookieContainer;
                (request as HttpWebRequest).ServicePoint.Expect100Continue = false;
                (request as HttpWebRequest).UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:18.0) Gecko/20100101 Firefox/18.0";
                (request as HttpWebRequest).Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                (request as HttpWebRequest).Headers.Add(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.5");
                (request as HttpWebRequest).Referer = CoinBrawl.SIGN_IN;
                (request as HttpWebRequest).KeepAlive = true;
                (request as HttpWebRequest).AutomaticDecompression = DecompressionMethods.Deflate |
                                                                     DecompressionMethods.GZip;
                if (Method == "POST")
                {
                    (request as HttpWebRequest).ContentType = "application/x-www-form-urlencoded";
                }

                if (clickFight)
                {
                    (request as HttpWebRequest).Referer = CoinBrawl.ARENA;
                    (request as HttpWebRequest).Headers["X-CSRF-Token"] = this.CSRF_Token;
                }

            }
            HttpWebRequest httpRequest = (HttpWebRequest)request;
            httpRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            return httpRequest;
        }
    }
}
