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
    public partial class ListStudentsForm : Form
    {
        int getUserID;

        public ListStudentsForm(int value)
        {
            InitializeComponent();
            getUserID = value;
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        User user = new User();

        private void ListStudentsForm_Load(object sender, EventArgs e)
        {
            user.UserID = getUserID;
            DataTable dt = new DataTable();

            dt = bll.GetLecturerModuleByUserID(user);
            cmbModule.DataSource = dt;
            cmbModule.ValueMember = "ModuleID";
            cmbModule.DisplayMember = "ModuleName";

            lblStudentID.Text = "";
            lblStudentName.Text = "";
            lblStudentAssessment.Text = "";
            lblStudentSurname.Text = "";
            lblDisplayStatus.Text = "";
        }

        private void cmbModule_SelectedIndexChanged(object sender, EventArgs e)
        {
            int moduleID;

            Int32.TryParse(cmbModule.SelectedValue.ToString(), out moduleID);
            Module mod = new Module();

            DataTable dt = new DataTable();

            mod.moduleID = moduleID;

            dt = bll.GetAssessmentByModuleID(mod);

            cmbAssessment.DataSource = dt;
            cmbAssessment.ValueMember = "AssessmentID";
            cmbAssessment.DisplayMember = "AssessmentDescription";

            lblStudentID.Text = "";
            lblStudentName.Text = "";
            lblStudentAssessment.Text = "";
            lblStudentSurname.Text = "";
            lblDisplayStatus.Text = "";
        }

        private void cmbAssessment_SelectedIndexChanged(object sender, EventArgs e)
        {
            Assessment assess = new Assessment();

            int assessID;

            Int32.TryParse(cmbAssessment.SelectedValue.ToString(), out assessID);

            assess.assessmentID = assessID;


            dgvDisplayStudents.DataSource = bll.ListStudentAssessment(assess);

            lblStudentID.Text = "";
            lblStudentName.Text = "";
            lblStudentAssessment.Text = "";
            lblStudentSurname.Text = "";
            lblDisplayStatus.Text = "";
        }

        private void dgvDisplayStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
            }
            catch
            {
            }

            if (dgvDisplayStudents.SelectedRows.Count > 0)
            {

                lblStudentName.Text = dgvDisplayStudents.SelectedRows[0].Cells["Name"].Value.ToString();
                lblStudentSurname.Text = dgvDisplayStudents.SelectedRows[0].Cells["Surname"].Value.ToString();
                lblStudentID.Text = dgvDisplayStudents.SelectedRows[0].Cells["UserID"].Value.ToString();
                lblStudentAssessment.Text = dgvDisplayStudents.SelectedRows[0].Cells["AssessmentDescription"].Value.ToString();
                lblDisplayStatus.Text = dgvDisplayStudents.SelectedRows[0].Cells["AssessmentStatus"].Value.ToString();

            }
        }
    }
}
