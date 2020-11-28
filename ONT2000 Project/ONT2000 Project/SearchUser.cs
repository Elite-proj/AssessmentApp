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
            cmbFilterUser.Items.Add("Administrator");
            cmbFilterUser.Items.Add("Lecturer");
            cmbFilterUser.Items.Add("Student");

            rdbNameSearch.Checked = true;

            if (rdbNameSearch.Checked == true)
            {
                lblRole.Visible = false;
                cmbFilterUser.Visible = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            user.name = txtNameSearch.Text;
            user.surname = txtSurname.Text;

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
        }

        private void cmbFilterUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            user.Role = cmbFilterUser.SelectedItem.ToString();

            DataTable dt = new DataTable();

            dt = bll.ListAllLecturers(user);

            dgvDisplayUser.DataSource = dt;
        }

        private void dgvDisplayUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

                cmbStatus.Items.Add("Active");
                cmbStatus.Items.Add("In-Active");

                cmbTitle.Items.Add("Mr");
                cmbTitle.Items.Add("Mrs");
                cmbTitle.Items.Add("Miss");
                cmbTitle.Items.Add("Dr");
                cmbTitle.Items.Add("Prof");

                cmbRole.Items.Add("Administrator");
                cmbRole.Items.Add("Lecturer");
                cmbRole.Items.Add("Student");
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
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
            DataTable dt = new DataTable();


            user.UserID = int.Parse(dgvDisplayUser.SelectedRows[0].Cells["UserID"].Value.ToString());

            dt = bll.GetUserByID(user);
        }
    }
    }
}
