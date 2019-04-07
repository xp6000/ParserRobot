using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserRobot.Model
{
    class Context : DbContext
    {
        public DbSet<SiteLink> SiteLinks { get; set; }
        public DbSet<SiteLinkMagenta>  SiteLinksMagenta { get; set; }
        public DbSet<SiteLinkMnogo> siteLinksMnogo { get; set; }
        public DbSet<SiteLinkRashod> siteLinksRashod { get; set; }
        public DbSet<SiteLinkUnit> siteLinksUnit { get; set; }
        public DbSet<SiteLinkZipZip> siteLinksZipZip { get; set; }






        public Context() : base(@"Server=PRINTERHACKER\SQLEXPRESS;Database=netMvc;Trusted_Connection=True;")
        {

        }
    }
}
