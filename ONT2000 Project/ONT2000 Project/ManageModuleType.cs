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
    public partial class ManageModuleType : Form
    {
        public ManageModuleType()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnListModules_Click(object sender, EventArgs e)
        {
            dgvDisplay.DataSource = bll.ListAssessmentType();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnAddModule.Enabled = true;
        }

        private void btnAddModule_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDesc.Text))
            {
                typeError.SetError(txtDesc, "Do not leave this field empty");
            }
            else
            {
                int x = bll.InsertAssessmentType(txtDesc.Text);

                if (x > 0)
                {
                    MessageBox.Show("Successfully Added Assessment Type");
                }
                else
                {
                    MessageBox.Show("Failed to Insert Assessment Type");
                }
            }
        }

        private void ManageModuleType_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnAddModule.Enabled = true;

            dgvDisplay.ForeColor = Color.Black;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDesc.Text))
            {
                typeError.SetError(txtDesc, "Do not leave this field empty");
            }
            else
            {

                int x = bll.UpdateAssessmentType(txtDesc.Text,int.Parse(dgvDisplay.SelectedRows[0].Cells["AssessmentTypeID"].Value.ToString()));


                if (x > 0)
                {
                    MessageBox.Show("Successfully updated");
                }
                else
                {
                    MessageBox.Show("Failed to update");
                }

                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnAddModule.Enabled = true;
                dgvDisplay.DataSource = bll.ListAssessmentType();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            int x = bll.DeleteAssessmentType(int.Parse(dgvDisplay.SelectedRows[0].Cells["AssessmentTypeID"].Value.ToString()));

            if (x > 0)
            {
                MessageBox.Show("Successfully Deleted");
            }
            else
            {
                MessageBox.Show("Failed to delete");
            }

            dgvDisplay.DataSource = bll.ListAssessmentType();

            btnAddModule.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void dgvDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDisplay.SelectedRows.Count > 0)
            {
                txtDesc.Text = dgvDisplay.SelectedRows[0].Cells["AssessmentTypeDescription"].Value.ToString();


                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnAddModule.Enabled = false;
            }
        }
    }
}
