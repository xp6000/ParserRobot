using ParserRobot.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserRobot.WorkSQL
{
  public  class Conversion
    {
        public static List<ISiteLink> ConversionZ(List<SiteLinkZipZip> siteLinks)
        {
            List<ISiteLink> result = new List<ISiteLink>();
            foreach (var item in siteLinks)
            {
                result.Add((ISiteLink)item);
            }
            return result;
        }
        public static List<ISiteLink> ConversionZ(List<SiteLinkMagenta> siteLinks)
        {
            List<ISiteLink> result = new List<ISiteLink>();
            foreach (var item in siteLinks)
            {
                result.Add((ISiteLink)item);
            }
            return result;
        }
        public static List<ISiteLink> ConversionZ(List<SiteLinkRashod> siteLinks)
        {
            List<ISiteLink> result = new List<ISiteLink>();
            foreach (var item in siteLinks)
            {
                result.Add((ISiteLink)item);
            }
            return result;
        }
        public static List<ISiteLink> ConversionZ(List<SiteLinkUnit> siteLinks)
        {
            List<ISiteLink> result = new List<ISiteLink>();
            foreach (var item in siteLinks)
            {
                result.Add((ISiteLink)item);
            }
            return result;
        }
        public static List<ISiteLink> ConversionZ(List<SiteLinkMnogo> siteLinks)
        {
            List<ISiteLink> result = new List<ISiteLink>();
            foreach (var item in siteLinks)
            {
                result.Add((ISiteLink)item);
            }
            return result;
        }
    }
}
