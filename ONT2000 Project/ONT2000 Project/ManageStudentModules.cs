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
    public partial class ManageStudentModules : Form
    {
        public ManageStudentModules()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            StudentModule studMod = new StudentModule();

            studMod.lecturerModuleID = int.Parse(cmbModule.SelectedValue.ToString());
            studMod.userID = int.Parse(cmbStudent.SelectedValue.ToString());
            studMod.date = dtpDate.Value.ToString();
            studMod.status = cmbStatus.SelectedItem.ToString();

            int x = bll.EnrolStudentToModule(studMod);

            if (x > 0)
            {
                MessageBox.Show("Successfully Enrolled Student");
            }
            else
            {
                MessageBox.Show("Failed to enroll student");
            }
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            btnUpdateStudent.Enabled = false;
            btnDeleteStudent.Enabled = false;
            cmbModule.Enabled = true;
            cmbStudent.Enabled = true;
            dtpDate.Enabled = true;

            btnAddStudent.Enabled = true;

            StudentModule studMod = new StudentModule();

            studMod.status = cmbStatus.SelectedItem.ToString();
            studMod.studentModuleID = int.Parse(dgvDisplayStudent.SelectedRows[0].Cells["StudentModuleID"].Value.ToString());

            int x = bll.UpdateStudentModule(studMod);

            if (x > 0)
            {
                MessageBox.Show("Successfully updated");
            }
            else
            {
                MessageBox.Show("Failed to update");
            }

            DataTable dt = new DataTable();

            dt = bll.ListStudentModule();

            dgvDisplayStudent.DataSource = dt;


        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            StudentModule studMod = new StudentModule();
            studMod.studentModuleID = int.Parse(dgvDisplayStudent.SelectedRows[0].Cells["StudentModuleID"].Value.ToString());

            int x = bll.DeleteStudentModule(studMod);

            if (x > 0)
            {
                MessageBox.Show("Successfully Deleted");
            }
            else
            {
                MessageBox.Show("Failed to Delete");
            }

            DataTable dt = new DataTable();

            dt = bll.ListStudentModule();

            dgvDisplayStudent.DataSource = dt;

            btnAddStudent.Enabled = true;
            cmbModule.Enabled = true;
            cmbStudent.Enabled = true;
            dtpDate.Enabled = true;

            btnUpdateStudent.Enabled = false;
            btnDeleteStudent.Enabled = false;
        }

        private void btnListStudents_Click(object sender, EventArgs e)
        {
            cmbModule.Enabled = true;
            cmbStudent.Enabled = true;
            dtpDate.Enabled = true;

            btnAddStudent.Enabled = true;

            btnUpdateStudent.Enabled = false;
            btnDeleteStudent.Enabled = false;

            DataTable dt = new DataTable();

            dt = bll.ListStudentModule();

            dgvDisplayStudent.DataSource = dt;
        }

        private void ManageStudentModules_Load(object sender, EventArgs e)
        {
            cmbModule.Enabled = true;
            cmbStudent.Enabled = true;
            dtpDate.Enabled = true;

            btnAddStudent.Enabled = true;

            btnUpdateStudent.Enabled = false;
            btnDeleteStudent.Enabled = false;

            User user = new User();
            user.Role = "Student";
            DataTable dt = new DataTable();
            dt = bll.ListAllStudents(user);

            dt.Columns.Add("FullName", typeof(string), "UserID+' '+Name+' '+Surname");
            cmbStudent.DataSource = dt;
            cmbStudent.ValueMember = "UserID";
            cmbStudent.DisplayMember = "FullName";

            cmbModule.DataSource = bll.ListAllModulesForStudents();
            cmbModule.ValueMember = "LecturerModuleID";
            cmbModule.DisplayMember = "ModuleName";

            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("In-Active");
        }

        private void dgvDisplayStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();

            if (dgvDisplayStudent.SelectedRows.Count > 0)
            {

                cmbModule.Text = dgvDisplayStudent.SelectedRows[0].Cells["ModuleName"].Value.ToString();
                cmbStudent.Text = dgvDisplayStudent.SelectedRows[0].Cells["UserID"].Value.ToString() + " " + dgvDisplayStudent.SelectedRows[0].Cells["Name"].Value.ToString() + " " + dgvDisplayStudent.SelectedRows[0].Cells["Surname"].Value.ToString();
                cmbStatus.Text = dgvDisplayStudent.SelectedRows[0].Cells["StudModStatus"].Value.ToString();

                cmbModule.Enabled = false;
                cmbStudent.Enabled = false;
                dtpDate.Enabled = false;

                btnAddStudent.Enabled = false;

                btnUpdateStudent.Enabled = true;
                btnDeleteStudent.Enabled = true;
            }
        }
    }
}
