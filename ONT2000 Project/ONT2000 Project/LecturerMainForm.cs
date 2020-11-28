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
    public partial class LecturerMainForm : Form
    {
        int getUserID;
        string userType;
        public LecturerMainForm(int value, string type)
        {
            InitializeComponent();
            getUserID = value;
            userType = type;
        }

        private void LecturerMainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnListModules_Click(object sender, EventArgs e)
        {
            ListModulesClick();
            ResetCreateAssessment();
            ResetListStudents();
            ResetSearchAssessments();
        }

        private void btnCreateAssessment_Click(object sender, EventArgs e)
        {
            CreateAssessmentClick();
            ResetListModules();
            ResetListStudents();
            ResetSearchAssessments();
        }

        private void btnListStudents_Click(object sender, EventArgs e)
        {
            ListStudentsClick();
            ResetListModules();
            ResetCreateAssessment();
            ResetSearchAssessments();
        }

        private void btnSearchAssessment_Click(object sender, EventArgs e)
        {
            SearchAssessmentClick();
            ResetListModules();
            ResetListStudents();
            ResetCreateAssessment();
        }



        // userinterface code

        // click methods

        public void ListModulesClick()
        {
            btnListModules.ImageAlign = ContentAlignment.MiddleRight;
            btnListModules.IconColor = Color.FromArgb(0, 0, 64);
            btnListModules.BackColor = Color.FromArgb(78, 184, 206);
            btnListModules.FlatAppearance.BorderSize = 3;
            btnListModules.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 64);
            btnListModules.ForeColor = Color.FromArgb(0, 0, 64);
            currentTabIcon.IconChar = FontAwesome.Sharp.IconChar.Book;
            lblCurrentTab.Text = "Your Modules";

            ListModulesForm list = new ListModulesForm(getUserID, userType);
            list.TopLevel = false;
            list.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(list);
            childFormPanel.Tag = list;
            list.BringToFront();
            list.Show();
        }

        public void CreateAssessmentClick()
        {
            btnCreateAssessment.ImageAlign = ContentAlignment.MiddleRight;
            btnCreateAssessment.IconColor = Color.FromArgb(0, 0, 64);
            btnCreateAssessment.BackColor = Color.FromArgb(78, 184, 206);
            btnCreateAssessment.FlatAppearance.BorderSize = 3;
            btnCreateAssessment.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 64);
            btnCreateAssessment.ForeColor = Color.FromArgb(0, 0, 64);
            currentTabIcon.IconChar = FontAwesome.Sharp.IconChar.Pen;
            lblCurrentTab.Text = "Create Assessments";

            CreateAssessmentsForm assess = new CreateAssessmentsForm(getUserID);
            assess.TopLevel = false;
            assess.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(assess);
            childFormPanel.Tag = assess;
            assess.BringToFront();
            assess.Show();
        }

        public void ListStudentsClick()
        {
            btnListStudents.ImageAlign = ContentAlignment.MiddleRight;
            btnListStudents.IconColor = Color.FromArgb(0, 0, 64);
            btnListStudents.BackColor = Color.FromArgb(78, 184, 206);
            btnListStudents.FlatAppearance.BorderSize = 3;
            btnListStudents.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 64);
            btnListStudents.ForeColor = Color.FromArgb(0, 0, 64);
            currentTabIcon.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            lblCurrentTab.Text = "View Students";

            ListStudentsForm list = new ListStudentsForm();
            list.TopLevel = false;
            list.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(list);
            childFormPanel.Tag = list;
            list.BringToFront();
            list.Show();
        }

        public void SearchAssessmentClick()
        {
            btnSearchAssessment.ImageAlign = ContentAlignment.MiddleRight;
            btnSearchAssessment.IconColor = Color.FromArgb(0, 0, 64);
            btnSearchAssessment.BackColor = Color.FromArgb(78, 184, 206);
            btnSearchAssessment.FlatAppearance.BorderSize = 3;
            btnSearchAssessment.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 64);
            btnSearchAssessment.ForeColor = Color.FromArgb(0, 0, 64);
            currentTabIcon.IconChar = FontAwesome.Sharp.IconChar.Search;
            lblCurrentTab.Text = "Search Assessments";

            SearchAssessmentForm search = new SearchAssessmentForm(getUserID);
            search.TopLevel = false;
            search.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(search);
            childFormPanel.Tag = search;
            search.BringToFront();
            search.Show();
        }

        // Reset Methods

        public void ResetListModules()
        {
            btnListModules.ImageAlign = ContentAlignment.MiddleLeft;
            btnListModules.IconColor = Color.White;
            btnListModules.BackColor = Color.Navy;
            btnListModules.FlatAppearance.BorderSize = 0;
            btnListModules.ForeColor = Color.White;
        }

        public void ResetCreateAssessment()
        {
            btnCreateAssessment.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateAssessment.IconColor = Color.White;
            btnCreateAssessment.BackColor = Color.Navy;
            btnCreateAssessment.FlatAppearance.BorderSize = 0;
            btnCreateAssessment.ForeColor = Color.White;

        }

        public void ResetListStudents()
        {
            btnListStudents.ImageAlign = ContentAlignment.MiddleLeft;
            btnListStudents.IconColor = Color.White;
            btnListStudents.BackColor = Color.Navy;
            btnListStudents.FlatAppearance.BorderSize = 0;
            btnListStudents.ForeColor = Color.White;
        }

        public void ResetSearchAssessments()
        {
            btnSearchAssessment.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchAssessment.IconColor = Color.White;
            btnSearchAssessment.BackColor = Color.Navy;
            btnSearchAssessment.FlatAppearance.BorderSize = 0;
            btnSearchAssessment.ForeColor = Color.White;
        }

    }
}
