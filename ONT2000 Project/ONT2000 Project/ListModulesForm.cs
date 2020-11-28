using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATAACCESSLAYER;
using BLL;

namespace ONT2000_Project
{
    public partial class ListModulesForm : Form
    {
        int getUserID;
        string userType;
        public ListModulesForm(int value, string type)
        {
            InitializeComponent();
            getUserID = value;
            userType = type;
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        LecturerModule lecMod = new LecturerModule();
        User user = new User();

        private void ListModulesForm_Load(object sender, EventArgs e)
        {
            user.UserID = getUserID;
            if (userType == "Lecturer")
            {
                dgvDisplayModules.DataSource = bll.GetLecturerModuleByUserID(user);
            }
            else if (userType == "Student")
            {
                dgvDisplayModules.DataSource = bll.GetStudentModule(user);
                dgvDisplayModules.ForeColor = Color.Black;
            }
        }
    }
}
