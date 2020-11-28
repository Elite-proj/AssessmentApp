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
    public partial class SearchModules : Form
    {
        public SearchModules()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
            Module mod = new Module();
            mod.name = txtModuleNameSearch.Text;
            //mod.moduleID = int.Parse(txtModuleNameSearch.Text);
            DataTable dt = new DataTable();
            dt = bll.SearchModule(mod);

            if (dt.Rows.Count > 0)
            {
                dgvDisplay.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Module not found!");
            }
        }

        private void dgvDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
            Module mod = new Module();
            DataTable dt = new DataTable();

            try
            {
                mod.moduleID = int.Parse(dgvDisplay.SelectedRows[0].Cells["ModuleID"].Value.ToString());
                dt = bll.GetModuleByID(mod);
            }
            catch
            {
            }
            if (dgvDisplay.SelectedRows.Count > 0)
            {

            }

            lblCode.Text = dt.Rows[0]["ModuleID"].ToString();
            txtModuleName.Text = dt.Rows[0]["ModuleName"].ToString();
            txtDuration.Text = dt.Rows[0]["ModuleDuration"].ToString();
            cmbModuleType.DataSource = bll.InsertToComboBoxModuleType();
            cmbModuleType.ValueMember = "ModuleTypeID";
            cmbModuleType.DisplayMember = "ModuleTypeDescription";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
            Module mod = new Module();

            mod.name = txtModuleName.Text;
            mod.Duration = txtDuration.Text;
            mod.moduleTypeID = int.Parse(cmbModuleType.SelectedValue.ToString());
            mod.moduleID = int.Parse(dgvDisplay.SelectedRows[0].Cells["ModuleID"].Value.ToString());
            int x = bll.UpdateModule(mod);

            if (x > 0)
            {
                MessageBox.Show("Successfully updated module");
            }
            else
            {
                MessageBox.Show("Failed to update");
            }

            mod.name = txtModuleName.Text;
            //mod.moduleID = int.Parse(txtModuleNameSearch.Text);
            DataTable dt = new DataTable();
            dt = bll.SearchModule(mod);
            if (dt.Rows.Count > 0)
            {
                dgvDisplay.DataSource = dt;
            }
        }
    }
}
