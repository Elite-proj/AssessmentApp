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
    public partial class StudentModuleAssessments : Form
    {
        int getID;
        string des;
        string type;
        public StudentModuleAssessments(int value, string description, string userType)
        {
            InitializeComponent();
            getID = value;
            des = description;
            type = userType;
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        Module mod = new Module();
        User user = new User();

        private void StudentModuleAssessments_Load(object sender, EventArgs e)
        {
            mod.name = des;
            user.UserID = getID;

            DataTable dt = new DataTable();

            dt = bll.SearchStudentModule(mod, user);
            lblModule.Text = des;

            dgvDisplayAssessment.DataSource = dt;
            
        }

        private void dgvDisplayAssessment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Assessment assess = new Assessment();
            DataTable dt = new DataTable();
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
                lblDisplayAssessmentType.Text = dt.Rows[0]["AssessmentDescription"].ToString();
                lblDisplayDueDate.Text = dt.Rows[0]["DueDate"].ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            bool back = true;
            ListModulesForm list = new ListModulesForm(getID, type, back);
            this.Close();
        }

        private void dgvDisplayAssessment_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Assessment assess = new Assessment();
            DataTable dt = new DataTable();
            try
            {
                assess.assessmentID = int.Parse(dgvDisplayAssessment.SelectedRows[0].Cells["AssessmentID"].Value.ToString());


                dt = bll.GetAssessmentByID(assess);
            }
            catch
            {
            }

            try
            {

                if (dgvDisplayAssessment.SelectedRows.Count > 0)
                {
                    lblDisplayAssessmentType.Text = dt.Rows[0]["AssessmentDescription"].ToString();
                    lblDisplayDueDate.Text = dt.Rows[0]["DueDate"].ToString();
                }
            }
            catch (IndexOutOfRangeException)
            { 
            }
        }
    }
}
