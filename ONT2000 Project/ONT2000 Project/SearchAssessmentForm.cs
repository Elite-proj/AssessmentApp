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
    public partial class SearchAssessmentForm : Form
    {
        int userID;
        public SearchAssessmentForm(int Value)
        {
            InitializeComponent();
            userID = Value;
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        User user = new User();
        private void btnUpdateAssessment_Click_1(object sender, EventArgs e)
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
            Assessment assess = new Assessment();

            if (string.IsNullOrEmpty(txtAssessmentType.Text))
            {
                AssessNameError.SetError(txtAssessmentType, "Do not leave this field empty");
            }
            else if (string.IsNullOrEmpty(txtModule.Text))
            {
                moduleNameError.SetError(txtModule, "Do not leave this field empty");
            }
            else if (cmbStatus.SelectedItem == null)
            {
                StatusError.SetError(cmbStatus, "Select status before you continue");
            }
            else
            {
                assess.decription = txtAssessmentType.Text;
                assess.DueDate = dtpDueDate.Value.ToString();
                assess.assessmentID = int.Parse(dgvDisplayAssessment.SelectedRows[0].Cells["AssessmentID"].Value.ToString());
                assess.AssessmentStatus = cmbStatus.SelectedItem.ToString();


                int x = bll.UpdateAssessment(assess);

                if (x > 0)
                {
                    MessageBox.Show("Successfully updated assessment");
                }
                else
                {
                    MessageBox.Show(x + " Failed to update assessment ");
                }

                if (rdbFilter.Checked == true)
                {
                    try
                    {
                        if (cmbAssessmentType.DataSource != null)
                        {
                            int typeID;

                            Int32.TryParse(cmbAssessmentType.SelectedValue.ToString(), out typeID);

                            assess.AssessmentTypeID = typeID;
                        }
                    }
                    catch (System.NullReferenceException)
                    {
                    }
                    dgvDisplayAssessment.DataSource = bll.GetAssessmentByType(assess, userID);

                }
                else if (rdbNameSearch.Checked == true)
                {
                    // Assessment assess = new Assessment();
                    assess.decription = txtSearchAssessment.Text;
                    DataTable dt = new DataTable();

                    dt = bll.SearchAssessment(assess, userID);

                   
                    dgvDisplayAssessment.DataSource = dt;
                    
                }

                btnUpdateAssessment.Enabled = false;
                btnDeleteAssessment.Enabled = false;
            }
        }

        private void btnDeleteAssessment_Click_1(object sender, EventArgs e)
        {
            Assessment assess = new Assessment();
            assess.assessmentID = int.Parse(dgvDisplayAssessment.SelectedRows[0].Cells["AssessmentID"].Value.ToString());

            int x = bll.DeleteAssessment(assess);

            if (x > 0)
            {
                MessageBox.Show("Successfully deleted assessment");
            }
            else
            {
                MessageBox.Show("Failed to delete assessment");
            }


            txtAssessmentType.Text = null;
            txtModule.Text = null;
            lblDueDate.Text = null;


            if (rdbFilter.Checked == true)
            {
                try
                {
                    if (cmbAssessmentType.DataSource != null)
                    {
                        int typeID;

                        Int32.TryParse(cmbAssessmentType.SelectedValue.ToString(), out typeID);

                        assess.AssessmentTypeID = typeID;
                    }
                }
                catch (System.NullReferenceException)
                {
                }
                dgvDisplayAssessment.DataSource = bll.GetAssessmentByType(assess, userID);

            }
            else if (rdbNameSearch.Checked == true)
            {
                // Assessment assess = new Assessment();
                assess.decription = txtSearchAssessment.Text;
                DataTable dt = new DataTable();

                dt = bll.SearchAssessment(assess, userID);

                
                dgvDisplayAssessment.DataSource = dt;
                
            }
            btnUpdateAssessment.Enabled = false;
            btnDeleteAssessment.Enabled = false;

        }

        private void SearchAssessmentForm_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("In-Active");

            rdbNameSearch.Checked = true;

            if (rdbNameSearch.Checked == true)
            {
                cmbAssessmentType.Visible = false;
                lblFilter.Visible = false;
                txtSearchAssessment.Visible = true;
                btnSearch.Visible = true;

                cmbAssessmentType.DataSource = null;
            }
            else
            {
                user.UserID = userID;

                cmbAssessmentType.DataSource = bll.GetAssessmentTypeByUserID(user);
                cmbAssessmentType.ValueMember = "AssessmentTypeID";
                cmbAssessmentType.DisplayMember = "AssessmentTypeDescription";
            }

            btnDeleteAssessment.Enabled = false;
            btnUpdateAssessment.Enabled = false;
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            Assessment assess = new Assessment();
            assess.decription = txtSearchAssessment.Text;
            DataTable dt = new DataTable();

            dt = bll.SearchAssessment(assess, userID);

            if (dt.Rows.Count > 0)
            {
                dgvDisplayAssessment.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Assessment not found");
            }

            btnDeleteAssessment.Enabled = false;
            btnUpdateAssessment.Enabled = false;
        }

        private void cmbAssessmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Assessment assess = new Assessment();

            try
            {
                if (cmbAssessmentType.DataSource != null)
                {
                    int typeID;

                    Int32.TryParse(cmbAssessmentType.SelectedValue.ToString(), out typeID);

                    assess.AssessmentTypeID = typeID;
                }
            }
            catch (System.NullReferenceException)
            {
            }

            dgvDisplayAssessment.DataSource = bll.GetAssessmentByType(assess, userID);

            btnUpdateAssessment.Enabled = false;
            btnDeleteAssessment.Enabled = false;
        }

        private void dgvDisplayAssessment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
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
                txtAssessmentType.Text = dt.Rows[0]["AssessmentDescription"].ToString();
                txtModule.Text = dt.Rows[0]["ModuleName"].ToString();
                lblDueDate.Text = dt.Rows[0]["DueDate"].ToString();
                txtAssessmentType.Enabled = true;


                btnDeleteAssessment.Enabled = true;
                btnUpdateAssessment.Enabled = true;
            }
        }

        private void rdbNameSearch_CheckedChanged(object sender, EventArgs e)
        {
            cmbAssessmentType.Visible = false;
            lblFilter.Visible = false;
            txtSearchAssessment.Visible = true;
            btnSearch.Visible = true;

            cmbAssessmentType.DataSource = null;
        }

        private void rdbFilter_CheckedChanged(object sender, EventArgs e)
        {
            cmbAssessmentType.Visible = true;
            lblFilter.Visible = true;
            txtSearchAssessment.Visible = false;
            btnSearch.Visible = false;

            user.UserID = userID;

            cmbAssessmentType.DataSource = bll.GetAssessmentTypeByUserID(user);
            cmbAssessmentType.ValueMember = "AssessmentTypeID";
            cmbAssessmentType.DisplayMember = "AssessmentTypeDescription";
        }
    }
}
