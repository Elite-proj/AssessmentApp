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
    public partial class SearchUser : Form
    {
        public SearchUser()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        User user = new User();

        private void SearchUser_Load(object sender, EventArgs e)
        {
            btnUpdateUser.Enabled = false;
            btnDeleteUser.Enabled = false;

            cmbFilterUser.Items.Add("Administrator");
            cmbFilterUser.Items.Add("Lecturer");
            cmbFilterUser.Items.Add("Student");

            cmbTitle.Items.Add("Mr");
            cmbTitle.Items.Add("Mrs");
            cmbTitle.Items.Add("Miss");
            cmbTitle.Items.Add("Dr");
            cmbTitle.Items.Add("Prof");

            cmbRole.Items.Add("Administrator");
            cmbRole.Items.Add("Lecturer");
            cmbRole.Items.Add("Student");

            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("In-Active");

            

            rdbNameSearch.Checked = true;

            if (rdbNameSearch.Checked == true)
            {
                lblRole.Visible = false;
                cmbFilterUser.Visible = false;
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            user.name = txtNameSearch.Text;
            user.surname = txtSearchSurname.Text;

            DataTable dt = new DataTable();

            dt = bll.SearchUserByName(user);

            if (dt.Rows.Count > 0)
            {
                dgvDisplayUser.DataSource = dt;
            }
            else
            {
                MessageBox.Show("User not found!");
            }

            btnUpdateUser.Enabled = false;
            btnDeleteUser.Enabled = false;
        }

        private void cmbFilterUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            user.Role = cmbFilterUser.SelectedItem.ToString();

            DataTable dt = new DataTable();

            dt = bll.ListAllLecturers(user);

            dgvDisplayUser.DataSource = dt;
        }

        

        private void btnUpdateUser_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                txtNameError.SetError(txtName, "Do not leave this field empty");
            }
            else if (string.IsNullOrEmpty(txtSurname.Text))
            {
                txtSurnameError.SetError(txtSurname, "Do not leave this field empty");
            }
            else if (cmbTitle.SelectedItem == null)
            {
                titleError.SetError(cmbTitle, "Please select title");
            }
            else if (cmbRole.SelectedItem == null)
            {
                roleError.SetError(cmbRole, "Please select role");
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                emailError.SetError(txtEmail, "Do not leave this field empty");
            }
            else
            {

                user.name = txtName.Text;
                user.surname = txtSurname.Text;
                user.Role = cmbRole.SelectedItem.ToString();
                user.title = cmbTitle.SelectedItem.ToString();
                user.email = txtEmail.Text;
                user.UserID = int.Parse(dgvDisplayUser.SelectedRows[0].Cells["UserID"].Value.ToString());
                user.userStatus = "Active";

                int x = bll.UpdateUser(user);

                if (x > 0)
                {
                    MessageBox.Show("Successfuly updated user");
                }
                else
                {
                    MessageBox.Show("Failed to update user");
                }

                if (rdbFilter.Checked == true)
                {
                    user.Role = cmbFilterUser.SelectedItem.ToString();

                    DataTable dt = new DataTable();

                    dt = bll.ListAllLecturers(user);

                    dgvDisplayUser.DataSource = dt;
                }
                else if (rdbNameSearch.Checked == true)
                {
                    user.name = txtNameSearch.Text;
                    user.surname = txtSearchSurname.Text;

                    DataTable dt = new DataTable();

                    dt = bll.SearchUserByName(user);


                    dgvDisplayUser.DataSource = dt;

                }

                btnUpdateUser.Enabled = false;
                btnDeleteUser.Enabled = false;
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            user.UserID = int.Parse(dgvDisplayUser.SelectedRows[0].Cells["UserID"].Value.ToString());

            int x = bll.DeleteUser(user);

            if (x > 0)
            {
                MessageBox.Show("Deleted User");
            }
            else
            {
                MessageBox.Show("Failed to delete user");
            }


            if (rdbFilter.Checked == true)
            {
                user.Role = cmbFilterUser.SelectedItem.ToString();

                DataTable dt = new DataTable();

                dt = bll.ListAllLecturers(user);

                dgvDisplayUser.DataSource = dt;
            }
            else if (rdbNameSearch.Checked == true)
            {
                user.name = txtNameSearch.Text;
                user.surname = txtSearchSurname.Text;

                DataTable dt = new DataTable();

                dt = bll.SearchUserByName(user);


                dgvDisplayUser.DataSource = dt;
               
            }
            btnUpdateUser.Enabled = false;
            btnDeleteUser.Enabled = false;
        }

        private void cmbFilterUser_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            user.Role = cmbFilterUser.SelectedItem.ToString();

            DataTable dt = new DataTable();

            dt = bll.ListAllLecturers(user);

            dgvDisplayUser.DataSource = dt;
        }

        private void rdbNameSearch_CheckedChanged(object sender, EventArgs e)
        {
            lblRole.Visible = false;
            cmbFilterUser.Visible = false;

            txtNameSearch.Visible = true;
            txtSearchSurname.Visible = true;
            btnSearch.Visible = true;

            lblName.Visible = true;
            lblSurname.Visible = true;
        }

        private void rdbFilter_CheckedChanged(object sender, EventArgs e)
        {
            txtNameSearch.Visible = false;
            txtSearchSurname.Visible = false;
            btnSearch.Visible = false;
            lblName.Visible = false;
            lblSurname.Visible = false;

            lblRole.Visible = true;
            cmbFilterUser.Visible = true;
        }

        private void dgvDisplayUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();

            try
            {
                user.UserID = int.Parse(dgvDisplayUser.SelectedRows[0].Cells["UserID"].Value.ToString());

                dt = bll.GetUserByID(user);
            }
            catch
            {
            }
            if (dgvDisplayUser.SelectedRows.Count > 0)
            {
                lblUserID.Text = dt.Rows[0]["UserID"].ToString();
                txtName.Text = dt.Rows[0]["Name"].ToString();
                txtSurname.Text = dt.Rows[0]["Surname"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                cmbRole.Text = dt.Rows[0]["Role"].ToString();
                cmbTitle.Text = dt.Rows[0]["Title"].ToString();
                cmbStatus.Text = dt.Rows[0]["UserStatus"].ToString();

                btnUpdateUser.Enabled = true;
                btnDeleteUser.Enabled = true;
            }
        }
    }
    
}
