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
    public partial class WelcomeForm : Form
    {
        string emailAdd;
        string Role;
        public WelcomeForm(string email,string type)
        {
            InitializeComponent();

            emailAdd = email;
            Role = type;
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGoToRegister_Click(object sender, EventArgs e)
        {
            Registerform reg = new Registerform(emailAdd,Role);
            reg.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn(emailAdd,Role);

            signIn.Show();
            this.Hide();
        }
    }
}
