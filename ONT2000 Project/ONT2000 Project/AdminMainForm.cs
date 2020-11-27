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
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchModule_Click(object sender, EventArgs e)
        {
            SearchModuleClick();
            ResetSearchUsers();
            ResetAssignLecturer();
            ResetManageModules();
            ResetEnrollStudent();
            ResetManageUsers();
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            SearchUserClick();
            ResetSearchModules();
            ResetAssignLecturer();
            ResetManageModules();
            ResetEnrollStudent();
            ResetManageUsers();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            manageUsersClick();
            ResetAssignLecturer();
            ResetManageModules();
            ResetEnrollStudent();
            ResetSearchModules();
            ResetSearchUsers();

            //this.Hide();
            //ManageUsers manageUser = new ManageUsers();
            //manageUser.Show();
        }

        private void btnManageModules_Click(object sender, EventArgs e)
        {
            ManageModuleClick();
            ResetManageUsers();
            ResetAssignLecturer();
            ResetEnrollStudent();
            ResetSearchModules();
            ResetSearchUsers();

            //this.Hide();
            //ManageModules manageModule = new ManageModules();
            //manageModule.Show();
        }

        private void btnAssignLecturer_Click(object sender, EventArgs e)
        {
            AssignLecturerClick();
            ResetManageUsers();
            ResetManageModules();
            ResetEnrollStudent();
            ResetSearchModules();
            ResetSearchUsers();
        }

        private void btnEnrollStudent_Click(object sender, EventArgs e)
        {
            EnrollStudentClick();
            ResetManageUsers();
            ResetManageModules();
            ResetAssignLecturer();
            ResetSearchModules();
            ResetSearchUsers();
        }


        //User interface code DO NOT TOUCH

        // Clicks Methods

        public void SearchModuleClick()
        {
            btnSearchModule.ImageAlign = ContentAlignment.MiddleRight;
            btnSearchModule.IconColor = Color.FromArgb(0, 0, 64);
            btnSearchModule.BackColor = Color.FromArgb(78, 184, 206);
            btnSearchModule.FlatAppearance.BorderSize = 3;
            btnSearchModule.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 64);
            btnSearchModule.ForeColor = Color.FromArgb(0, 0, 64);
            currentTabIcon.IconChar = FontAwesome.Sharp.IconChar.Search;
            lblCurrentTab.Text = "Search Modules";


            SearchModules search = new SearchModules();
            search.TopLevel = false;
            search.Dock = DockStyle.Fill;
            ChildFormPanel.Controls.Add(search);
            ChildFormPanel.Tag = search;
            search.BringToFront();
            search.Show();

        }

        public void SearchUserClick()
        {
            btnSearchUser.ImageAlign = ContentAlignment.MiddleRight;
            btnSearchUser.IconColor = Color.FromArgb(0, 0, 64);
            btnSearchUser.BackColor = Color.FromArgb(78, 184, 206);
            btnSearchUser.FlatAppearance.BorderSize = 3;
            btnSearchUser.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 64);
            btnSearchUser.ForeColor = Color.FromArgb(0, 0, 64);
            currentTabIcon.IconChar = FontAwesome.Sharp.IconChar.Search;
            lblCurrentTab.Text = "Search Users";

            SearchUser user = new SearchUser();
            user.TopLevel = false;
            user.Dock = DockStyle.Fill;
            ChildFormPanel.Controls.Add(user);
            ChildFormPanel.Tag = user;
            user.BringToFront();
            user.Show();
        }

        public void manageUsersClick()
        {
            btnManageUsers.ImageAlign = ContentAlignment.MiddleRight;
            btnManageUsers.IconColor = Color.FromArgb(0,0,64);
            btnManageUsers.BackColor = Color.FromArgb(78, 184, 206);
            btnManageUsers.FlatAppearance.BorderSize = 3;
            btnManageUsers.FlatAppearance.BorderColor = Color.FromArgb(0,0,64);
            btnManageUsers.ForeColor = Color.FromArgb(0,0,64);
            currentTabIcon.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            lblCurrentTab.Text = "Manage Users";

            // Display child form

            ManageUsers user = new ManageUsers();
            user.TopLevel = false;
            user.Dock = DockStyle.Fill;
            ChildFormPanel.Controls.Add(user);
            ChildFormPanel.Tag = user;
            user.BringToFront();
            user.Show();

        }

        public void ManageModuleClick()
        {
            btnManageModules.ImageAlign = ContentAlignment.MiddleRight;
            btnManageModules.IconColor = Color.FromArgb(0,0,64);
            btnManageModules.BackColor = Color.FromArgb(78, 184, 206);
            btnManageModules.FlatAppearance.BorderSize = 3;
            btnManageModules.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 64);
            btnManageModules.ForeColor = Color.FromArgb(0,0,64);
            currentTabIcon.IconChar = FontAwesome.Sharp.IconChar.Book;
            lblCurrentTab.Text = "Manage Modules";


            // Display Manage module child form

            ManageModules module = new ManageModules();
            module.TopLevel = false;
            module.Dock = DockStyle.Fill;
            ChildFormPanel.Controls.Add(module);
            ChildFormPanel.Tag = module;
            module.BringToFront();
            module.Show();

        }

        public void AssignLecturerClick()
        {
            btnAssignLecturer.ImageAlign = ContentAlignment.MiddleRight;
            btnAssignLecturer.IconColor = Color.FromArgb(0,0,64);
            btnAssignLecturer.BackColor = Color.FromArgb(78, 184, 206);
            btnAssignLecturer.FlatAppearance.BorderSize = 3;
            btnAssignLecturer.FlatAppearance.BorderColor = Color.FromArgb(0,0,64);
            btnAssignLecturer.ForeColor = Color.FromArgb(0,0,64);
            currentTabIcon.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            lblCurrentTab.Text = "Assign lecturers to a module";

            // Display Manage module child form

            ManageLecturerModule moduleLecturer = new ManageLecturerModule();
            moduleLecturer.TopLevel = false;
            moduleLecturer.Dock = DockStyle.Fill;
            ChildFormPanel.Controls.Add(moduleLecturer);
            ChildFormPanel.Tag = moduleLecturer;
            moduleLecturer.BringToFront();
            moduleLecturer.Show();
        }
        public void EnrollStudentClick()
        {
            btnEnrollStudent.ImageAlign = ContentAlignment.MiddleRight;
            btnEnrollStudent.IconColor = Color.FromArgb(0,0,64);
            btnEnrollStudent.BackColor = Color.FromArgb(78, 184, 206);
            btnEnrollStudent.FlatAppearance.BorderSize = 3;
            btnEnrollStudent.FlatAppearance.BorderColor = Color.FromArgb(0,0,64);
            btnEnrollStudent.ForeColor = Color.FromArgb(0,0,64);
            currentTabIcon.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            lblCurrentTab.Text = "Enroll students to a module";

            // Display Manage module child form

            ManageStudentModules manage = new ManageStudentModules();
            manage.TopLevel = false;
            manage.Dock = DockStyle.Fill;
            ChildFormPanel.Controls.Add(manage);
            ChildFormPanel.Tag = manage;
            manage.BringToFront();
            manage.Show();
        }

        //Reset Buttons methods

        public void ResetSearchModules()
        {
            btnSearchModule.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchModule.IconColor = Color.White;
            btnSearchModule.BackColor = Color.Navy;
            btnSearchModule.FlatAppearance.BorderSize = 0;
            btnSearchModule.ForeColor = Color.White;

        }

        public void ResetSearchUsers()
        {
            btnSearchUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchUser.IconColor = Color.White;
            btnSearchUser.BackColor = Color.Navy;
            btnSearchUser.FlatAppearance.BorderSize = 0;
            btnSearchUser.ForeColor = Color.White;
        }

        public void ResetManageUsers()
        {
            btnManageUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnManageUsers.IconColor = Color.White;
            btnManageUsers.BackColor = Color.Navy;
            btnManageUsers.FlatAppearance.BorderSize = 0;
            btnManageUsers.ForeColor = Color.White;
        }

        public void ResetManageModules()
        {
            btnManageModules.ImageAlign = ContentAlignment.MiddleLeft;
            btnManageModules.IconColor = Color.White;
            btnManageModules.BackColor = Color.Navy;
            btnManageModules.FlatAppearance.BorderSize = 0;
            btnManageModules.ForeColor = Color.White;

            //Close form

            ManageModules module = new ManageModules();

            module.Hide();
        }

        public void ResetAssignLecturer()
        {
            btnAssignLecturer.ImageAlign = ContentAlignment.MiddleLeft;
            btnAssignLecturer.IconColor = Color.White;
            btnAssignLecturer.BackColor = Color.Navy;
            btnAssignLecturer.FlatAppearance.BorderSize = 0;
            btnAssignLecturer.ForeColor = Color.White;

            ManageLecturerModule manage = new ManageLecturerModule();
            manage.Hide();
        }

        public void ResetEnrollStudent()
        {
            btnEnrollStudent.ImageAlign = ContentAlignment.MiddleLeft;
            btnEnrollStudent.IconColor = Color.White;
            btnEnrollStudent.BackColor = Color.Navy;
            btnEnrollStudent.FlatAppearance.BorderSize = 0;
            btnEnrollStudent.ForeColor = Color.White;

            //close window

            ManageStudentModules stdnt = new ManageStudentModules();
            stdnt.Hide();
        }

        private void currentTabIcon_Click(object sender, EventArgs e)
        {

        }


    }
}
