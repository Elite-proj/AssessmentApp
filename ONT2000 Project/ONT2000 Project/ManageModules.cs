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
    public partial class ManageModules : Form
    {
        public ManageModules()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        Module mod = new Module();

        private void ManageModules_Load(object sender, EventArgs e)
        {
            cmbType.DataSource = bll.InsertToComboBoxModuleType();
            cmbType.ValueMember = "ModuleTypeID";
            cmbType.DisplayMember = "ModuleTypeDescription";

            btnAddModule.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

            
        }

        private void btnAddModule_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtModuleName.Text))
            {
                ModuleNameError.SetError(txtModuleName, "Please do not leave this field empty");
            }
            else if (cmbDuration.SelectedItem==null)
            {
                durationError.SetError(cmbDuration, "Please select duration");
            }
            else if (cmbType.SelectedItem == null)
            {
                cmbError.SetError(cmbType, "Please select type first");
            }
            else
            {

                mod.name = txtModuleName.Text;
                mod.Duration = cmbDuration.SelectedItem.ToString();
                mod.moduleTypeID = int.Parse(cmbType.SelectedValue.ToString());

                int x = bll.InsertModule(mod);

                if (x > 0)
                {
                    MessageBox.Show(x + " Module added");
                }
                else
                {
                    MessageBox.Show("Failed to add module");
                }
                txtModuleName.Clear();
                cmbDuration.Text = "";
               
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtModuleName.Text))
            {
                ModuleNameError.SetError(txtModuleName, "Please do not leave this field empty");
            }
            else if (cmbDuration.SelectedItem==null)
            {
                durationError.SetError(cmbDuration, "Please select duration");
            }
            else if (cmbType.SelectedItem == null)
            {
                cmbError.SetError(cmbType, "Please select type first");
            }
            else
            {
                mod.name = txtModuleName.Text;
                mod.Duration = cmbDuration.SelectedItem.ToString();
                mod.moduleTypeID = int.Parse(cmbType.SelectedValue.ToString());
                mod.moduleID = int.Parse(dgvDisplayModules.SelectedRows[0].Cells["ModuleID"].Value.ToString());
                int x = bll.UpdateModule(mod);

                if (x > 0)
                {
                    MessageBox.Show("Successfully updated module");
                }
                else
                {
                    MessageBox.Show("Failed to update");
                }
                dgvDisplayModules.DataSource = bll.ListAllModules();

                btnAddModule.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                txtModuleName.Clear();
                cmbDuration.Text = "";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            mod.moduleID = int.Parse(dgvDisplayModules.SelectedRows[0].Cells["ModuleID"].Value.ToString());

            int x = bll.DeleteModule(mod);

            if (x > 0)
            {
                MessageBox.Show("Successfully Deleted Module");
            }
            else
            {
                MessageBox.Show("Failed to delete module");
            }

            DataTable dt = new DataTable();

            dt = bll.ListAllModules();

            dgvDisplayModules.DataSource = dt;
            btnAddModule.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtModuleName.Clear();
            cmbDuration.Text = "";
        }

        private void btnListModules_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt = bll.ListAllModules();

            dgvDisplayModules.DataSource = dt;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnAddModule.Enabled = true;
            txtModuleName.Clear();
            cmbDuration.Text = "";
        }

        private void dgvDisplayModules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                mod.moduleID = int.Parse(dgvDisplayModules.SelectedRows[0].Cells["ModuleID"].Value.ToString());


            }
            catch
            {
            }
            // problem with  Update needs fix
            // problem with  Update needs fix
            // problem with  Update needs fix
            // problem with  Update needs fix
            // problem with  Update needs fix
            // problem with  Update needs fix
            // problem with  Update needs fix
            if (dgvDisplayModules.SelectedRows.Count > 0)
            {
                dt = bll.GetModuleByID(mod);

                txtModuleName.Text = dt.Rows[0]["ModuleName"].ToString();
                cmbDuration.Text = dt.Rows[0]["ModuleDuration"].ToString();
                //cmbType.DataSource = dt;

                //cmbType.ValueMember = dt.Rows[0]["ModuleTypeID"].ToString();
                cmbType.Text = dt.Rows[0]["ModuleTypeDescription"].ToString();

                btnAddModule.Enabled = false;

                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDuration.Items.Clear();

            if (cmbType.SelectedIndex == 0)
            {
                cmbDuration.Items.Add("7 Months");
                cmbDuration.Items.Add("8 Months");
                cmbDuration.Items.Add("9 Months");
                cmbDuration.Items.Add("10 Months");
                cmbDuration.Items.Add("11 Months");
                cmbDuration.Items.Add("12 Months");
            }
            else if (cmbType.SelectedIndex == 1)
            {
                cmbDuration.Items.Add("1 Month");
                cmbDuration.Items.Add("2 Months");
                cmbDuration.Items.Add("3 Months");
                cmbDuration.Items.Add("4 Months");
                cmbDuration.Items.Add("5 Months");
                cmbDuration.Items.Add("6 Months");
            }
        }
    }
}
