using ParserRobot.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParserRobot.Parser
{
    class ZipParser<T> : AParser<T> where T : SiteLink, new()
    {
        public override List<T> GetListfromFile(string uri)
        {
            List<T> fromCSV = new List<T>();
            Uri link = new Uri(uri);
            string filename = @"F:\project\ParserForSiteNews\ParserRobot\ParserRobot\Files\zipzip"+DateTime.Now.Day.ToString()+"-"+ DateTime.Now.Month.ToString()+".zip";
        
            using (var client = new WebClient())
            {
                client.DownloadFile(link, filename);
            }





            return fromCSV;

        }

        public override Uri[] GetUrlCatalog()
        {
            throw new NotImplementedException();
        }
    }
}
