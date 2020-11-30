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
    public partial class AssessmentBetweenDates : Form
    {
        int userID;
        public AssessmentBetweenDates(int Value)
        {
            InitializeComponent();

            userID = Value;
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        User user = new User();
        private void AssessmentBetweenDates_Load(object sender, EventArgs e)
        {
            dgvDisplay.ForeColor = Color.Black;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            user.UserID = userID;
            string min = dtpMin.Value.ToString();
            string max = dtpMax.Value.ToString();

            DataTable dt = new DataTable();

            dt = bll.SelectAssessmentsBetweenDates(user, min, max);

            if (dt.Rows.Count > 0)
            {
                dgvDisplay.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No available assessments");
            }
        }
    }
}
