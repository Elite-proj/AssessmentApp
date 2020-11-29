namespace ONT2000_Project
{
    partial class CreateOrListAssessmentForm
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
            this.btnGoToViewAssessments = new System.Windows.Forms.Button();
            this.btnGotoCreateAssessments = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(170, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose action below for selected module";
            // 
            // btnGoToViewAssessments
            // 
            this.btnGoToViewAssessments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToViewAssessments.ForeColor = System.Drawing.Color.White;
            this.btnGoToViewAssessments.Location = new System.Drawing.Point(467, 320);
            this.btnGoToViewAssessments.Name = "btnGoToViewAssessments";
            this.btnGoToViewAssessments.Size = new System.Drawing.Size(278, 60);
            this.btnGoToViewAssessments.TabIndex = 2;
            this.btnGoToViewAssessments.Text = "View Assessments";
            this.btnGoToViewAssessments.UseVisualStyleBackColor = true;
            this.btnGoToViewAssessments.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGotoCreateAssessments
            // 
            this.btnGotoCreateAssessments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGotoCreateAssessments.ForeColor = System.Drawing.Color.White;
            this.btnGotoCreateAssessments.Location = new System.Drawing.Point(104, 320);
            this.btnGotoCreateAssessments.Name = "btnGotoCreateAssessments";
            this.btnGotoCreateAssessments.Size = new System.Drawing.Size(278, 60);
            this.btnGotoCreateAssessments.TabIndex = 3;
            this.btnGotoCreateAssessments.Text = "Create Assessment";
            this.btnGotoCreateAssessments.UseVisualStyleBackColor = true;
            // 
            // CreateOrListAssessmentForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(869, 600);
            this.Controls.Add(this.btnGotoCreateAssessments);
            this.Controls.Add(this.btnGoToViewAssessments);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateOrListAssessmentForm";
            this.Text = "CreateOrListAssessmentForm";
            this.Load += new System.EventHandler(this.CreateOrListAssessmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGoToViewAssessments;
        private System.Windows.Forms.Button btnGotoCreateAssessments;
    }
}