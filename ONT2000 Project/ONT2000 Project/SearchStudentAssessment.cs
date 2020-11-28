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
using DATAACCESSLAYER;

namespace ONT2000_Project
{
    public partial class SearchStudentAssessment : Form
    {
        int getUserID;
        public SearchStudentAssessment(int value)
        {
            InitializeComponent();
            getUserID = value;
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        StudentAssessment student = new StudentAssessment();

        private void SearchStudentAssessment_Load(object sender, EventArgs e)
        {
            cmbFilter.Items.Add("Complete");
            cmbFilter.Items.Add("Missed");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            student.userID = getUserID;
            student.status = cmbFilter.SelectedItem.ToString();

            dgvDisplayAssessment.DataSource = bll.GetStudentAssessmentByStatus(student);
            dgvDisplayAssessment.ForeColor = Color.Black;
        }
    }
}
