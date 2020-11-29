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
    public partial class ModuleStudentsTotal : Form
    {
        public ModuleStudentsTotal()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void ModuleStudentsTotal_Load(object sender, EventArgs e)
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
          
            dgvListStudents.DataSource = bll.GetTotalStudentsEnrolledINModule();
        }
    }
}
