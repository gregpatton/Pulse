using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Pulse
{
    public partial class frmPulse : Form
    {
        public frmPulse()
        {
            InitializeComponent();
        }

        private void cmdPulse_Click(object sender, EventArgs e)
        {
            try
            {
                string siteEval = string.Empty;

                foreach (string site in txtInput.Lines)
                {
                    if (site.Length > 1)
                    {
                        try
                        {
                            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(site);
                            request.Timeout = 60000;
                            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                            ListViewItem lvi = new ListViewItem(site);
                            lvi.SubItems.Add(response.StatusDescription);
                            lvi.SubItems.Add("Server: " + response.Server);
                            lstvwOutput.Items.Add(lvi);
                        }
                        catch (Exception err)
                        {
                            ListViewItem lvi = new ListViewItem(site);
                            lvi.SubItems.Add("Error");
                            lvi.SubItems.Add(err.ToString());
                            lstvwOutput.Items.Add(lvi);
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
        
        private void cmdClear_Click(object sender, EventArgs e)
        {
            try
            {
                lstvwOutput.Items.Clear();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void cmdClearSites_Click(object sender, EventArgs e)
        {
            try
            {
                txtInput.Text = string.Empty;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
    }
}
