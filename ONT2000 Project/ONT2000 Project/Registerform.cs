using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BLL;
using DAL;


namespace ONT2000_Project
{
    public partial class Registerform : Form
    {
        string emailAdd;
        string role;
        public Registerform(string email,string type)
        {
            InitializeComponent();

            emailAdd = email;
            role = type;
        }

        private void Registerform_Load(object sender, EventArgs e)
        {
            HideName();
            cmbTitle.Items.Add("Mr");
            cmbTitle.Items.Add("Mrs");
            cmbTitle.Items.Add("Miss");
            cmbTitle.Items.Add("Dr");
            cmbTitle.Items.Add("Prof");

            cmbRole.Items.Add("Administrator");
            cmbRole.Items.Add("Lecturer");
            cmbRole.Items.Add("Student");
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn sign = new SignIn(emailAdd,role);
            sign.Show();
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
            User user = new User();
            string pattern = "^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$";

            if (Regex.IsMatch(txtEmailAddress.Text, pattern) == false)
            {
                emailError.SetError(txtEmailAddress, "Invalid email");
            }
            else if (string.IsNullOrEmpty(txtName.Text))
            {
                nameError.SetError(txtName, "Do not leave this field empty");
            }
            else if (string.IsNullOrEmpty(txtSurname.Text))
            {
                surnameError.SetError(txtSurname, "Do not leave this field empty");
            }
            else if (cmbTitle.SelectedItem == null)
            {
                titleError.SetError(cmbTitle, "Select title");
            }
            else if (cmbRole.SelectedItem == null)
            {
                roleError.SetError(cmbRole, "Select role");
            }
            else if (string.IsNullOrEmpty(txtEmailAddress.Text))
            {
                emailError.SetError(txtEmailAddress, "Do not leave this field empty");
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                passwordError.SetError(txtPassword, "Do not leave this field empty");
            }
            else
            {

                user.name = txtName.Text;
                user.surname = txtSurname.Text;
                user.Role = cmbRole.SelectedItem.ToString();
                user.title = cmbTitle.SelectedItem.ToString();
                user.email = txtEmailAddress.Text;
                user.password = txtPassword.Text;
                user.userStatus = "Active";

                int x = bll.InsertUser(user);

                if (x > 0)
                {
                    this.Hide();
                    SignIn sign = new SignIn(emailAdd,role);
                    sign.Show();
                    MessageBox.Show(x + " user added!");
                }
                else
                {
                    MessageBox.Show("Failed to add user");
                }
            }
        }

        // Below is the User interface code only DO NOT TOUCH !!!

        private void btnRegisterUser_MouseEnter(object sender, EventArgs e)
        {
            btnRegisterUser.BackColor = Color.FromArgb(78, 184, 206);

        }

        private void btnRegisterUser_MouseLeave(object sender, EventArgs e)
        {
            btnRegisterUser.BackColor = Color.White;
        }

        private void btnSignIn_MouseEnter(object sender, EventArgs e)
        {
            btnSignIn.BackColor = Color.FromArgb(78, 184, 206);
        }

        private void btnSignIn_MouseLeave_1(object sender, EventArgs e)
        {
            btnSignIn.BackColor = Color.White;
        }


        private void txtName_Click(object sender, EventArgs e)
        {
            NameClick();
        }

        private void txtSurname_Click(object sender, EventArgs e)
        {
            SurnameClick();
        }

        private void cmbTitle_Click(object sender, EventArgs e)
        {
            TitleClick();
        }

        private void cmbRole_Click(object sender, EventArgs e)
        {
            RoleClick();
        }

        private void txtEmailAddress_Click(object sender, EventArgs e)
        {
            EmailClick();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            PasswordClick();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "Password" || txtPassword.Text == "")
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnHide_MouseEnter(object sender, EventArgs e)
        {
            btnHide.BackColor = Color.FromArgb(78, 184, 206);
            btnHide.IconColor = Color.White;
            btnHide.IconSize = 45;
        }

