using ParserRobot.Model;
using ParserRobot.Parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParserRobot
{
    public partial class SQLEditor : Form
    {
      

        List<SiteLink> siteLinks;

        public SQLEditor()
        {
            InitializeComponent();
           

            using (Context db = new Context())
            {
                siteLinks = db.SiteLinks.ToList();
            }
            dataSQLEd.DataSource = siteLinks;
        }
        public SQLEditor(List<SiteLink> siteLinksfromForm)
        {
            siteLinks = siteLinksfromForm;
            InitializeComponent();
            dataSQLEd.DataSource = siteLinks;
        }

        public List<SiteLink>  ClearLinq(List<SiteLink> siteLinks)
        {
            for (int i = 0; i < siteLinks.Count; i++)
            {
                siteLinks[i].Link = siteLinks[i].Link.ToLower().Replace("//", "/");
                siteLinks[i].Link = siteLinks[i].Link.Replace("http:/", "").Replace("https:/", "");
            }



            return siteLinks;
        }

        private void btnReadSql_Click(object sender, EventArgs e)
        {
            List<SiteLink> links;
            DateTime date = dateTimePicker.Value;

            links = siteLinks.Where( (x)=> (x.DateTime >= date)).ToList();

            dataSQLEd.Refresh();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            siteLinks = ClearLinq(siteLinks);
            dataSQLEd.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (Context db = new Context())
                {
                    foreach (SiteLink item in siteLinks)
                    {
                    
                   
                       var f =      db.SiteLinks.Remove(db.SiteLinks.Where(x => x.Id == item.Id).First());

                       
                    }

                  
                }
            
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
