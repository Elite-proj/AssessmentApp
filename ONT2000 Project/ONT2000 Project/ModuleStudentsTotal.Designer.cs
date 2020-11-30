namespace ONT2000_Project
{
    partial class ModuleStudentsTotal
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
            this.dgvListStudents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListStudents
            // 
            this.dgvListStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListStudents.Location = new System.Drawing.Point(12, 12);
            this.dgvListStudents.Name = "dgvListStudents";
            this.dgvListStudents.RowHeadersWidth = 62;
            this.dgvListStudents.RowTemplate.Height = 28;
            this.dgvListStudents.Size = new System.Drawing.Size(845, 576);
            this.dgvListStudents.TabIndex = 0;
            // 
            // ModuleStudentsTotal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(869, 600);
            this.Controls.Add(this.dgvListStudents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModuleStudentsTotal";
            this.Text = "ModuleStudentsTotal";
            this.Load += new System.EventHandler(this.ModuleStudentsTotal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListStudents;
    }
}