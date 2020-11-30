namespace ONT2000_Project
{
    partial class SearchStudentModule
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvDisplayAssessment = new System.Windows.Forms.DataGridView();
            this.checkComplete = new System.Windows.Forms.CheckBox();
            this.checkMissed = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDisplayAssessmentType = new System.Windows.Forms.Label();
            this.lblDisplayDueDate = new System.Windows.Forms.Label();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.errorCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayAssessment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(12, 34);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(290, 44);
            this.txtSearch.TabIndex = 0;
            // 
            // dgvDisplayAssessment
            // 
            this.dgvDisplayAssessment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDisplayAssessment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisplayAssessment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayAssessment.Location = new System.Drawing.Point(12, 198);
            this.dgvDisplayAssessment.Name = "dgvDisplayAssessment";
            this.dgvDisplayAssessment.RowHeadersWidth = 62;
            this.dgvDisplayAssessment.RowTemplate.Height = 28;
            this.dgvDisplayAssessment.Size = new System.Drawing.Size(454, 406);
            this.dgvDisplayAssessment.TabIndex = 4;
            this.dgvDisplayAssessment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayAssessment_CellClick);
            // 
            // checkComplete
            // 
            this.checkComplete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkComplete.AutoSize = true;
            this.checkComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkComplete.Location = new System.Drawing.Point(495, 438);
            this.checkComplete.Name = "checkComplete";
            this.checkComplete.Size = new System.Drawing.Size(179, 41);
            this.checkComplete.TabIndex = 5;
            this.checkComplete.Text = "Complete";
            this.checkComplete.UseVisualStyleBackColor = true;
            this.checkComplete.Click += new System.EventHandler(this.checkComplete_Click);
            // 
            // checkMissed
            // 
            this.checkMissed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkMissed.AutoSize = true;
            this.checkMissed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMissed.Location = new System.Drawing.Point(707, 438);
            this.checkMissed.Name = "checkMissed";
            this.checkMissed.Size = new System.Drawing.Size(143, 41);
            this.checkMissed.TabIndex = 6;
            this.checkMissed.Text = "Missed";
            this.checkMissed.UseVisualStyleBackColor = true;
            this.checkMissed.Click += new System.EventHandler(this.checkMissed_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(488, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Assessment Type:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(488, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Due Date:";
            // 
            // lblDisplayAssessmentType
            // 
            this.lblDisplayAssessmentType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDisplayAssessmentType.AutoSize = true;
            this.lblDisplayAssessmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayAssessmentType.Location = new System.Drawing.Point(729, 198);
            this.lblDisplayAssessmentType.Name = "lblDisplayAssessmentType";
            this.lblDisplayAssessmentType.Size = new System.Drawing.Size(159, 32);
            this.lblDisplayAssessmentType.TabIndex = 12;
            this.lblDisplayAssessmentType.Text = "Diplay here";
            // 
            // lblDisplayDueDate
            // 
            this.lblDisplayDueDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDisplayDueDate.AutoSize = true;
            this.lblDisplayDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayDueDate.Location = new System.Drawing.Point(626, 262);
            this.lblDisplayDueDate.Name = "lblDisplayDueDate";
            this.lblDisplayDueDate.Size = new System.Drawing.Size(169, 32);
            this.lblDisplayDueDate.TabIndex = 13;
            this.lblDisplayDueDate.Text = "display here";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnSave.IconColor = System.Drawing.Color.Green;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 35;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(599, 558);
            this.btnSave.Name = "btnSave";
            this.btnSave.Rotation = 0D;
            this.btnSave.Size = new System.Drawing.Size(183, 46);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnSearch.Location = new System.Drawing.Point(309, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Rotation = 0D;
            this.btnSearch.Size = new System.Drawing.Size(131, 44);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtpDate.Location = new System.Drawing.Point(493, 391);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 26);
            this.dtpDate.TabIndex = 16;
            // 
            // errorCheck
            // 
            this.errorCheck.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(616, 29);
            this.label3.TabIndex = 44;
            this.label3.Text = "Select assessment below and mark complete or missed.";
            // 
            // SearchStudentModule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(918, 616);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDisplayDueDate);
            this.Controls.Add(this.lblDisplayAssessmentType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.checkMissed);
            this.Controls.Add(this.checkComplete);
            this.Controls.Add(this.dgvDisplayAssessment);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchStudentModule";
            this.Text = "SearchStudentModule";
            this.Load += new System.EventHandler(this.SearchStudentModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayAssessment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.DataGridView dgvDisplayAssessment;
        private System.Windows.Forms.CheckBox checkComplete;
        private System.Windows.Forms.CheckBox checkMissed;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDisplayAssessmentType;
        private System.Windows.Forms.Label lblDisplayDueDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ErrorProvider errorCheck;
        private System.Windows.Forms.Label label3;
    }
}