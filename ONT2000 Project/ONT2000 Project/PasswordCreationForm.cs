using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace ONT2000_Project
{
    public partial class PasswordCreationForm : Form
    {
        public PasswordCreationForm()
        {
            InitializeComponent();
        }

        private void PasswordCreationForm_Load(object sender, EventArgs e)
        {
            txtPassword.Visible = false;
            passwordIcon.Visible = false;
            passwordPanel.Visible = false;

            btnContinue.Visible = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "Create New Password" && txtPassword.Text != "")
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
                txtPassword.UseSystemPasswordChar = false;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Create New Password" || txtPassword.Text == "")
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

            if (txtEmail.Text == "Email Address" || txtEmail.Text == "")
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

        int id;

        private void txtEmail_Click(object sender, EventArgs e)
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

            if (txtPassword.Text == "Password" || txtPassword.Text == "")
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

        private void btnCheckEmail_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
            User user = new User();

            user.email = txtEmail.Text;

            DataTable dt = new DataTable();

            dt = bll.GetUserByEmail(user);


            if (dt.Rows.Count > 0)
            {

                string role = dt.Rows[0]["Role"].ToString();
                string email = dt.Rows[0]["Email"].ToString();

                if (dt.Rows[0]["Role"].ToString() == "Administrator" && dt.Rows[0]["Password"].ToString() != "")
                {
                    MessageBox.Show("Check Successfull");
                    SignIn sign = new SignIn(email, role);
                    sign.Show();
                    this.Hide();
                }
                else if (dt.Rows[0]["Password"].ToString() == "")
                {
                    txtPassword.Visible = true;
                    passwordIcon.Visible = true;
                    passwordPanel.Visible = true;

                    txtEmail.Enabled = false;
                    emailPanel.Enabled = false;
                    userIcon.Enabled = false;

                    btnCheckEmail.Visible = false;
                    btnContinue.Visible = true;

                    id= int.Parse(dt.Rows[0]["UserID"].ToString());
                }
                else if (dt.Rows[0]["Password"].ToString() != "")
                {
                    MessageBox.Show("Check Successfull");
                    SignIn sign = new SignIn(email,role);
                    sign.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("User not found. Contact the system Administrator");
                
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
            User user = new User();

            user.UserID = id;
            user.password = txtPassword.Text;

            int x = bll.UserSetPassword(user);

            if (x > 0)
            {
                MessageBox.Show("Password successful. Now re-verify your email");
                txtPassword.Visible = false;
                passwordIcon.Visible = false;
                passwordPanel.Visible = false;
                btnContinue.Visible = false;
                btnCheckEmail.Visible = true;
            }
            else
            {
                MessageBox.Show("Failed to create password");
            }
        }
    }
}
