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
    public partial class SearchStudentModule : Form
    {
        int userID;
        public SearchStudentModule(int value)
        {
            InitializeComponent();
            userID = value;
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        Module mod = new Module();
        User user = new User();
        private void SearchStudentModule_Load(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            dtpDate.Visible = false;
            lblDisplayAssessmentType.Text = "";
            lblDisplayDueDate.Text = "";

            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            mod.name = txtSearch.Text;
            user.UserID = userID;

            DataTable dt = new DataTable();

            dt = bll.SearchStudentModule(mod, user);

            if (dt.Rows.Count > 0)
            {
                dgvDisplayAssessment.DataSource = dt;
                dgvDisplayAssessment.ForeColor = Color.Black;
            }
            else
            {
                MessageBox.Show("Module not found");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StudentAssessment student = new StudentAssessment();

            if (checkMissed.Checked != true && checkComplete.Checked != true)
            {
                errorCheck.SetError(btnSave, "Check a box");
            }
            else if(checkComplete.Checked==true || checkMissed.Checked==true)
            {
                student.userID = userID;
                student.assessmentID = int.Parse(dgvDisplayAssessment.SelectedRows[0].Cells["AssessmentID"].Value.ToString());
                student.date = dtpDate.Value.ToString();


                if (checkComplete.Checked == true)
                {
                    student.status = "Complete";
                }
                else if (checkMissed.Checked == true)
                {
                    student.status = "Missed";
                }




                int x = bll.SaveStudentAssessment(student);

                if (x > 0)
                {
                    MessageBox.Show("Successfully Saved assessmentt");
                }
                else
                {
                    MessageBox.Show("Failed to save assessment");
                }

                checkMissed.CheckState = CheckState.Unchecked;
                checkComplete.CheckState = CheckState.Unchecked;
                lblDisplayAssessmentType.Text = "";
                lblDisplayDueDate.Text = "";
            }
        }

       

        private void checkComplete_Click(object sender, EventArgs e)
        {
            checkMissed.CheckState = CheckState.Unchecked;
           
        }

        private void checkMissed_Click(object sender, EventArgs e)
        {
            checkComplete.CheckState = CheckState.Unchecked;
            
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


               
                 btnSave.Visible = true;

                

            }
        }
    }
}
