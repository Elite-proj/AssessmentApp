namespace ONT2000_Project
{
    partial class ListModulesForm
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
            this.dgvDisplayModules = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayModules)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisplayModules
            // 
            this.dgvDisplayModules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDisplayModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayModules.Location = new System.Drawing.Point(12, 12);
            this.dgvDisplayModules.Name = "dgvDisplayModules";
            this.dgvDisplayModules.RowHeadersWidth = 62;
            this.dgvDisplayModules.RowTemplate.Height = 28;
            this.dgvDisplayModules.Size = new System.Drawing.Size(845, 576);
            this.dgvDisplayModules.TabIndex = 0;
            // 
            // ListModulesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(869, 600);
            this.Controls.Add(this.dgvDisplayModules);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListModulesForm";
            this.Text = "ListModulesForm";
            this.Load += new System.EventHandler(this.ListModulesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayModules)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisplayModules;
    }
}