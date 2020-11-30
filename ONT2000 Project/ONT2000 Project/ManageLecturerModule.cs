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
    public partial class ManageLecturerModule : Form
    {
        public ManageLecturerModule()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        User user = new User();
        LecturerModule lecMod = new LecturerModule();
        private void btnUpdateLecturer_Click(object sender, EventArgs e)
        {

            if (cmbModule.SelectedItem == null)
            {
                cmbModuleError.SetError(cmbModule, "Please select module before you continue");
            }
            else if (cmbLecturer.SelectedItem == null)
            {
                cmbLecturerError.SetError(cmbLecturer, "Please select lecturer before you continue");
            }
            else
            {

                lecMod.lecturerModuleID = int.Parse(dataGridView1.SelectedRows[0].Cells["LecturerModuleID"].Value.ToString());
                lecMod.userID = int.Parse(cmbLecturer.SelectedValue.ToString());

                lecMod.date = dtpDate.Value.ToString();
                lecMod.status = "Active";

                int x = bll.UpdateLecturerModule(lecMod);

                if (x > 0)
                {
                    MessageBox.Show("Successfully Updated");
                }
                else
                {
                    MessageBox.Show("Failed to update");
                }

                dataGridView1.DataSource = bll.ListAssignedLecturers();
                btnAssignLecturer.Enabled = true;
                cmbModule.Enabled = true;
                btnDeleteLecturer.Enabled = false;
                btnUpdateLecturer.Enabled = false;
            }
        }

        private void btnAssignLecturer_Click(object sender, EventArgs e)
        {
            if (cmbModule.SelectedItem == null)
            {
                cmbModuleError.SetError(cmbModule, "Please select module before you continue");
            }
            else if (cmbLecturer.SelectedItem == null)
            {
                cmbLecturerError.SetError(cmbLecturer, "Please select lecturer before you continue");
            
            }
            else
            {

                int userId;
                Int32.TryParse(cmbLecturer.SelectedValue.ToString(), out userId);

                int moduleID;

                Int32.TryParse(cmbModule.SelectedValue.ToString(), out moduleID);

                lecMod.userID = userId;
                lecMod.moduleID = moduleID;
                lecMod.date = dtpDate.Value.ToString();
                lecMod.status = "Active";

                int x = bll.AssignLecturerModule(lecMod);

                if (x > 0)
                {
                    MessageBox.Show("Successfully Assigned lecturer");
                }
                else
                {
                    MessageBox.Show("Failed to Assign Lecturer");
                }
            }
        }

        private void btnDeleteLecturer_Click(object sender, EventArgs e)
        {
            lecMod.lecturerModuleID = int.Parse(dataGridView1.SelectedRows[0].Cells["LecturerModuleID"].Value.ToString());

            int x = bll.DeleteLecturerModule(lecMod);

            if (x > 0)
            {
                MessageBox.Show("Successfully deleted");
            }
            else
            {
                MessageBox.Show("Failed to delete");
            }

            dataGridView1.DataSource = bll.ListAssignedLecturers();
            btnDeleteLecturer.Enabled = false;
            btnUpdateLecturer.Enabled = false;
        }

        private void btnListLecturer_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bll.ListAssignedLecturers();
            btnAssignLecturer.Enabled = true;
            cmbModule.Enabled = true;
            btnDeleteLecturer.Enabled = false;
            btnUpdateLecturer.Enabled = false;
        }

        private void ManageLecturerModule_Load(object sender, EventArgs e)
        {
            btnDeleteLecturer.Enabled = false;
            btnUpdateLecturer.Enabled = false;

            user.Role = "Lecturer";
            cmbModule.DataSource = bll.ListAllModules();
            cmbModule.ValueMember = "ModuleID";
            cmbModule.DisplayMember = "ModuleName";

            btnAssignLecturer.Enabled = true;

            DataTable dt = new DataTable();

            dt = bll.ListAllLecturers(user);
            dt.Columns.Add("FullName", typeof(string), "UserID+' '+Name+' '+Surname");
            cmbLecturer.DataSource = dt;
            cmbLecturer.ValueMember = "UserID";
            cmbLecturer.DisplayMember = "FullName";

           
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();

            try
            {
                lecMod.lecturerModuleID = int.Parse(dataGridView1.SelectedRows[0].Cells["LecturerModuleID"].Value.ToString());
            }
            catch
            {
            }

            if (dataGridView1.SelectedRows.Count > 0)
            {


                dt = bll.GetAssignedLectureByID(lecMod);
                dt.Columns.Add("FullName", typeof(string), "UserID+'  '+Name+' '+Surname");

                cmbLecturer.Text = dt.Rows[0]["FullName"].ToString();



                cmbModule.Text = dt.Rows[0]["ModuleName"].ToString();
                cmbModule.Enabled = false;

                

                btnAssignLecturer.Enabled = false;
                btnUpdateLecturer.Enabled = true;
                btnDeleteLecturer.Enabled = true;

            }
        }
    }
}
