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
using WinSand_2020a.ClassLibFrameWork;

namespace WinSand_2020a.Forms
{

    public partial class Form_SQLLite : Form
    {
        Form formMyParent;
        public Form_SQLLite(Form ParentForm)
        {
            InitializeComponent();
            formMyParent = ParentForm;
            LoadPeopleList();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         List<PersonModel> people = new List<PersonModel>();
        private void tabPage1_button_List_Click(object sender, EventArgs e)
        {
            LoadPeopleList();
        }

        private void LoadPeopleList()
        {
            // people.Add(new PersonModel { FirstName = "Mike", LastName = "Breeden" });
            // people.Add(new PersonModel { FirstName = "Debbie", LastName = "Rutman" });
            // people.Add(new PersonModel { FirstName = "Marissa", LastName = "Baggins" });
            people = SQLLiteDatAccess.LoadPeople();
            WireUpPeopleList();
        }

        private void tabPage1_button_Add_Click(object sender, EventArgs e)
        {
            PersonModel p = new PersonModel();
            p.FirstName = tabPage1_textBox_FirstName.Text;
            p.LastName = tabPage1_textBox_LastName.Text;
            SQLLiteDatAccess.SavePerson(p);
            //people.Add(p); // Could, but no
            //WireUpPeopleList();
            p.FirstName = String.Empty;
            p.LastName = String.Empty;
        }

        private void WireUpPeopleList()
        {
            tabPage1_listBox_People.DataSource = null;
            tabPage1_listBox_People.DataSource = people;
            tabPage1_listBox_People.DisplayMember = "FullName";
        }

        private void tabPage1_button_Delete_Click(object sender, EventArgs e)
        {
            PersonModel p = new PersonModel();
            p.FirstName = tabPage1_textBox_FirstName.Text;
            p.LastName = tabPage1_textBox_LastName.Text;
            SQLLiteDatAccess.DeletePerson(p);

        }
    }
}
