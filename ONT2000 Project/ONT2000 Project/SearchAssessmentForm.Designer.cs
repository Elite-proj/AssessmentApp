namespace ONT2000_Project
{
    partial class SearchAssessmentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDisplayAssessment = new System.Windows.Forms.DataGridView();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteAssessment = new FontAwesome.Sharp.IconButton();
            this.btnUpdateAssessment = new FontAwesome.Sharp.IconButton();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.txtModule = new System.Windows.Forms.TextBox();
            this.txtAssessmentType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbAssessmentType = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.txtSearchAssessment = new System.Windows.Forms.TextBox();
            this.rdbFilter = new System.Windows.Forms.RadioButton();
            this.rdbNameSearch = new System.Windows.Forms.RadioButton();
            this.AssessNameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.moduleNameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.StatusError = new System.Windows.Forms.ErrorProvider(this.components);
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayAssessment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssessNameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleNameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusError)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisplayAssessment
            // 
            this.dgvDisplayAssessment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDisplayAssessment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisplayAssessment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisplayAssessment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDisplayAssessment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDisplayAssessment.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDisplayAssessment.Location = new System.Drawing.Point(12, 248);
            this.dgvDisplayAssessment.Name = "dgvDisplayAssessment";
            this.dgvDisplayAssessment.RowHeadersWidth = 62;
            this.dgvDisplayAssessment.RowTemplate.Height = 28;
            this.dgvDisplayAssessment.Size = new System.Drawing.Size(417, 340);
            this.dgvDisplayAssessment.TabIndex = 4;
            this.dgvDisplayAssessment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayAssessment_CellClick);
            // 
            // lblDueDate
            // 
            this.lblDueDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.ForeColor = System.Drawing.Color.White;
            this.lblDueDate.Location = new System.Drawing.Point(582, 357);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(142, 32);
            this.lblDueDate.TabIndex = 56;
            this.lblDueDate.Text = "Due Date:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(435, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 32);
            this.label5.TabIndex = 55;
            this.label5.Text = "New Date:";
            // 
            // btnDeleteAssessment
            // 
            this.btnDeleteAssessment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAssessment.BackColor = System.Drawing.Color.Red;
            this.btnDeleteAssessment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAssessment.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDeleteAssessment.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAssessment.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeleteAssessment.IconColor = System.Drawing.Color.White;
            this.btnDeleteAssessment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteAssessment.IconSize = 35;
            this.btnDeleteAssessment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAssessment.Location = new System.Drawing.Point(748, 537);
            this.btnDeleteAssessment.Name = "btnDeleteAssessment";
            this.btnDeleteAssessment.Rotation = 0D;
            this.btnDeleteAssessment.Size = new System.Drawing.Size(167, 51);
            this.btnDeleteAssessment.TabIndex = 52;
            this.btnDeleteAssessment.Text = "DELETE";
            this.btnDeleteAssessment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteAssessment.UseVisualStyleBackColor = false;
            this.btnDeleteAssessment.Click += new System.EventHandler(this.btnDeleteAssessment_Click_1);
            // 
            // btnUpdateAssessment
            // 
            this.btnUpdateAssessment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateAssessment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAssessment.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUpdateAssessment.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAssessment.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.btnUpdateAssessment.IconColor = System.Drawing.Color.White;
            this.btnUpdateAssessment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateAssessment.IconSize = 35;
            this.btnUpdateAssessment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateAssessment.Location = new System.Drawing.Point(517, 537);
            this.btnUpdateAssessment.Name = "btnUpdateAssessment";
            this.btnUpdateAssessment.Rotation = 0D;
            this.btnUpdateAssessment.Size = new System.Drawing.Size(177, 51);
            this.btnUpdateAssessment.TabIndex = 51;
            this.btnUpdateAssessment.Text = "UPDATE";
            this.btnUpdateAssessment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateAssessment.UseVisualStyleBackColor = true;
            this.btnUpdateAssessment.Click += new System.EventHandler(this.btnUpdateAssessment_Click_1);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtpDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDueDate.Location = new System.Drawing.Point(587, 411);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(409, 39);
            this.dtpDueDate.TabIndex = 50;
            // 
            // txtModule
            // 
            this.txtModule.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtModule.Enabled = false;
            this.txtModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModule.Location = new System.Drawing.Point(550, 297);
            this.txtModule.Name = "txtModule";
            this.txtModule.Size = new System.Drawing.Size(412, 39);
            this.txtModule.TabIndex = 49;
            // 
            // txtAssessmentType
            // 
            this.txtAssessmentType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtAssessmentType.Enabled = false;
            this.txtAssessmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssessmentType.Location = new System.Drawing.Point(650, 229);
            this.txtAssessmentType.Name = "txtAssessmentType";
            this.txtAssessmentType.Size = new System.Drawing.Size(312, 39);
            this.txtAssessmentType.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(434, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 32);
            this.label4.TabIndex = 47;
            this.label4.Text = "Due Date:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(435, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 32);
            this.label3.TabIndex = 46;
            this.label3.Text = "Module:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(435, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 29);
            this.label6.TabIndex = 45;
            this.label6.Text = "Assessment Name:";
            // 
            // cmbAssessmentType
            // 
            this.cmbAssessmentType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmbAssessmentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAssessmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAssessmentType.ForeColor = System.Drawing.Color.White;
            this.cmbAssessmentType.FormattingEnabled = true;
            this.cmbAssessmentType.Location = new System.Drawing.Point(203, 119);
            this.cmbAssessmentType.Name = "cmbAssessmentType";
            this.cmbAssessmentType.Size = new System.Drawing.Size(224, 45);
            this.cmbAssessmentType.TabIndex = 58;
            this.cmbAssessmentType.SelectedIndexChanged += new System.EventHandler(this.cmbAssessmentType_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.ForeColor = System.Drawing.Color.White;
            this.lblFilter.Location = new System.Drawing.Point(12, 119);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(185, 32);
            this.lblFilter.TabIndex = 57;
            this.lblFilter.Text = "Filter by type:";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.White;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 28;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(286, 101);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Rotation = 0D;
            this.btnSearch.Size = new System.Drawing.Size(163, 63);
            this.btnSearch.TabIndex = 60;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // txtSearchAssessment
            // 
            this.txtSearchAssessment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAssessment.Location = new System.Drawing.Point(39, 115);
            this.txtSearchAssessment.Name = "txtSearchAssessment";
            this.txtSearchAssessment.Size = new System.Drawing.Size(241, 48);
            this.txtSearchAssessment.TabIndex = 59;
            // 
            // rdbFilter
            // 
            this.rdbFilter.AutoSize = true;
            this.rdbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFilter.ForeColor = System.Drawing.Color.White;
            this.rdbFilter.Location = new System.Drawing.Point(375, 12);
            this.rdbFilter.Name = "rdbFilter";
            this.rdbFilter.Size = new System.Drawing.Size(175, 33);
            this.rdbFilter.TabIndex = 62;
            this.rdbFilter.Text = "Filter by type";
            this.rdbFilter.UseVisualStyleBackColor = true;
            this.rdbFilter.CheckedChanged += new System.EventHandler(this.rdbFilter_CheckedChanged);
            // 
            // rdbNameSearch
            // 
            this.rdbNameSearch.AutoSize = true;
            this.rdbNameSearch.Checked = true;
            this.rdbNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNameSearch.ForeColor = System.Drawing.Color.White;
            this.rdbNameSearch.Location = new System.Drawing.Point(12, 12);
            this.rdbNameSearch.Name = "rdbNameSearch";
            this.rdbNameSearch.Size = new System.Drawing.Size(352, 33);
            this.rdbNameSearch.TabIndex = 61;
            this.rdbNameSearch.TabStop = true;
            this.rdbNameSearch.Text = "Search Assessment by Name";
            this.rdbNameSearch.UseVisualStyleBackColor = true;
            this.rdbNameSearch.CheckedChanged += new System.EventHandler(this.rdbNameSearch_CheckedChanged);
            // 
            // AssessNameError
            // 
            this.AssessNameError.ContainerControl = this;
            // 
            // moduleNameError
            // 
            this.moduleNameError.ContainerControl = this;
            // 
            // StatusError
            // 
            this.StatusError.ContainerControl = this;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(13, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(443, 29);
            this.label9.TabIndex = 63;
            this.label9.Text = "Select record below to update or delete.";
            // 
            // SearchAssessmentForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1008, 600);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rdbFilter);
            this.Controls.Add(this.rdbNameSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchAssessment);
            this.Controls.Add(this.cmbAssessmentType);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDeleteAssessment);
            this.Controls.Add(this.btnUpdateAssessment);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.txtModule);
            this.Controls.Add(this.txtAssessmentType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvDisplayAssessment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchAssessmentForm";
            this.Text = "SearchAssessmentForm";
            this.Load += new System.EventHandler(this.SearchAssessmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayAssessment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssessNameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleNameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDisplayAssessment;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnDeleteAssessment;
        private FontAwesome.Sharp.IconButton btnUpdateAssessment;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.TextBox txtModule;
        private System.Windows.Forms.TextBox txtAssessmentType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbAssessmentType;
        private System.Windows.Forms.Label lblFilter;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.TextBox txtSearchAssessment;
        private System.Windows.Forms.RadioButton rdbFilter;
        private System.Windows.Forms.RadioButton rdbNameSearch;
        private System.Windows.Forms.ErrorProvider AssessNameError;
        private System.Windows.Forms.ErrorProvider moduleNameError;
        private System.Windows.Forms.ErrorProvider StatusError;
        private System.Windows.Forms.Label label9;
    }
}