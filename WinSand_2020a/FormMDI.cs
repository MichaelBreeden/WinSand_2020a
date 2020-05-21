using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinSand_2020a.Forms;

namespace WinSand_2020a
{
    public partial class FormMDI : Form
    {
        Dictionary<string, string> dictSettings;
        public FormMDI()
        {
            InitializeComponent();
            dictSettings = new Dictionary<string, string>();
            try
            {
                System.Collections.Specialized.NameValueCollection nvc = new System.Collections.Specialized.NameValueCollection();
                foreach (string strKey in nvc.AllKeys)
                    if (dictSettings.ContainsKey(strKey) == false)
                        dictSettings.Add(strKey, nvc[strKey]);
            }
            catch(Exception ex)
            {
                string strError = "You're Hosed-" + ex.Message;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formAPIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormAPI = new FormAPI(this);
            FormAPI.MdiParent = this;
            FormAPI.Show();
        }

        private void formSQLLiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormSQLLite = new Form_SQLLite(this);
            FormSQLLite.MdiParent = this;
            FormSQLLite.Show();
        }
    }
}
