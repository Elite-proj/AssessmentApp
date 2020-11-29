﻿using System;
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
    public partial class SearchModules : Form
    {
        public SearchModules()
        {
            InitializeComponent();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
            Module mod = new Module();

            if (string.IsNullOrEmpty(txtModuleNameSearch.Text))
            {
                searchError.SetError(txtModuleNameSearch, "Please enter what you want to search");
            }
            else
            {


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

                btnDeleteModule.Enabled = false;

                btnUpdate.Enabled = false;
            }
        }

        

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
            Module mod = new Module();

            if (string.IsNullOrEmpty(txtModuleName.Text))
            {
                txtModuleError.SetError(txtModuleName, "Please do not leave this field empty");
            }
            else if (string.IsNullOrEmpty(txtDuration.Text))
            {
                txtDurationError.SetError(txtDuration, "Please do not leave this field empty");
            }
            else if (cmbModuleType.SelectedItem == null)
            {
                cmbTypeError.SetError(cmbModuleType, "Please Select type");
            }
            else
            {

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
                
                dgvDisplay.DataSource = dt;

                btnUpdate.Enabled = false;
                btnDeleteModule.Enabled = false;
            }
        }

        private void SearchModules_Load(object sender, EventArgs e)
        {
            btnDeleteModule.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnDeleteModule_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();
            Module mod = new Module();

            mod.moduleID = int.Parse(dgvDisplay.SelectedRows[0].Cells["ModuleID"].Value.ToString());

            int x = bll.DeleteModule(mod);

            if (x > 0)
            {
                MessageBox.Show("Module deleted");
            }
            else
            {
                MessageBox.Show("Failed to delete");
            }

            mod.name = txtModuleNameSearch.Text;

            DataTable dt = new DataTable();
            dt = bll.SearchModule(mod);


            dgvDisplay.DataSource = dt;
        }

        private void dgvDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
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

            btnUpdate.Enabled = true;
            btnDeleteModule.Enabled = true;
        }
    }
}