        private void btnHide_MouseLeave(object sender, EventArgs e)
        {
            btnHide.BackColor = Color.FromArgb(0, 0, 64);
            btnHide.IconColor = Color.Black;
            btnHide.IconSize = 40;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
            btnClose.IconColor = Color.White;
            btnHide.IconSize = 40;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(0, 0, 64);
            btnClose.IconColor = Color.Black;
            btnHide.IconSize = 30;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        //User interface methods

        // resets Methods

        public void ResetRole()
        {
            if (cmbTitle.Text == "Select role")
            {
                cmbRole.Text = "Select role";
            }

        }

        public void ResetTitle()
        {
            if (cmbTitle.Text == "Select title"||cmbTitle.Text=="")
            {
                cmbTitle.Text = "Select title";
            }
        }

        public void ResetSurname()
        {
            if (txtSurname.Text == "Surname" || txtSurname.Text == "")
            {
                txtSurname.Text = "Surname";
            }
        }

        public void ResetName()
        {
            if (txtName.Text == "Name" || txtName.Text == "")
            {
                txtName.Text = "Name";
            }

        }

        public void ResetEmail()
        {
            if (txtEmailAddress.Text == "Email Address" || txtEmailAddress.Text == "")
            {
                emailIcon.IconColor = Color.White;
                emailPanel.BackColor = Color.White;
                txtEmailAddress.Text = "Email Address";
            }
            else
            {
                emailIcon.IconColor = Color.White;
                emailPanel.BackColor = Color.White;
            }
        }
        public void ResetPassword()
        {
            if (txtPassword.Text == "Password" || txtPassword.Text == "")
            {
                PasswordIcon.IconColor = Color.White;
                passwordPanel.BackColor = Color.White;
                txtPassword.Text = "Password";
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordIcon.IconColor = Color.White;
                passwordPanel.BackColor = Color.White;
            }
        }

        public void UnhideName()
        {
            txtSurname.Visible = true;
            cmbRole.Visible = true;
            cmbTitle.Visible = true;
            namePanel.Visible = true;
            namePanel1.Hide();
        }

        //Click Methods


        public void NameClick()
        {
            if (txtName.Text == "Name" || txtName.Text == "")
            {
                userIcon.IconColor = Color.FromArgb(78, 184, 206);
                UnhideName();
                namePanel.BackColor = Color.FromArgb(78, 184, 206);
                txtName.Text = "";
                ResetSurname();
                ResetRole();
                ResetTitle();
                ResetEmail();
                ResetPassword();
            }
            else
            {
                userIcon.IconColor = Color.FromArgb(78, 184, 206);
                namePanel.BackColor = Color.FromArgb(78, 184, 206);
                ResetSurname();
                ResetRole();
                ResetTitle();
                ResetEmail();
                ResetPassword();
            }
        }

        public void RoleClick()
        {
            if (cmbRole.Text == "Select Role")
            {
                cmbRole.Text = "";
                namePanel.BackColor = Color.FromArgb(78, 184, 206);
                userIcon.IconColor = Color.FromArgb(78, 184, 206);
                ResetName();
                ResetSurname();
                ResetTitle();
                ResetEmail();
                ResetPassword();
            }
            else
            {
                namePanel.BackColor = Color.FromArgb(78, 184, 206);
                userIcon.IconColor = Color.FromArgb(78, 184, 206);
                ResetName();
                ResetSurname();
                ResetTitle();
                ResetEmail();
                ResetPassword();
            }
        }

        public void TitleClick()
        {
            if (cmbTitle.Text == "Select title")
            {
                cmbTitle.Text = "";
                namePanel.BackColor = Color.FromArgb(78, 184, 206);
                userIcon.IconColor = Color.FromArgb(78, 184, 206);
                ResetName();
                ResetSurname();
                ResetRole();
                ResetEmail();
                ResetPassword();
            }
            else
            {
                namePanel.BackColor = Color.FromArgb(78, 184, 206);
                userIcon.IconColor = Color.FromArgb(78, 184, 206);

                ResetName();
                ResetSurname();
                ResetRole();
                ResetEmail();
                ResetPassword();
            }
        }

        public void SurnameClick()
        {
            if (txtSurname.Text == "Surname" || txtSurname.Text == "")
            {
                namePanel.BackColor = Color.FromArgb(78, 184, 206);
                userIcon.IconColor = Color.FromArgb(78, 184, 206);

                ResetName();
                ResetRole();
                ResetTitle();
                ResetEmail();
                ResetPassword();
                txtSurname.Text = null;

            }
            else
            {
                namePanel.BackColor = Color.FromArgb(78, 184, 206);
                userIcon.IconColor = Color.FromArgb(78, 184, 206);

                ResetRole();
                ResetTitle();
                ResetName();
                ResetEmail();
                ResetPassword();
            }
        }

        public void EmailClick()
        {
            if (txtEmailAddress.Text == "Email Address" || txtEmailAddress.Text == "")
            {
                txtEmailAddress.Clear();
                emailIcon.IconColor = Color.FromArgb(78, 184, 206);
                emailPanel.BackColor = Color.FromArgb(78, 184, 206);

                namePanel.BackColor = Color.White;
                userIcon.IconColor = Color.White;

                ResetName();
                ResetSurname();
                ResetTitle();
                ResetRole();
                ResetPassword();
            }
            else
            {
                emailIcon.IconColor = Color.FromArgb(78, 184, 206);
                emailPanel.BackColor = Color.FromArgb(78, 184, 206);

                namePanel.BackColor = Color.White;
                userIcon.IconColor = Color.White;

                ResetName();
                ResetSurname();
                ResetTitle();
                ResetRole();
                ResetPassword();
            }
        }

        public void PasswordClick()
        {
            if (txtPassword.Text == "Password" || txtPassword.Text == "")
            {
                PasswordIcon.IconColor = Color.FromArgb(78, 184, 206);
                passwordPanel.BackColor = Color.FromArgb(78, 184, 206);
                txtPassword.Text = null;

                namePanel.BackColor = Color.White;
                userIcon.IconColor = Color.White;

                ResetName();
                ResetSurname();
                ResetTitle();
                ResetRole();
                ResetEmail();
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                PasswordIcon.IconColor = Color.FromArgb(78, 184, 206);
                passwordPanel.BackColor = Color.FromArgb(78, 184, 206);

                namePanel.BackColor = Color.White;
                userIcon.IconColor = Color.White;

                ResetName();
                ResetSurname();
                ResetTitle();
                ResetRole();
                ResetEmail();
            }
        }

        public void HideName()
        {
            txtSurname.Hide();
            cmbRole.Hide();
            cmbTitle.Hide();
            namePanel.Hide();
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTitle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
