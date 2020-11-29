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
    public partial class ListStudentAssessments : Form
    {
        int userID;
        public ListStudentAssessments(int Value)
        {
            InitializeComponent();

            userID = Value;
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        User user = new User();

        private void ListStudentAssessments_Load(object sender, EventArgs e)
        {
            user.UserID = userID;
            dgvDisplayAssessments.ForeColor = Color.Black;
            dgvDisplayAssessments.DataSource = bll.ListAllStudentAssessments(user);
        }
    }
}
