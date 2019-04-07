using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserRobot.Model
{
 
    

    public  class SiteLink: ISiteLink
    {
     [Key]   public int Id { get; set; }
        public string Link { get; set; }
        public string Title { get; set; }
        public DateTime DateTime { get; set; }
        
  
    }
    public class SiteLinkRashod : ISiteLink
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public string Title { get; set; }
        public DateTime DateTime { get; set; }
    }
    public class SiteLinkUnit : ISiteLink
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public string Title { get; set; }
        public DateTime DateTime { get; set; }
    }
    public class SiteLinkMnogo : ISiteLink
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public string Title { get; set; }
        public DateTime DateTime { get; set; }
    }
    public class SiteLinkMagenta : ISiteLink
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public string Title { get; set; }
        public DateTime DateTime { get; set; }
    }
    public class SiteLinkZipZip : ISiteLink
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public string Title { get; set; }
        public DateTime DateTime { get; set; }
    }
}
