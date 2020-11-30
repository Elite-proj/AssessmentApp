namespace ONT2000_Project
{
    partial class SearchModules
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
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.btnDeleteModule = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.txtModuleName = new System.Windows.Forms.TextBox();
            this.cmbModuleType = new System.Windows.Forms.ComboBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.txtModuleNameSearch = new System.Windows.Forms.TextBox();
            this.txtModuleError = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtDurationError = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbTypeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.searchError = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDuration = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModuleError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDurationError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTypeError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchError)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(12, 188);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.RowHeadersWidth = 62;
            this.dgvDisplay.RowTemplate.Height = 28;
            this.dgvDisplay.Size = new System.Drawing.Size(470, 356);
            this.dgvDisplay.TabIndex = 30;
            this.dgvDisplay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplay_CellClick);
            // 
            // btnDeleteModule
            // 
            this.btnDeleteModule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteModule.BackColor = System.Drawing.Color.Red;
            this.btnDeleteModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteModule.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDeleteModule.ForeColor = System.Drawing.Color.White;
            this.btnDeleteModule.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeleteModule.IconColor = System.Drawing.Color.White;
            this.btnDeleteModule.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteModule.IconSize = 35;
            this.btnDeleteModule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteModule.Location = new System.Drawing.Point(755, 480);
            this.btnDeleteModule.Name = "btnDeleteModule";
            this.btnDeleteModule.Rotation = 0D;
            this.btnDeleteModule.Size = new System.Drawing.Size(170, 64);
            this.btnDeleteModule.TabIndex = 40;
            this.btnDeleteModule.Text = "DELETE";
            this.btnDeleteModule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteModule.UseVisualStyleBackColor = false;
            this.btnDeleteModule.Click += new System.EventHandler(this.btnDeleteModule_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.btnUpdate.IconColor = System.Drawing.Color.White;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.IconSize = 35;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(523, 480);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Rotation = 0D;
            this.btnUpdate.Size = new System.Drawing.Size(167, 64);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // txtModuleName
            // 
            this.txtModuleName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtModuleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModuleName.Location = new System.Drawing.Point(693, 229);
            this.txtModuleName.Name = "txtModuleName";
            this.txtModuleName.Size = new System.Drawing.Size(258, 48);
            this.txtModuleName.TabIndex = 37;
            // 
            // cmbModuleType
            // 
            this.cmbModuleType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbModuleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModuleType.FormattingEnabled = true;
            this.cmbModuleType.Location = new System.Drawing.Point(693, 297);
            this.cmbModuleType.Name = "cmbModuleType";
            this.cmbModuleType.Size = new System.Drawing.Size(258, 37);
            this.cmbModuleType.TabIndex = 36;
            this.cmbModuleType.SelectedIndexChanged += new System.EventHandler(this.cmbModuleType_SelectedIndexChanged);
            // 
            // lblCode
            // 
            this.lblCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.ForeColor = System.Drawing.Color.White;
            this.lblCode.Location = new System.Drawing.Point(707, 188);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(127, 29);
            this.lblCode.TabIndex = 35;
            this.lblCode.Text = "Code here";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(526, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 29);
            this.label5.TabIndex = 34;
            this.label5.Text = "Module Type:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(526, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 29);
            this.label4.TabIndex = 33;
            this.label4.Text = "Duration:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(526, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 29);
            this.label3.TabIndex = 32;
            this.label3.Text = "Module Name:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(526, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "Module Code:";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.White;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 35;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(291, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Rotation = 0D;
            this.btnSearch.Size = new System.Drawing.Size(155, 44);
            this.btnSearch.TabIndex = 42;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // txtModuleNameSearch
            // 
            this.txtModuleNameSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModuleNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModuleNameSearch.Location = new System.Drawing.Point(12, 49);
            this.txtModuleNameSearch.Name = "txtModuleNameSearch";
            this.txtModuleNameSearch.Size = new System.Drawing.Size(273, 41);
            this.txtModuleNameSearch.TabIndex = 41;
            // 
            // txtModuleError
            // 
            this.txtModuleError.ContainerControl = this;
            // 
            // txtDurationError
            // 
            this.txtDurationError.ContainerControl = this;
            // 
            // cmbTypeError
            // 
            this.cmbTypeError.ContainerControl = this;
            // 
            // searchError
            // 
            this.searchError.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 29);
            this.label1.TabIndex = 43;
            this.label1.Text = "Select record below to update or delete.";
            // 
            // cmbDuration
            // 
            this.cmbDuration.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDuration.FormattingEnabled = true;
            this.cmbDuration.Location = new System.Drawing.Point(634, 351);
            this.cmbDuration.Name = "cmbDuration";
            this.cmbDuration.Size = new System.Drawing.Size(317, 37);
            this.cmbDuration.TabIndex = 44;
            // 
            // SearchModules
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(991, 578);
            this.Controls.Add(this.cmbDuration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtModuleNameSearch);
            this.Controls.Add(this.btnDeleteModule);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtModuleName);
            this.Controls.Add(this.cmbModuleType);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchModules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SearchModules";
            this.Load += new System.EventHandler(this.SearchModules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModuleError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDurationError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTypeError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDisplay;
        private FontAwesome.Sharp.IconButton btnDeleteModule;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private System.Windows.Forms.TextBox txtModuleName;
        private System.Windows.Forms.ComboBox cmbModuleType;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.TextBox txtModuleNameSearch;
        private System.Windows.Forms.ErrorProvider txtModuleError;
        private System.Windows.Forms.ErrorProvider txtDurationError;
        private System.Windows.Forms.ErrorProvider cmbTypeError;
        private System.Windows.Forms.ErrorProvider searchError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDuration;
    }
}