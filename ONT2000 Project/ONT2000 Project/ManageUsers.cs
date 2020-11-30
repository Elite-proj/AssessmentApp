using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace ONT2000_Project
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        User user = new User();
        private void ManageUsers_Load(object sender, EventArgs e)
        {
            cmbTitle.Items.Add("Mr");
            cmbTitle.Items.Add("Mrs");
            cmbTitle.Items.Add("Miss");
            cmbTitle.Items.Add("Dr");
            cmbTitle.Items.Add("Prof");

            cmbRole.Items.Add("Administrator");
            cmbRole.Items.Add("Lecturer");
            cmbRole.Items.Add("Student");
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
            User user = new User();

            if (string.IsNullOrEmpty(txtName.Text))
            {
                txtNameError.SetError(txtName, "Please do not leave this field empty");
            }
            else if (string.IsNullOrEmpty(txtSurname.Text))
            {
                txtSurnameError.SetError(txtSurname, "Please do not leave this field empty");
            }
            else if (cmbTitle.SelectedItem==null)
            {
                titleError.SetError(cmbTitle, "Please Select title first");
            }
            else if (cmbRole.SelectedItem==null)
            {
                roleError.SetError(cmbRole, "Please select role first");
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                roleError.SetError(txtEmail, "Please do not leave this field empty");
            }
            else
            {

                user.name = txtName.Text;
                user.surname = txtSurname.Text;
                user.Role = cmbRole.SelectedItem.ToString();
                user.title = cmbTitle.SelectedItem.ToString();
                user.email = txtEmail.Text;
                user.userStatus = "Active";

                int x = bll.AdminRegisterUser(user);

                if (x > 0)
                {
                    MessageBox.Show(x + " user added!");
                }
                else
                {
                    MessageBox.Show("Failed to add user");
                }

                txtName.Clear();
                txtSurname.Clear();
                txtEmail.Clear();
                cmbRole.Text ="";
                cmbTitle.Text ="";
            }
        }
    }
}
