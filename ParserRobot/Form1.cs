using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParserRobot.Model;
using ParserRobot.Parser;

namespace ParserRobot
{
    public partial class Form1 : Form
    {
       AParser<SiteLink> aParser;       
       List<SiteLink> siteLinksAll = new List<SiteLink>();
       List<SiteLink> siteLinkGrabbers = new List<SiteLink>();

        string nameSiteForParse="";
  
        public Form1()
        {
            InitializeComponent();
        }

        private void radioRN_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRN.Checked)
            {
                aParser = new RMParser<SiteLink>();
                nameSiteForParse = "http://rashodnika.net/";
                txtOut.Text = nameSiteForParse;
            }

        }

        private void radioMS_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMagenta.Checked) { aParser = new MagentaParser<SiteLink>(); nameSiteForParse = "https://magentashop.ru/"; txtOut.Text = nameSiteForParse; }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            FullGrabber<SiteLink> fullGrabber = new FullGrabber<SiteLink>();
            if (fullGrabber.SaveDB(siteLinkGrabbers))
            {
                MessageBox.Show("SaveDB is OK");
            }
        }



        private void btnStart_Click(object sender, EventArgs e)
        {
            Uri[] uris = aParser.GetUrlCatalog();
          

            foreach (Uri item in uris)
            {
                siteLinksAll.AddRange(aParser.GetSiteLinkFromPage(item, nameSiteForParse));
                txtOut.Text += "+";
            }

            siteLinksAll = aParser.CheckDoubleLinkinList(siteLinksAll);
            dataGrid.DataSource = siteLinksAll;
            dataGrid.Refresh();
        }

        private void btnChkChange_Click(object sender, EventArgs e)
        {
            List<SiteLink> siteLinksSQL = aParser.GetSiteLinksFromSQL();
            siteLinksAll = aParser.MakeCompare(siteLinksAll, siteLinksSQL);
            dataGrid.DataSource = siteLinksAll;
            dataGrid.Refresh();

        }

        private void btnSaveDB_Click(object sender, EventArgs e)
        {
            try
            {
                aParser.SaveDB(siteLinksAll);
                MessageBox.Show("Save is OK");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnGetLink_Click(object sender, EventArgs e)
        {
            FullGrabber<SiteLink> parser = new FullGrabber<SiteLink>();
            string name = txtIn.Text;

            List<SiteLink> siteLinks = parser.GetLinkByUrl(name, name);



        }

        private void radioMnogo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMnogo.Checked) { aParser = new MnogoParser<SiteLink>(); nameSiteForParse = "https://mnogochernil.ru/"; txtOut.Text = nameSiteForParse; }

        }

        private void radioUnit_CheckedChanged(object sender, EventArgs e)
        {
            if (radioUnit.Checked) { aParser = new Unitparser<SiteLink>(); nameSiteForParse = "https://www.unitrm.ru/"; txtOut.Text = nameSiteForParse; }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ZipParser<SiteLink> zipParser = new ZipParser<SiteLink>();

            zipParser.GetListfromFile("https://zipzip.ru/price.zip");



        }

        private void btnSqlEditor_Click(object sender, EventArgs e)
        {
            Form form = new SQLEditor();
            form.Show();
        }

        private void btnFullGrabber_Click(object sender, EventArgs e)
        {
            string name = txtIn.Text;
            FullGrabber<SiteLink> fullGrabber = new FullGrabber<SiteLink>();
            siteLinkGrabbers = fullGrabber.MainGrabber(name);

            dataGrid.DataSource = siteLinkGrabbers;
            dataGrid.Refresh();
        }

        private void btnCheckTask_Click(object sender, EventArgs e)
        {
            FullGrabber<SiteLink> parser = new FullGrabber<SiteLink>();
            string name = txtIn.Text;

            List<SiteLink> siteLinks = parser.GetLinkByUrl(name, name);
            List<SiteLink> newResult = parser.FastGetLinkFromList(siteLinks, name);

            dataGrid.DataSource = newResult;
            dataGrid.Refresh();
       
        }
    }
}
