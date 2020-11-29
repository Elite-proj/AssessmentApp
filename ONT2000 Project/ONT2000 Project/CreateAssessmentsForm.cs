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
    public partial class CreateAssessmentsForm : Form
    {
        int userID;
        public CreateAssessmentsForm(int value)
        {
            InitializeComponent();
            userID = value;
        }

        private void btnAddAssessment_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
            Assessment assess = new Assessment();

            if (cmbModule.SelectedItem == null)
            {
                moduleError.SetError(cmbModule, "Please select module");
            }
            else if (string.IsNullOrEmpty(txtDescription.Text))
            {
                descriptionError.SetError(txtDescription, "Do not leave this field empty");
            }
            else if (cmbAssessmentType.SelectedItem == null)
            {
                typeError.SetError(cmbAssessmentType, "Select assessment type first");
            }
            else
            {

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
                btnDeleteAssessment.Enabled = false;
            }
        }

       

        private void btnDeleteAssessment_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
            Assessment assess = new Assessment();
            assess.assessmentID = int.Parse(dgvDisplayAssessment.SelectedRows[0].Cells["AssessmentID"].Value.ToString());
            User user = new User();
            user.UserID = userID;

            int x = bll.DeleteAssessment(assess);

            if (x > 0)
            {
                MessageBox.Show("Successfully deleted assessment");
            }
            else
            {
                MessageBox.Show("Failed to delete assessment");
            }

            dgvDisplayAssessment.DataSource = bll.ListAssessment(user);

            txtDescription.Enabled = true;
            cmbModule.Enabled = true;
            cmbAssessmentType.Enabled = true;
            lblDueDate.Visible = true;
            dtpDueDate.Visible = true;
            btnDeleteAssessment.Enabled = false;
            btnAddAssessment.Enabled = true;
        }

        private void btnListAssessment_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
            User user = new User();
            user.UserID = userID;

            dgvDisplayAssessment.DataSource = bll.ListAssessment(user);

            btnDeleteAssessment.Enabled = false;
            btnAddAssessment.Enabled = true;
            txtDescription.Enabled = false;
            cmbAssessmentType.Enabled = false;
            cmbModule.Enabled = false;
            dtpDueDate.Enabled = false;

            txtDescription.Enabled = true;
            cmbAssessmentType.Enabled = true;
            cmbModule.Enabled = true;
            dtpDueDate.Enabled = true;
        }

        private void CreateAssessmentsForm_Load(object sender, EventArgs e)
        {
            btnDeleteAssessment.Enabled = false;
            btnAddAssessment.Enabled = true;

           
            btnAddAssessment.Enabled = true;
            txtDescription.Enabled = true;
            cmbAssessmentType.Enabled = true;
            cmbModule.Enabled = true;
            dtpDueDate.Enabled = true;

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

        }

       

        private void dgvDisplayAssessment_CellClick(object sender, DataGridViewCellEventArgs e)
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
                txtDescription.Enabled = false;
                cmbAssessmentType.Text = dt.Rows[0]["AssessmentTypeDescription"].ToString();
                cmbAssessmentType.Enabled = false;
                cmbModule.Text = dt.Rows[0]["ModuleName"].ToString();
                cmbModule.Enabled = false;

                dtpDueDate.Visible = false;
                lblDueDate.Visible = false;

                btnDeleteAssessment.Enabled = true;
                btnAddAssessment.Enabled = false;

            }
        }
    }
}
