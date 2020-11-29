namespace ONT2000_Project
{
    partial class StudentModuleAssessments
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
            this.lblModule = new System.Windows.Forms.Label();
            this.lblDisplayDueDate = new System.Windows.Forms.Label();
            this.lblDisplayAssessmentType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDisplayAssessment = new System.Windows.Forms.DataGridView();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayAssessment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assessments for:";
            // 
            // lblModule
            // 
            this.lblModule.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblModule.AutoSize = true;
            this.lblModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModule.Location = new System.Drawing.Point(416, 41);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(270, 32);
            this.lblModule.TabIndex = 1;
            this.lblModule.Text = "display module here";
            // 
            // lblDisplayDueDate
            // 
            this.lblDisplayDueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisplayDueDate.AutoSize = true;
            this.lblDisplayDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayDueDate.Location = new System.Drawing.Point(586, 220);
            this.lblDisplayDueDate.Name = "lblDisplayDueDate";
            this.lblDisplayDueDate.Size = new System.Drawing.Size(117, 25);
            this.lblDisplayDueDate.TabIndex = 36;
            this.lblDisplayDueDate.Text = "display here";
            // 
            // lblDisplayAssessmentType
            // 
            this.lblDisplayAssessmentType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisplayAssessmentType.AutoSize = true;
            this.lblDisplayAssessmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayAssessmentType.Location = new System.Drawing.Point(676, 175);
            this.lblDisplayAssessmentType.Name = "lblDisplayAssessmentType";
            this.lblDisplayAssessmentType.Size = new System.Drawing.Size(110, 25);
            this.lblDisplayAssessmentType.TabIndex = 35;
            this.lblDisplayAssessmentType.Text = "Diplay here";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(472, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Due Date:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(471, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Assessment Type:";
            // 
            // dgvDisplayAssessment
            // 
            this.dgvDisplayAssessment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvDisplayAssessment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayAssessment.Location = new System.Drawing.Point(12, 175);
            this.dgvDisplayAssessment.Name = "dgvDisplayAssessment";
            this.dgvDisplayAssessment.RowHeadersWidth = 62;
            this.dgvDisplayAssessment.RowTemplate.Height = 28;
            this.dgvDisplayAssessment.Size = new System.Drawing.Size(454, 429);
            this.dgvDisplayAssessment.TabIndex = 28;
            this.dgvDisplayAssessment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayAssessment_CellClick);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.LessThan;
            this.btnBack.IconColor = System.Drawing.Color.White;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.IconSize = 35;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(580, 545);
            this.btnBack.Name = "btnBack";
            this.btnBack.Rotation = 0D;
            this.btnBack.Size = new System.Drawing.Size(183, 59);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // StudentModuleAssessments
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(918, 616);
            this.Controls.Add(this.lblDisplayDueDate);
            this.Controls.Add(this.lblDisplayAssessmentType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvDisplayAssessment);
            this.Controls.Add(this.lblModule);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentModuleAssessments";
            this.Text = "StudentModuleAssessments";
            this.Load += new System.EventHandler(this.StudentModuleAssessments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayAssessment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.Label lblDisplayDueDate;
        private System.Windows.Forms.Label lblDisplayAssessmentType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnBack;
        private System.Windows.Forms.DataGridView dgvDisplayAssessment;
    }
}