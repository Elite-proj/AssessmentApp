using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONT2000_Project
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageStudentModules manageStudent = new ManageStudentModules();
            manageStudent.Show();
        }

        private void btnLecturer_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageLecturerModule manageLecturer = new ManageLecturerModule();
            manageLecturer.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Show();
            
        }
    }
}
