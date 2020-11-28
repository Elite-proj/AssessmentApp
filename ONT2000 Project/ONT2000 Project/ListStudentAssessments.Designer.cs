namespace ONT2000_Project
{
    partial class ListStudentAssessments
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
            this.dgvDisplayAssessments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayAssessments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisplayAssessments
            // 
            this.dgvDisplayAssessments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDisplayAssessments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayAssessments.Location = new System.Drawing.Point(12, 12);
            this.dgvDisplayAssessments.Name = "dgvDisplayAssessments";
            this.dgvDisplayAssessments.RowHeadersWidth = 62;
            this.dgvDisplayAssessments.RowTemplate.Height = 28;
            this.dgvDisplayAssessments.Size = new System.Drawing.Size(894, 592);
            this.dgvDisplayAssessments.TabIndex = 0;
            // 
            // ListStudentAssessments
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(918, 616);
            this.Controls.Add(this.dgvDisplayAssessments);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListStudentAssessments";
            this.Text = "ListStudentAssessments";
            this.Load += new System.EventHandler(this.ListStudentAssessments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayAssessments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisplayAssessments;
    }
}