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
            lecMod.lecturerModuleID = int.Parse(dataGridView1.SelectedRows[0].Cells["LecturerModuleID"].Value.ToString());
            lecMod.userID = int.Parse(cmbLecturer.SelectedValue.ToString());
            lecMod.moduleID = int.Parse(cmbModule.SelectedValue.ToString());
            lecMod.date = dtpDate.Value.ToString();
            lecMod.status = cmbStatus.SelectedItem.ToString();

            int x = bll.UpdateLecturerModule(lecMod);

            if (x > 0)
            {
                MessageBox.Show("Successfuly Updated");
            }
            else
            {
                MessageBox.Show("Failed to update");
            }
        }

        private void btnAssignLecturer_Click(object sender, EventArgs e)
        {
            int userId;
            Int32.TryParse(cmbLecturer.SelectedValue.ToString(), out userId);

            int moduleID;

            Int32.TryParse(cmbModule.SelectedValue.ToString(), out moduleID);

            lecMod.userID = userId;
            lecMod.moduleID = moduleID;
            lecMod.date = dtpDate.Value.ToString();
            lecMod.status = cmbStatus.SelectedItem.ToString();

            int x = bll.AssignLecturerModule(lecMod);

            if (x > 0)
            {
                MessageBox.Show("Successfuly Assigne lecturer");
            }
            else
            {
                MessageBox.Show("Failed to Assign Lecturer");
            }
        }

        private void btnDeleteLecturer_Click(object sender, EventArgs e)
        {

        }

        private void btnListLecturer_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bll.ListAssignedLecturers();
        }

        private void ManageLecturerModule_Load(object sender, EventArgs e)
        {
            user.Role = "Lecturer";
            cmbModule.DataSource = bll.ListAllModules();
            cmbModule.ValueMember = "ModuleID";
            cmbModule.DisplayMember = "ModuleName";



            DataTable dt = new DataTable();

            dt = bll.ListAllLecturers(user);
            dt.Columns.Add("FullName", typeof(string), "UserID+' '+Name+' '+Surname");
            cmbLecturer.DataSource = dt;
            cmbLecturer.ValueMember = "UserID";
            cmbLecturer.DisplayMember = "FullName";

            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("In-Active");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                cmbLecturer.DataSource = dt;
                cmbLecturer.DisplayMember = dt.Rows[0]["FullName"].ToString();

                cmbModule.DataSource = dt;
                cmbModule.DisplayMember = dt.Rows[0]["ModuleName"].ToString();

                //cmbStatus.DataSource = dt;
                cmbStatus.Items.Add(dt.Rows[0]["ModLecturerStatus"].ToString());
            }
        }
    }
}
