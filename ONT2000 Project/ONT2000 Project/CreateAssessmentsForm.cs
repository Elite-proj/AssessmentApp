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
    public partial class CreateAssessmentsForm : Form
    {
        public CreateAssessmentsForm()
        {
            InitializeComponent();
        }

        private void btnAddAssessment_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
            Assessment assess = new Assessment();

            assess.decription = txtDescription.Text;
            assess.AssessmentTypeID = int.Parse(cmbAssessmentType.SelectedValue.ToString());
            assess.DueDate = dtpDueDate.Value.ToString();
            assess.StudentLecturerModuleID = int.Parse(cmbModule.SelectedValue.ToString());
            assess.AssessmentStatus = "Active";

            int x = bll.InsertAssessment(assess);

            if (x > 0)
            {
                MessageBox.Show("Assessment Added");
            }
            else
            {
                MessageBox.Show("Failed to add");
            }

        }

        private void btnUpdateAssessment_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
            Assessment assess = new Assessment();

            assess.decription = txtDescription.Text;
            assess.AssessmentTypeID = int.Parse(cmbAssessmentType.SelectedValue.ToString());
            assess.DueDate = dtpDueDate.Value.ToString();
            assess.StudentLecturerModuleID = int.Parse(cmbModule.SelectedValue.ToString());
            assess.AssessmentStatus = cmbStatus.SelectedItem.ToString();

            int x = bll.UpdateAssessment(assess);

            if (x > 0)
            {
                MessageBox.Show("Successfuly updated assessment");
            }
            else
            {
                MessageBox.Show("Failed to update assessment");
            }
        }

        private void btnDeleteAssessment_Click(object sender, EventArgs e)
        {

        }

        private void btnListAssessment_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
            User user = new User();
            user.UserID = userID;

            dgvDisplayAssessment.DataSource = bll.ListAssessment(user);
        }

        private void CreateAssessmentsForm_Load(object sender, EventArgs e)
        {
            User user = new User();
            BusinessLogicLayer bll = new BusinessLogicLayer();
            DataTable dt = new DataTable();
            user.UserID = userID;

            dt = bll.GetLecturerModuleByUserID(user);

            cmbModule.DataSource = dt;
            cmbModule.ValueMember = "ModuleID";
            cmbModule.DisplayMember = "ModuleName";

            cmbAssessmentType.DataSource = bll.ListAssessmentType();
            cmbAssessmentType.ValueMember = "AssessmentTypeID";
            cmbAssessmentType.DisplayMember = "AssessmentTypeDescription";

            cmbStatus.Visible = false;
        }

        private void dgvDisplayAssessment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            BusinessLogicLayer bll = new BusinessLogicLayer();
            Assessment assess = new Assessment();

            try
            {
                assess.assessmentID = int.Parse(dgvDisplayAssessment.SelectedRows[0].Cells["AssessmentID"].Value.ToString());

                dt = bll.GetAssessmentByID(assess);
            }
            catch
            {
            }

            if (dgvDisplayAssessment.SelectedRows.Count > 0)
            {
                txtDescription.Text = dt.Rows[0]["AssessmentDescription"].ToString();
                cmbAssessmentType.SelectedItem = dt.Rows[0]["AssessmentTypeDescription"].ToString();
                cmbModule.SelectedItem = dt.Rows[0]["ModuleName"].ToString();
                cmbAssessmentType.Text = dt.Rows[0]["AssessmentTypeDescription"].ToString();
                cmbModule.Text = dt.Rows[0]["ModuleName"].ToString();

                User user = new User();
                user.UserID = userID;

                dt = bll.GetLecturerModuleByUserID(user);

                cmbModule.DataSource = dt;
                cmbModule.ValueMember = "ModuleID";
                cmbModule.DisplayMember = "ModuleName";

                cmbAssessmentType.DataSource = bll.ListAssessmentType();
                cmbAssessmentType.ValueMember = "AssessmentTypeID";
                cmbAssessmentType.DisplayMember = "AssessmentTypeDescription";
                cmbStatus.Visible = true;
                cmbStatus.Items.Add("Active");
                cmbStatus.Items.Add("In-Active");

            }
        }
}
