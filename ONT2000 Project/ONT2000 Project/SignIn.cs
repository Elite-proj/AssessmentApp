using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace ONT2000_Project
{
    public partial class SignIn : Form
    {
        string emailAdd;
        string role;
        public SignIn(string email,string type)
        {
            InitializeComponent();
            emailAdd = email;
            role = type;
            
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            //DataAccessLayer dal = new DataAccessLayer();

            if (role == "Student" || role == "Lecturer")
            {
                btnRegister.Visible = false;
                txtEmail.Text = emailAdd;
                txtEmail.Enabled = false;
            }
            else if (role == "Administrator")
            {
                btnRegister.Visible = true;
                txtEmail.Text = emailAdd;
                txtEmail.Enabled = true;
            }
            
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registerform reg = new Registerform(emailAdd,role);
            reg.Show();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
            DataTable dt = new DataTable();

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                emailError.SetError(txtEmail, "Do not leave this field empty");
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                passwordError.SetError(txtPassword, "Do not leave this field empty");
            }
            else
            {
                dt = bll.SignIn(txtEmail.Text, txtPassword.Text);

                if (dt.Rows.Count > 0)
                {
                    string userType = dt.Rows[0]["Role"].ToString();
                    int Id = int.Parse(dt.Rows[0]["UserID"].ToString());
                    string names = dt.Rows[0]["Name"].ToString() + " " + dt.Rows[0]["Surname"].ToString();

                    if (userType == "Administrator")
                    {
                        this.Hide();
                        AdminMainForm admin = new AdminMainForm(names);
                        admin.Show();
                    }
                    else if (userType == "Lecturer")
                    {

                        this.Hide();
                        LecturerMainForm lect = new LecturerMainForm(Id, userType, names);
                        lect.Show();
                    }
                    else if (userType == "Student")
                    {
                        this.Hide();
                        StudentsMainForm stud = new StudentsMainForm(Id, userType, names);
                        stud.Show();
                    }

                }
                else
                {
                    MessageBox.Show("User not found!");
                }
            }
        }





        // this is the user interface code only DO NOT TOUCH !!!

        private void txtEmail_Click(object sender, EventArgs e)
        {
            ClickUsername();
        }   
        private void txtPassword_Click(object sender, EventArgs e)
        {
            PasswordClicked();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "Password" && txtPassword.Text != "")
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
                txtPassword.UseSystemPasswordChar = false;
        }

        public void PasswordClicked()
        {
            if (txtPassword.Text == "Password" || txtPassword.Text == "")
            {
                txtPassword.Clear();
                passwordIcon.IconColor = Color.FromArgb(78, 184, 206);
                passwordPanel.BackColor = Color.FromArgb(78, 184, 206);
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                passwordIcon.IconColor = Color.FromArgb(78, 184, 206);
                passwordPanel.BackColor = Color.FromArgb(78, 184, 206);
            }

            //Reset Username colors

            if (txtEmail.Text == "Email Address"||txtEmail.Text=="")
            {
                txtEmail.Text = "Email Address";
                userIcon.IconColor = Color.White;
                emailPanel.BackColor = Color.White;
            }
            else
            {
                userIcon.IconColor = Color.White;
                emailPanel.BackColor = Color.White;
            }
        }

        public void ClickUsername()
        {
            if (txtEmail.Text == "Email Address" || txtEmail.Text == "")
            {
                txtEmail.Clear();
                userIcon.IconColor = Color.FromArgb(78, 184, 206);
                emailPanel.BackColor = Color.FromArgb(78, 184, 206);
            }
            else
            {
                userIcon.IconColor = Color.FromArgb(78, 184, 206);
                emailPanel.BackColor = Color.FromArgb(78, 184, 206);
            }

            //reset password colors

            if (txtPassword.Text == "Password"||txtPassword.Text=="")
            {
                txtPassword.Text = "Password";
                passwordIcon.IconColor = Color.White;
                passwordPanel.BackColor = Color.White;
            }
            else 
            {
                passwordIcon.IconColor = Color.White;
                passwordPanel.BackColor = Color.White;
            }
        }


        private void btnHideIcon_MouseEnter(object sender, EventArgs e)
        {
            btnHideIcon.BackColor= Color.FromArgb(78, 184, 206);
            btnHideIcon.IconColor = Color.White;
            btnHideIcon.IconSize = 30;
        }

        private void btnHideIcon_MouseLeave(object sender, EventArgs e)
        {
            btnHideIcon.BackColor = Color.FromArgb(0, 0, 64);
            btnHideIcon.IconColor = Color.Black;
            btnHideIcon.IconSize = 45;
        }

        private void btnCloseIcon_MouseEnter(object sender, EventArgs e)
        {
            btnCloseIcon.BackColor = Color.Red;
            btnCloseIcon.IconColor = Color.White;
            btnCloseIcon.IconSize = 24;
        }

        private void btnCloseIcon_MouseLeave(object sender, EventArgs e)
        {
            btnCloseIcon.BackColor = Color.FromArgb(0, 0, 64);
            btnCloseIcon.IconColor = Color.Black;
            btnCloseIcon.IconSize = 20;
        }

        private void btnHideIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCloseIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
