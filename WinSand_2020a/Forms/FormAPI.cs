using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinSand_2020a.Classes;

namespace WinSand_2020a.Forms
{
    public partial class FormAPI : Form
    {
        Form formMyParent;
        public FormAPI(Form ParentForm)
        {
            InitializeComponent();
            formMyParent = ParentForm;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // https://leanpub.com/dot-net-core-api-tutorial/c/VO4ODc7pOgc0
        // Les Jackson - GET API
        // from https://www.youtube.com/watch?v=11f5KzVNQ90
        // http://dry-cliffs-19849.herokuapp.com/users.json - list of people,email
        // .../users/2.json or users/2.html
        private void tabPage_API_1_button_Go_Click(object sender, EventArgs e)
        {
            debugOutput("Let's Go...");
            RestClient rClient = new RestClient();
            rClient.endPoint = tabPage_API_1textBox_URL.Text;
            debugOutput("Rest Client created...");

            string strResponse = String.Empty;
            strResponse = rClient.makeRequest();
            debugOutput(strResponse);
        }

        // Les Jackson - POST API
        // https://www.youtube.com/watch?v=_6IdfPMxYFI
        // Add a data object to a repository.

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine); // Write to output
                tabPage_API_1_textBox_Response.Text = tabPage_API_1_textBox_Response.Text + strDebugText + Environment.NewLine;
                tabPage_API_1_textBox_Response.SelectionStart = tabPage_API_1_textBox_Response.TextLength;
                tabPage_API_1_textBox_Response.ScrollToCaret();
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message + Environment.NewLine);
            }
        }

        //https://www.youtube.com/watch?v=gW507cOiTRw
        // Nice enough POST with Credentials 

        //https://www.youtube.com/watch?v=_6IdfPMxYFI
        // The guy I made the API site from. 
    }
}
