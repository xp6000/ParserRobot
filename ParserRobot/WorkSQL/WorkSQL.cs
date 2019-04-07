using ParserRobot.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ParserRobot.WorkSQL
{
    class WorkSQL<T> where T:ISiteLink
    {
        List<T> listSql = new List<T>();
        List<SiteLinkMagenta> siteLinksMagenta = new List<SiteLinkMagenta>();
        List<SiteLinkMnogo> siteLinksMnogos = new List<SiteLinkMnogo>();
        List<SiteLinkRashod> siteLinksRashods = new List<SiteLinkRashod>();
        List<SiteLinkUnit> siteLinksUnits = new List<SiteLinkUnit>();
        List<SiteLinkZipZip> siteLinksZip = new List<SiteLinkZipZip>();

        public Dictionary<string, string> outSite = new Dictionary<string, string>() { { "mnogochernil.ru", "https" }, { "rashodnika.net", "http" }, { "magentashop.ru", "https" }, { "www.unitrm.ru", "https" } };




        public List<ISiteLink> LoadByName(string name)
        {
            List<ISiteLink> result =  new List<ISiteLink>();
        
            using (Context db = new Context())
            {
                   switch (name)
                    {
                    case ( "zipzip.ru"): { return Conversion.ConversionZ( db.siteLinksZipZip.ToList());   }
                    case ("mnogochernil.ru"): { return Conversion.ConversionZ( db.siteLinksMnogo.ToList()); }
                    case ("rashodnika.net"): { return Conversion.ConversionZ(db.siteLinksRashod.ToList()); }
                    case ("www.unitrm.ru"): { return Conversion.ConversionZ( db.siteLinksUnit.ToList()); }
                    case ("magentashop.ru"): { return Conversion.ConversionZ( db.siteLinksUnit.ToList());  }
                    default:   break;
                    }

               
            }
            return result;
        }

         

        public bool DeleteSiteLink(int id )
        {
            
            return true;
        }

        public bool DivideDatabase()
        {
            return true;
        }
        public bool ClearSQL()
        {
            // http https double link
            return true;
        }

        public bool DeadLink()
        {
            return true;
        }

        public List<ISiteLink> LastAdded()
        {

        }
        public List<T> GetListFromDate(DateTime date)
        {
            return listSql;
        }
        public List<T> GetFromData()
        {
            return listSql;
        }

        public bool MakeFile()
        {
            return true;
        }



    }
}
