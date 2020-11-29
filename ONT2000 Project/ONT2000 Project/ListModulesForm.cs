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
    public partial class ListModulesForm : Form
    {
        int getUserID;
        string userType;
        bool back;
        string name;

        public ListModulesForm(int value, string type, bool goBack)
        {
            InitializeComponent();
            getUserID = value;
            userType = type;
            back = goBack;
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        LecturerModule lecMod = new LecturerModule();
        User user = new User();

        private void ListModulesForm_Load(object sender, EventArgs e)
        {
            childFormPanel.Visible = false;
            user.UserID = getUserID;
            if (userType == "Lecturer")
            {
                dgvDisplayModules.DataSource = bll.GetLecturerModuleByUserID(user);
            }
            else if (userType == "Student")
            {
                if (back == true)
                {
                    childFormPanel.Visible = false;
                    dgvDisplayModules.Visible = true;
                }
                dgvDisplayModules.DataSource = bll.GetStudentModule(user);
                dgvDisplayModules.ForeColor = Color.Black;
            }
        }

        private void dgvDisplayModules_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDisplayModules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            name = dgvDisplayModules.SelectedRows[0].Cells["ModuleName"].Value.ToString();
            if (userType == "Student")
            {
                //this.Hide();
                StudentModuleAssessments sm = new StudentModuleAssessments(getUserID, name, userType);
                dgvDisplayModules.Visible = false;
                childFormPanel.Visible = true;
                sm.TopLevel = false;
                sm.Dock = DockStyle.Fill;
                childFormPanel.Controls.Add(sm);
                childFormPanel.Tag = sm;
                sm.BringToFront();
                sm.Show();
            }
        }
    }
}
