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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchAssessment = new System.Windows.Forms.TextBox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.cmbAssessmentType = new System.Windows.Forms.ComboBox();
            this.dgvDisplayAssessment = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAssessmentType = new System.Windows.Forms.TextBox();
            this.txtModule = new System.Windows.Forms.TextBox();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteAssessment = new FontAwesome.Sharp.IconButton();
            this.btnUpdateAssessment = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayAssessment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(465, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter by type:";
            // 
            // txtSearchAssessment
            // 
            this.txtSearchAssessment.Location = new System.Drawing.Point(19, 68);
            this.txtSearchAssessment.Name = "txtSearchAssessment";
            this.txtSearchAssessment.Size = new System.Drawing.Size(241, 26);
            this.txtSearchAssessment.TabIndex = 1;
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
            this.btnSearch.Location = new System.Drawing.Point(266, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Rotation = 0D;
            this.btnSearch.Size = new System.Drawing.Size(132, 44);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // cmbAssessmentType
            // 
            this.cmbAssessmentType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAssessmentType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmbAssessmentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAssessmentType.ForeColor = System.Drawing.Color.White;
            this.cmbAssessmentType.FormattingEnabled = true;
            this.cmbAssessmentType.Location = new System.Drawing.Point(600, 66);
            this.cmbAssessmentType.Name = "cmbAssessmentType";
            this.cmbAssessmentType.Size = new System.Drawing.Size(224, 28);
            this.cmbAssessmentType.TabIndex = 3;
            // 
            // dgvDisplayAssessment
            // 
            this.dgvDisplayAssessment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvDisplayAssessment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayAssessment.Location = new System.Drawing.Point(12, 248);
            this.dgvDisplayAssessment.Name = "dgvDisplayAssessment";
            this.dgvDisplayAssessment.RowHeadersWidth = 62;
            this.dgvDisplayAssessment.RowTemplate.Height = 28;
            this.dgvDisplayAssessment.Size = new System.Drawing.Size(417, 340);
            this.dgvDisplayAssessment.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(466, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Assessment Type:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(466, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Module:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(466, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Due Date:";
            // 
            // txtAssessmentType
            // 
            this.txtAssessmentType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAssessmentType.Enabled = false;
            this.txtAssessmentType.Location = new System.Drawing.Point(630, 243);
            this.txtAssessmentType.Name = "txtAssessmentType";
            this.txtAssessmentType.Size = new System.Drawing.Size(194, 26);
            this.txtAssessmentType.TabIndex = 8;
            // 
            // txtModule
            // 
            this.txtModule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModule.Enabled = false;
            this.txtModule.Location = new System.Drawing.Point(545, 306);
            this.txtModule.Name = "txtModule";
            this.txtModule.Size = new System.Drawing.Size(172, 26);
            this.txtModule.TabIndex = 9;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDueDate.Location = new System.Drawing.Point(577, 371);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(227, 26);
            this.dtpDueDate.TabIndex = 10;
            // 
            // btnDeleteAssessment
            // 
            this.btnDeleteAssessment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteAssessment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAssessment.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDeleteAssessment.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAssessment.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeleteAssessment.IconColor = System.Drawing.Color.White;
            this.btnDeleteAssessment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteAssessment.IconSize = 35;
            this.btnDeleteAssessment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAssessment.Location = new System.Drawing.Point(678, 466);
            this.btnDeleteAssessment.Name = "btnDeleteAssessment";
            this.btnDeleteAssessment.Rotation = 0D;
            this.btnDeleteAssessment.Size = new System.Drawing.Size(167, 51);
            this.btnDeleteAssessment.TabIndex = 37;
            this.btnDeleteAssessment.Text = "DELETE";
            this.btnDeleteAssessment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteAssessment.UseVisualStyleBackColor = true;
            this.btnDeleteAssessment.Click += new System.EventHandler(this.btnDeleteAssessment_Click);
            // 
            // btnUpdateAssessment
            // 
            this.btnUpdateAssessment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateAssessment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAssessment.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUpdateAssessment.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAssessment.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.btnUpdateAssessment.IconColor = System.Drawing.Color.White;
            this.btnUpdateAssessment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateAssessment.IconSize = 35;
            this.btnUpdateAssessment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateAssessment.Location = new System.Drawing.Point(447, 466);
            this.btnUpdateAssessment.Name = "btnUpdateAssessment";
            this.btnUpdateAssessment.Rotation = 0D;
            this.btnUpdateAssessment.Size = new System.Drawing.Size(177, 51);
            this.btnUpdateAssessment.TabIndex = 36;
            this.btnUpdateAssessment.Text = "UPDATE";
            this.btnUpdateAssessment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateAssessment.UseVisualStyleBackColor = true;
            this.btnUpdateAssessment.Click += new System.EventHandler(this.btnUpdateAssessment_Click);
            // 
            // SearchAssessmentForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(869, 600);
            this.Controls.Add(this.btnDeleteAssessment);
            this.Controls.Add(this.btnUpdateAssessment);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.txtModule);
            this.Controls.Add(this.txtAssessmentType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDisplayAssessment);
            this.Controls.Add(this.cmbAssessmentType);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchAssessment);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchAssessmentForm";
            this.Text = "SearchAssessmentForm";
            this.Load += new System.EventHandler(this.SearchAssessmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayAssessment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchAssessment;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.ComboBox cmbAssessmentType;
        private System.Windows.Forms.DataGridView dgvDisplayAssessment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAssessmentType;
        private System.Windows.Forms.TextBox txtModule;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private FontAwesome.Sharp.IconButton btnDeleteAssessment;
        private FontAwesome.Sharp.IconButton btnUpdateAssessment;
    }
}