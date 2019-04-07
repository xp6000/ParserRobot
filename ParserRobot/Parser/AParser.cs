using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using ParserRobot.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ParserRobot.Parser
{
   public abstract  class AParser<T> where T: SiteLink, new()
    {
       
        public abstract Uri[] GetUrlCatalog();
        public abstract List<T> GetListfromFile(string uri);


        public  List<SiteLink> GetSiteLinksFromSQL()
        {
            List<SiteLink> siteLinks = new List<SiteLink>();


            using (Context db = new Context())
            {
                siteLinks = db.SiteLinks.ToList();


            }

            return siteLinks;
        }
        public  bool SaveDB(List<T> siteLinks)
        {
            bool flag = false;
            using (Context db = new Context())
            {
                db.SiteLinks.AddRange(siteLinks);
                db.SaveChanges();
                flag = true;
            }

            return flag;
        }
        public List<T> MakeCompare(List<T> newParse, List<T> sqlData)
        {
            List<T> result = new List<T>();

            for (int i = 0; i < newParse.Count; i++)
            {
                if (!LookForUrlinList(newParse[i].Link, sqlData))
                {
                    result.Add(newParse[i]);
                }
            }

            return result;
        }
        
        public  bool CheckDoubleUrl(string uri, List<T> siteLinks)
        {
            bool result = false;

            foreach (T item in siteLinks)
            {
                if (item.Link == uri)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
        public string GetLink(string linkPage, string mainUrl)
        {

            string result = "";
            const string quote = "\"";

            Uri uri = new Uri(linkPage);
            string html = new WebClient().DownloadString(uri);
            IHtmlDocument angle = new HtmlParser().ParseDocument(html);

            foreach (var item in angle.QuerySelectorAll("a"))
            {
                string link;
                if (!string.IsNullOrEmpty(item.GetAttribute("href"))&&(!item.GetAttribute("href").Contains("php")))
                {


                    if (!item.GetAttribute("href").Contains(mainUrl))
                    {
                        link = mainUrl + item.GetAttribute("href");
                    }
                    else
                    {
                        link = item.GetAttribute("href");
                    }


                    if (!result.Contains(link))
                    {
                        result += $"{quote}{link}{quote},";
                    }

                }

            }

            return result;


        }
        public bool LookForUrlinList(string url, List<T> sites)
        {
            bool flag = false;
            foreach (SiteLink item in sites)
            {
                if (item.Link == url)
                {
                    flag = true;
                    break;
                }
            }

            return flag;
        }


        public List<T> GetSiteLinkFromPage(Uri uri, string name)
        {
            List<T> siteLinks = new List<T>();
            string html = "";
            try
            {
                html = new WebClient().DownloadString(uri);
            }
            catch(Exception ex)
            {
               
            }
            DateTime dateTime = DateTime.Now;

            IHtmlDocument angle = new HtmlParser().ParseDocument(html);

            foreach (var item in angle.QuerySelectorAll("a"))
            {
                string link;
                if (!string.IsNullOrEmpty(item.GetAttribute("href")) && (!item.GetAttribute("href").Contains("php")))
                {


                    if (!item.GetAttribute("href").Contains(name))
                    {
                        link = name + item.GetAttribute("href");
                    }
                    else
                    {
                        link = item.GetAttribute("href");
                    }


                    siteLinks.Add(new T { Link = Koi8uToKoi8r(link), Title = Win1251toUTF8(item.TextContent), DateTime = dateTime.Date });


                }




            }
            //   var result = siteLinks.GroupBy(x => x.Link).Select(x => x.First()).ToList();
            siteLinks = ClearLinq(siteLinks);
      
            return siteLinks.Distinct(new SiteLinkComparer<T>()).ToList<T>();
        }

        private string Koi8uToKoi8r(string link)
        {

            Encoding koi8u = Encoding.GetEncoding("KOI8-U");
            Encoding koi8r = Encoding.GetEncoding("KOI8-R");

            byte[] koi8uBytes = koi8u.GetBytes(link);
            byte[] koi8rBytes = Encoding.Convert(koi8u, koi8r, koi8uBytes);

            return koi8r.GetString(koi8rBytes);

        }
        public string Win1251toUTF8(string text)
        {


            Encoding utf8 = Encoding.GetEncoding("UTF-8");
            Encoding win1251 = Encoding.GetEncoding("Windows-1251");

            byte[] utf8Bytes = win1251.GetBytes(text);
            byte[] win1251Bytes = Encoding.Convert(utf8, win1251, utf8Bytes);

            return win1251.GetString(win1251Bytes);
        }

        public List<T> ClearLinq(List<T> siteLinks)
        {
            for (int i = 0; i < siteLinks.Count; i++)
            {
                siteLinks[i].Link = siteLinks[i].Link.ToLower().Replace("//", "/");
                siteLinks[i].Link = siteLinks[i].Link.Replace("http:/", "").Replace("https:/", "");
            }
            return siteLinks;
        }

        public List<T> CheckDoubleLinkinList(List<T> ts)
        {
            return ts.Distinct(new SiteLinkComparer<T>()).ToList<T>();
        }

        class SiteLinkComparer<T>  :  IEqualityComparer<T> where T: SiteLink
        {
            public bool Equals(T x, T y)
            {
                return x.Link.Equals(y.Link);
            }

            

            public int GetHashCode(T obj)
            {
                return obj.Link.GetHashCode();
            }

           
        }
    }

   
}
