using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using ParserRobot.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParserRobot.Parser
{
    class FullGrabber<T> where T : SiteLink, new()
    {
        List<T> mainPageLink = new List<T>();
        string pref = "http://";

    public List<T> MainGrabber(string name)
        {
            mainPageLink.Add(new T { Link = name, DateTime = DateTime.Now });
            List<T> noCheckPageLink = GetLinkByUrl(name, name);


            while (noCheckPageLink.Any())
            {

                var thisSiteLink = noCheckPageLink.First();
                noCheckPageLink.AddRange(GetLinkByUrl(thisSiteLink.Link, name));        
                 noCheckPageLink = CheckDoubleLinkinList(noCheckPageLink);
                noCheckPageLink = DeleteChecked(noCheckPageLink);
                noCheckPageLink.Remove(thisSiteLink);
                mainPageLink.Add(thisSiteLink);
             //   MessageBox.Show($"last url {thisSiteLink.Link} count {mainPageLink.Count} and unchecked {noCheckPageLink.Count}");
            

            }
            return mainPageLink;


        }

        private List<T> DeleteChecked(List<T> noCheckPageLink)
        {
            List<T> result = new List<T>();
            foreach (T item0 in noCheckPageLink)
            {
                
                    if (!mainPageLink.Any(x=> x.Link==item0.Link))
                    {
                    result.Add(item0);
                    }
                    
             

            }
            return result;




         }

        private List<T> MakeSiteLink(List<T> mainPageLink)
        {
            List<T> result = new List<T>();

            foreach (T item in mainPageLink)
            {
                result.Add(new T { DateTime = item.DateTime, Link = item.Link, Title = item.Title });
            }

            return result;

        }

        public List<T> GetLinkByUrl(string uri, string name)
        {
            List<T> siteLinks = new List<T>();

            string html = "";

        if (!uri.Contains(pref))     {  uri = pref + uri;    }
     
            try
            {
                html = new WebClient().DownloadString(uri);
            }
            catch (Exception ex)
            {

            }
            DateTime dateTime = DateTime.Now;

            IHtmlDocument angle = new HtmlParser().ParseDocument(html);

            foreach (var item in angle.QuerySelectorAll("a"))
            {
                string link;
                if (!string.IsNullOrEmpty(item.GetAttribute("href")) && (!item.GetAttribute("href").Contains("php")) && !AnotherSite(item.GetAttribute("href"), uri))
                {


                    if (!item.GetAttribute("href").Contains(name))
                    {
                        link = name + item.GetAttribute("href");
                    }
                    else
                    {
                        link = item.GetAttribute("href");
                    }
                    if (!LookForUrlinList(link, siteLinks))
                    {
                        siteLinks.Add(new T { Link = Koi8uToKoi8r(link), Title = Win1251toUTF8(item.TextContent), DateTime = dateTime.Date });
                    }

                }




            }
            //   var result = siteLinks.GroupBy(x => x.Link).Select(x => x.First()).ToList();
            siteLinks = ClearLinq(siteLinks);

          
            return siteLinks.Distinct(new SiteLinkComparer<T>()).ToList<T>();

        }

        public bool LookForUrlinList(string url, List<T> sites)
        {
            bool flag = false;
            foreach (T item in sites)
            {
                if (item.Link == url)
                {
                    flag = true;
                    break;
                }
            }

            return flag;
        }

        private string Koi8uToKoi8r(string link)
        {
            if(!link.Contains(pref))     { link = pref + link; }
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

        public bool AnotherSite(string uri, string oursite)
        {
            bool flag = false;
            uri = uri.Replace(oursite, "");
            if (uri.Contains(".ru")| uri.Contains(".com")| uri.Contains(".org")| uri.Contains(".net"))
            {
                flag = true;
            }

            return flag;
        }


        public List<T> FastGetLinkFromList(List<SiteLink> start, string name)
        {
            List<T> result = new List<T>();

            TaskFactory taskFactory = new TaskFactory();
            Task<List<T>>[] tasks = new Task<List<T>>[start.Count];
            int i = 0;

            foreach (T item in start)
            {
                tasks[i] = new Task<List<T>>(() => GetLinkByUrl(item.Link, name));
             tasks[i].Start();
                i++;

            }
            Task.WaitAll(tasks);
            foreach (var item in tasks)
            {
                result.AddRange(item.Result);
            }
            result = CheckDoubleLinkinList(result);
            result = DeleteChecked(result);


            return result;
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

        class SiteLinkComparer<T> : IEqualityComparer<T> where T : SiteLink
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

        public bool SaveDB(List<T> siteLinks)
        {
            List<T> siteLinkstoDB = MakeSiteLink(siteLinks);


            bool flag = false;
            using (Context db = new Context())
            {
                db.SiteLinks.AddRange(siteLinkstoDB);
                db.SaveChanges();
                flag = true;
            }

            return flag;
        }


    }

  
}
