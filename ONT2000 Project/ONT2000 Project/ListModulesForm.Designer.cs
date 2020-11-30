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
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayModules)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisplayModules
            // 
            this.dgvDisplayModules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDisplayModules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisplayModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayModules.Location = new System.Drawing.Point(12, 94);
            this.dgvDisplayModules.Name = "dgvDisplayModules";
            this.dgvDisplayModules.RowHeadersWidth = 62;
            this.dgvDisplayModules.RowTemplate.Height = 28;
            this.dgvDisplayModules.Size = new System.Drawing.Size(845, 494);
            this.dgvDisplayModules.TabIndex = 0;
            this.dgvDisplayModules.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayModules_CellClick);
            this.dgvDisplayModules.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayModules_CellContentClick);
            // 
            // childFormPanel
            // 
            this.childFormPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.childFormPanel.Location = new System.Drawing.Point(0, 4);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(869, 599);
            this.childFormPanel.TabIndex = 2;
            this.childFormPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.childFormPanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 29);
            this.label1.TabIndex = 65;
            this.label1.Text = "Select modele below to see its assessments.";
            // 
            // ListModulesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(869, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.dgvDisplayModules);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListModulesForm";
            this.Text = "ListModulesForm";
            this.Load += new System.EventHandler(this.ListModulesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayModules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisplayModules;
        private System.Windows.Forms.Panel childFormPanel;
        private System.Windows.Forms.Label label1;
    }
}