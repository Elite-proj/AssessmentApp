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
            this.lblDisplayStatus = new System.Windows.Forms.Label();
            this.lblDisplayDueDate = new System.Windows.Forms.Label();
            this.lblDisplayAssessmentType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkRescheduled = new System.Windows.Forms.CheckBox();
            this.checkComplete = new System.Windows.Forms.CheckBox();
            this.dgvDisplayAssessment = new System.Windows.Forms.DataGridView();
            this.checkMissed = new System.Windows.Forms.CheckBox();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayAssessment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assessments for:";
            // 
            // lblModule
            // 
            this.lblModule.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblModule.AutoSize = true;
            this.lblModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModule.Location = new System.Drawing.Point(402, 39);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(231, 29);
            this.lblModule.TabIndex = 1;
            this.lblModule.Text = "display module here";
            // 
            // lblDisplayStatus
            // 
            this.lblDisplayStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisplayStatus.AutoSize = true;
            this.lblDisplayStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayStatus.Location = new System.Drawing.Point(557, 268);
            this.lblDisplayStatus.Name = "lblDisplayStatus";
            this.lblDisplayStatus.Size = new System.Drawing.Size(129, 26);
            this.lblDisplayStatus.TabIndex = 37;
            this.lblDisplayStatus.Text = "display here";
            // 
            // lblDisplayDueDate
            // 
            this.lblDisplayDueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisplayDueDate.AutoSize = true;
            this.lblDisplayDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayDueDate.Location = new System.Drawing.Point(594, 220);
            this.lblDisplayDueDate.Name = "lblDisplayDueDate";
            this.lblDisplayDueDate.Size = new System.Drawing.Size(129, 26);
            this.lblDisplayDueDate.TabIndex = 36;
            this.lblDisplayDueDate.Text = "display here";
            // 
            // lblDisplayAssessmentType
            // 
            this.lblDisplayAssessmentType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisplayAssessmentType.AutoSize = true;
            this.lblDisplayAssessmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayAssessmentType.Location = new System.Drawing.Point(681, 179);
            this.lblDisplayAssessmentType.Name = "lblDisplayAssessmentType";
            this.lblDisplayAssessmentType.Size = new System.Drawing.Size(101, 22);
            this.lblDisplayAssessmentType.TabIndex = 35;
            this.lblDisplayAssessmentType.Text = "Diplay here";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(485, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 26);
            this.label3.TabIndex = 34;
            this.label3.Text = "Status:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(485, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 26);
            this.label2.TabIndex = 33;
            this.label2.Text = "Due Date:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(485, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 26);
            this.label4.TabIndex = 32;
            this.label4.Text = "Assessment Type:";
            // 
            // checkRescheduled
            // 
            this.checkRescheduled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkRescheduled.AutoSize = true;
            this.checkRescheduled.Location = new System.Drawing.Point(611, 339);
            this.checkRescheduled.Name = "checkRescheduled";
            this.checkRescheduled.Size = new System.Drawing.Size(129, 24);
            this.checkRescheduled.TabIndex = 30;
            this.checkRescheduled.Text = "Rescheduled";
            this.checkRescheduled.UseVisualStyleBackColor = true;
            // 
            // checkComplete
            // 
            this.checkComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkComplete.AutoSize = true;
            this.checkComplete.Location = new System.Drawing.Point(480, 339);
            this.checkComplete.Name = "checkComplete";
            this.checkComplete.Size = new System.Drawing.Size(103, 24);
            this.checkComplete.TabIndex = 29;
            this.checkComplete.Text = "Complete";
            this.checkComplete.UseVisualStyleBackColor = true;
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
            // 
            // checkMissed
            // 
            this.checkMissed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkMissed.AutoSize = true;
            this.checkMissed.Location = new System.Drawing.Point(775, 339);
            this.checkMissed.Name = "checkMissed";
            this.checkMissed.Size = new System.Drawing.Size(85, 24);
            this.checkMissed.TabIndex = 38;
            this.checkMissed.Text = "Missed";
            this.checkMissed.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnSave.IconColor = System.Drawing.Color.Green;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 35;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(599, 535);
            this.btnSave.Name = "btnSave";
            this.btnSave.Rotation = 0D;
            this.btnSave.Size = new System.Drawing.Size(183, 46);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // StudentModuleAssessments
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(918, 616);
            this.Controls.Add(this.checkMissed);
            this.Controls.Add(this.lblDisplayStatus);
            this.Controls.Add(this.lblDisplayDueDate);
            this.Controls.Add(this.lblDisplayAssessmentType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.checkRescheduled);
            this.Controls.Add(this.checkComplete);
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
        private System.Windows.Forms.Label lblDisplayStatus;
        private System.Windows.Forms.Label lblDisplayDueDate;
        private System.Windows.Forms.Label lblDisplayAssessmentType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.CheckBox checkRescheduled;
        private System.Windows.Forms.CheckBox checkComplete;
        private System.Windows.Forms.DataGridView dgvDisplayAssessment;
        private System.Windows.Forms.CheckBox checkMissed;
    }
}