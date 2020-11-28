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
                MessageBox.Show("Successfuly Enrolled Student");
            }
            else
            {
                MessageBox.Show("Failed to enroll student");
            }
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {

        }

        private void btnListStudents_Click(object sender, EventArgs e)
        {
            StudentModule stMod = new StudentModule();
        }

        private void ManageStudentModules_Load(object sender, EventArgs e)
        {
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
    }
}
