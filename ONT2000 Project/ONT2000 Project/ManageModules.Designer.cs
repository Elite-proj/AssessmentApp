﻿namespace ONT2000_Project
{
    partial class ManageModules
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModuleName = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.namePanel = new System.Windows.Forms.Panel();
            this.durationPanel = new System.Windows.Forms.Panel();
            this.TypePanel = new System.Windows.Forms.Panel();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvDisplayModules = new System.Windows.Forms.DataGridView();
            this.btnListModules = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnAddModule = new FontAwesome.Sharp.IconButton();
            this.ModuleNameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.durationError = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayModules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModuleNameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbError)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Module Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(97, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Duration:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(97, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Module Type:";
            // 
            // txtModuleName
            // 
            this.txtModuleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModuleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtModuleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModuleName.ForeColor = System.Drawing.Color.White;
            this.txtModuleName.Location = new System.Drawing.Point(275, 26);
            this.txtModuleName.Name = "txtModuleName";
            this.txtModuleName.Size = new System.Drawing.Size(643, 35);
            this.txtModuleName.TabIndex = 4;
            // 
            // txtDuration
            // 
            this.txtDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.ForeColor = System.Drawing.Color.White;
            this.txtDuration.Location = new System.Drawing.Point(239, 96);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(685, 35);
            this.txtDuration.TabIndex = 5;
            // 
            // namePanel
            // 
            this.namePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.namePanel.BackColor = System.Drawing.Color.White;
            this.namePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namePanel.Location = new System.Drawing.Point(275, 67);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(643, 1);
            this.namePanel.TabIndex = 6;
            // 
            // durationPanel
            // 
            this.durationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.durationPanel.BackColor = System.Drawing.Color.White;
            this.durationPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationPanel.Location = new System.Drawing.Point(238, 136);
            this.durationPanel.Name = "durationPanel";
            this.durationPanel.Size = new System.Drawing.Size(685, 1);
            this.durationPanel.TabIndex = 7;
            // 
            // TypePanel
            // 
            this.TypePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TypePanel.BackColor = System.Drawing.Color.White;
            this.TypePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypePanel.Location = new System.Drawing.Point(261, 193);
            this.TypePanel.Name = "TypePanel";
            this.TypePanel.Size = new System.Drawing.Size(664, 1);
            this.TypePanel.TabIndex = 8;
            // 
            // cmbType
            // 
            this.cmbType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.ForeColor = System.Drawing.Color.White;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(275, 153);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(649, 37);
            this.cmbType.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 333);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(990, 1);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 252);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(990, 1);
            this.panel3.TabIndex = 18;
            // 
            // dgvDisplayModules
            // 
            this.dgvDisplayModules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDisplayModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayModules.Location = new System.Drawing.Point(0, 349);
            this.dgvDisplayModules.Name = "dgvDisplayModules";
            this.dgvDisplayModules.RowHeadersWidth = 62;
            this.dgvDisplayModules.RowTemplate.Height = 28;
            this.dgvDisplayModules.Size = new System.Drawing.Size(990, 217);
            this.dgvDisplayModules.TabIndex = 19;
            this.dgvDisplayModules.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayModules_CellClick);
            // 
            // btnListModules
            // 
            this.btnListModules.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnListModules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListModules.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnListModules.ForeColor = System.Drawing.Color.White;
            this.btnListModules.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.btnListModules.IconColor = System.Drawing.Color.White;
            this.btnListModules.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListModules.IconSize = 35;
            this.btnListModules.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListModules.Location = new System.Drawing.Point(703, 270);
            this.btnListModules.Name = "btnListModules";
            this.btnListModules.Rotation = 0D;
            this.btnListModules.Size = new System.Drawing.Size(172, 47);
            this.btnListModules.TabIndex = 15;
            this.btnListModules.Text = "LIST";
            this.btnListModules.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListModules.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListModules.UseVisualStyleBackColor = true;
            this.btnListModules.Click += new System.EventHandler(this.btnListModules_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.White;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 35;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(515, 270);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Rotation = 0D;
            this.btnDelete.Size = new System.Drawing.Size(172, 47);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.btnUpdate.IconColor = System.Drawing.Color.White;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.IconSize = 35;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(326, 270);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Rotation = 0D;
            this.btnUpdate.Size = new System.Drawing.Size(172, 47);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddModule
            // 
            this.btnAddModule.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddModule.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAddModule.ForeColor = System.Drawing.Color.White;
            this.btnAddModule.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddModule.IconColor = System.Drawing.Color.White;
            this.btnAddModule.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddModule.IconSize = 35;
            this.btnAddModule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddModule.Location = new System.Drawing.Point(129, 270);
            this.btnAddModule.Name = "btnAddModule";
            this.btnAddModule.Rotation = 0D;
            this.btnAddModule.Size = new System.Drawing.Size(172, 47);
            this.btnAddModule.TabIndex = 12;
            this.btnAddModule.Text = "ADD";
            this.btnAddModule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddModule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddModule.UseVisualStyleBackColor = true;
            this.btnAddModule.Click += new System.EventHandler(this.btnAddModule_Click);
            // 
            // ModuleNameError
            // 
            this.ModuleNameError.ContainerControl = this;
            // 
            // durationError
            // 
            this.durationError.ContainerControl = this;
            // 
            // cmbError
            // 
            this.cmbError.ContainerControl = this;
            // 
            // ManageModules
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(991, 578);
            this.Controls.Add(this.dgvDisplayModules);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnListModules);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddModule);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.TypePanel);
            this.Controls.Add(this.durationPanel);
            this.Controls.Add(this.namePanel);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtModuleName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageModules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ManageModules";
            this.Load += new System.EventHandler(this.ManageModules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayModules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModuleNameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModuleName;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.Panel durationPanel;
        private System.Windows.Forms.Panel TypePanel;
        private System.Windows.Forms.ComboBox cmbType;
        private FontAwesome.Sharp.IconButton btnAddModule;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnListModules;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvDisplayModules;
        private System.Windows.Forms.ErrorProvider ModuleNameError;
        private System.Windows.Forms.ErrorProvider durationError;
        private System.Windows.Forms.ErrorProvider cmbError;
    }
}