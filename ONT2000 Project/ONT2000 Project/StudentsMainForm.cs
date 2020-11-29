using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ONT2000_Project
{
    public partial class StudentsMainForm : Form
    {
        int getUserID;
        string userType;
        string profile;
        public StudentsMainForm(int value, string type,string names)
        {
            InitializeComponent();
            getUserID = value;
            userType = type;
            profile = names;
        }

        private void StudentsMainForm_Load(object sender, EventArgs e)
        {
            lblProfile.Text = profile;
        }

        private void btnListModules_Click(object sender, EventArgs e)
        {
            ListModuleClick();
            ResetSearchAssessment();
            ResetSearchModule();
            ResetListAssessments();
        }

        private void btnSearchModule_Click(object sender, EventArgs e)
        {
            SearchModulesClick();
            ResetListModules();
            ResetSearchAssessment();
            ResetListAssessments();
        }

        private void btnSearchAssessments_Click(object sender, EventArgs e)
        {
            SearchAssessmentsClick();
            ResetListModules();
            ResetSearchModule();
            ResetListAssessments();
        }

        private void btnListAssessments_Click(object sender, EventArgs e)
        {
            ListAssessmentsClick();
            ResetListModules();
            ResetSearchAssessment();
            ResetSearchModule();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            currentTabIcon.IconChar = FontAwesome.Sharp.IconChar.Home;
            lblCurrentTab.Text = "Home";

            childFormPanel.Controls.Clear();

            childFormPanel.Controls.Add(pictureBox2);

            ResetListModules();
            ResetSearchAssessment();
            ResetSearchModule();
            ResetListAssessments();
        }

        //Userinterface code

        //Click Methods

        public void ListModuleClick()
        {
            btnListModules.ImageAlign = ContentAlignment.MiddleRight;
            btnListModules.IconColor = Color.FromArgb(0, 0, 64);
            btnListModules.BackColor = Color.FromArgb(78, 184, 206);
            btnListModules.FlatAppearance.BorderSize = 3;
            btnListModules.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 64);
            btnListModules.ForeColor = Color.FromArgb(0, 0, 64);
            currentTabIcon.IconChar = FontAwesome.Sharp.IconChar.Book;
            lblCurrentTab.Text = "Your Modules";

            bool back = true;

            ListModulesForm list = new ListModulesForm(getUserID, userType, back);
            list.TopLevel = false;
            list.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(list);
            childFormPanel.Tag = list;
            list.BringToFront();
            list.Show();
        }

        public void SearchAssessmentsClick()
        {
            btnSearchAssessments.ImageAlign = ContentAlignment.MiddleRight;
            btnSearchAssessments.IconColor = Color.FromArgb(0, 0, 64);
            btnSearchAssessments.BackColor = Color.FromArgb(78, 184, 206);
            btnSearchAssessments.FlatAppearance.BorderSize = 3;
            btnSearchAssessments.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 64);
            btnSearchAssessments.ForeColor = Color.FromArgb(0, 0, 64);
            currentTabIcon.IconChar = FontAwesome.Sharp.IconChar.Search;
            lblCurrentTab.Text = "Search Assessments";

            SearchStudentAssessment search = new SearchStudentAssessment(getUserID);
            search.TopLevel = false;
            search.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(search);
            childFormPanel.Tag = search;
            search.BringToFront();
            search.Show();
        }

        public void SearchModulesClick()
        {
            btnSearchModule.ImageAlign = ContentAlignment.MiddleRight;
            btnSearchModule.IconColor = Color.FromArgb(0, 0, 64);
            btnSearchModule.BackColor = Color.FromArgb(78, 184, 206);
            btnSearchModule.FlatAppearance.BorderSize = 3;
            btnSearchModule.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 64);
            btnSearchModule.ForeColor = Color.FromArgb(0, 0, 64);
            currentTabIcon.IconChar = FontAwesome.Sharp.IconChar.Search;
            lblCurrentTab.Text = "Search Module";

            SearchStudentModule search = new SearchStudentModule(getUserID);
            search.TopLevel = false;
            search.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(search);
            childFormPanel.Tag = search;
            search.BringToFront();
            search.Show();
        }

        public void ListAssessmentsClick()
        {
            btnListAssessments.ImageAlign = ContentAlignment.MiddleRight;
            btnListAssessments.IconColor = Color.FromArgb(0, 0, 64);
            btnListAssessments.BackColor = Color.FromArgb(78, 184, 206);
            btnListAssessments.FlatAppearance.BorderSize = 3;
            btnListAssessments.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 64);
            btnListAssessments.ForeColor = Color.FromArgb(0, 0, 64);
            currentTabIcon.IconChar = FontAwesome.Sharp.IconChar.List;
            lblCurrentTab.Text = "List Assessments";

            ListStudentAssessments list = new ListStudentAssessments(getUserID);
            list.TopLevel = false;
            list.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(list);
            childFormPanel.Tag = list;
            list.BringToFront();
            list.Show();

        }


        //Reset Methods

        public void ResetListModules()
        {
            btnListModules.ImageAlign = ContentAlignment.MiddleLeft;
            btnListModules.IconColor = Color.White;
            btnListModules.BackColor = Color.Navy;
            btnListModules.FlatAppearance.BorderSize = 0;
            btnListModules.ForeColor = Color.White;
        }

        public void ResetSearchAssessment()
        {
            btnSearchAssessments.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchAssessments.IconColor = Color.White;
            btnSearchAssessments.BackColor = Color.Navy;
            btnSearchAssessments.FlatAppearance.BorderSize = 0;
            btnSearchAssessments.ForeColor = Color.White;
        }

        public void ResetSearchModule()
        {
            btnSearchModule.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchModule.IconColor = Color.White;
            btnSearchModule.BackColor = Color.Navy;
            btnSearchModule.FlatAppearance.BorderSize = 0;
            btnSearchModule.ForeColor = Color.White;

            //SearchStudentModule search = new SearchStudentModule(getUserID);
            //search.Hide();
        }

        public void ResetListAssessments()
        {
            btnListAssessments.ImageAlign = ContentAlignment.MiddleLeft;
            btnListAssessments.IconColor = Color.White;
            btnListAssessments.BackColor = Color.Navy;
            btnListAssessments.FlatAppearance.BorderSize = 0;
            btnListAssessments.ForeColor = Color.White;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            PasswordCreationForm pass = new PasswordCreationForm();
            pass.Show();
        }
    }
}
