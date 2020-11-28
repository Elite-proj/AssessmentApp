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
        private void btnUpdateAssessment_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteAssessment_Click(object sender, EventArgs e)
        {

        }

        private void SearchAssessmentForm_Load(object sender, EventArgs e)
        {
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
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
        }
    }
}
