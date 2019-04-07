using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using ParserRobot.Model;
using ParserRobot.Parser;

namespace ParserRobot
{
    class RMParser<T> : AParser<T> where T : SiteLink, new()
    {
        public override List<T> GetListfromFile(string uri)
        {
            throw new NotImplementedException();
        }

        public override Uri[] GetUrlCatalog()
        {
            string[] linkString = new string[]
            {
               "http://rashodnika.net/1_1_1.html", "http://rashodnika.net/1_1_3.html", "http://rashodnika.net/1_1_6.html",
               "http://rashodnika.net/2_1_1.html", "http://rashodnika.net/2_1_3.html", "http://rashodnika.net/3_1_1.html",
               "http://rashodnika.net/3_1_2.html", "http://rashodnika.net/3_1_3.html", "http://rashodnika.net/4_1_1.html",
               "http://rashodnika.net/4_1_3.html", "http://rashodnika.net/13_1_5.html", "http://rashodnika.net/10_1_1.html",
               "http://rashodnika.net/5_1_1.html", "http://rashodnika.net/5_1_2.html", "http://rashodnika.net/5_1_3.html",
               "http://rashodnika.net/6_1_1.html", "http://rashodnika.net/6_1_2.html", "http://rashodnika.net/6_1_3.html",
               "http://rashodnika.net/6_1_4.html", "http://rashodnika.net/7_1_1.html", "http://rashodnika.net/7_1_2.html",
               "http://rashodnika.net/7_1_3.html", "http://rashodnika.net/7_1_4.html", "http://rashodnika.net/12_1_9.html",
               "http://rashodnika.net/12_1_5.html", "http://rashodnika.net/8_1_1.html", "http://rashodnika.net/8_1_3.html",
               "http://rashodnika.net/11_1_1.html", "http://rashodnika.net/11_1_3.html", "http://rashodnika.net/11_1_4.html",
               "http://rashodnika.net/9_1_7.html", "http://rashodnika.net/9_1_8.html", "http://rashodnika.net/9_1_3.html"
            };
            List<Uri> urisList = new List<Uri>();

            foreach (string item in linkString)
            {
                urisList.Add(new Uri(item));
            }

            return urisList.ToArray();
        }

    
     
    }
}
