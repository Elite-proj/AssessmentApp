namespace ONT2000_Project
{
    partial class CreateAssessmentsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ccmbModule = new System.Windows.Forms.ComboBox();
            this.cmbAssessmentType = new System.Windows.Forms.ComboBox();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDisplayAssessment = new System.Windows.Forms.DataGridView();
            this.btnListAssessment = new FontAwesome.Sharp.IconButton();
            this.btnDeleteAssessment = new FontAwesome.Sharp.IconButton();
            this.btnUpdateAssessment = new FontAwesome.Sharp.IconButton();
            this.btnAddAssessment = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayAssessment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(113, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Module:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(113, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Assessment Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(113, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Due Date:";
            // 
            // ccmbModule
            // 
            this.ccmbModule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ccmbModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ccmbModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ccmbModule.ForeColor = System.Drawing.Color.White;
            this.ccmbModule.FormattingEnabled = true;
            this.ccmbModule.Location = new System.Drawing.Point(218, 14);
            this.ccmbModule.Name = "ccmbModule";
            this.ccmbModule.Size = new System.Drawing.Size(390, 21);
            this.ccmbModule.TabIndex = 3;
            // 
            // cmbAssessmentType
            // 
            this.cmbAssessmentType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAssessmentType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmbAssessmentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAssessmentType.ForeColor = System.Drawing.Color.White;
            this.cmbAssessmentType.FormattingEnabled = true;
            this.cmbAssessmentType.Location = new System.Drawing.Point(295, 80);
            this.cmbAssessmentType.Name = "cmbAssessmentType";
            this.cmbAssessmentType.Size = new System.Drawing.Size(313, 21);
            this.cmbAssessmentType.TabIndex = 4;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDueDate.Location = new System.Drawing.Point(238, 142);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(370, 20);
            this.dtpDueDate.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-2, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 1);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(-2, 257);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(870, 1);
            this.panel2.TabIndex = 7;
            // 
            // dgvDisplayAssessment
            // 
            this.dgvDisplayAssessment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDisplayAssessment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayAssessment.Location = new System.Drawing.Point(-2, 289);
            this.dgvDisplayAssessment.Name = "dgvDisplayAssessment";
            this.dgvDisplayAssessment.RowHeadersWidth = 62;
            this.dgvDisplayAssessment.RowTemplate.Height = 28;
            this.dgvDisplayAssessment.Size = new System.Drawing.Size(869, 299);
            this.dgvDisplayAssessment.TabIndex = 20;
            this.dgvDisplayAssessment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayAssessment_CellContentClick);
            // 
            // btnListAssessment
            // 
            this.btnListAssessment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnListAssessment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListAssessment.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnListAssessment.ForeColor = System.Drawing.Color.White;
            this.btnListAssessment.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.btnListAssessment.IconColor = System.Drawing.Color.White;
            this.btnListAssessment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListAssessment.IconSize = 35;
            this.btnListAssessment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListAssessment.Location = new System.Drawing.Point(624, 195);
            this.btnListAssessment.Name = "btnListAssessment";
            this.btnListAssessment.Rotation = 0D;
            this.btnListAssessment.Size = new System.Drawing.Size(172, 47);
            this.btnListAssessment.TabIndex = 19;
            this.btnListAssessment.Text = "LIST";
            this.btnListAssessment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListAssessment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListAssessment.UseVisualStyleBackColor = true;
            this.btnListAssessment.Click += new System.EventHandler(this.btnListAssessment_Click);
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
            this.btnDeleteAssessment.Location = new System.Drawing.Point(436, 195);
            this.btnDeleteAssessment.Name = "btnDeleteAssessment";
            this.btnDeleteAssessment.Rotation = 0D;
            this.btnDeleteAssessment.Size = new System.Drawing.Size(172, 47);
            this.btnDeleteAssessment.TabIndex = 18;
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
            this.btnUpdateAssessment.Location = new System.Drawing.Point(238, 195);
            this.btnUpdateAssessment.Name = "btnUpdateAssessment";
            this.btnUpdateAssessment.Rotation = 0D;
            this.btnUpdateAssessment.Size = new System.Drawing.Size(172, 47);
            this.btnUpdateAssessment.TabIndex = 17;
            this.btnUpdateAssessment.Text = "UPDATE";
            this.btnUpdateAssessment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateAssessment.UseVisualStyleBackColor = true;
            this.btnUpdateAssessment.Click += new System.EventHandler(this.btnUpdateAssessment_Click);
            // 
            // btnAddAssessment
            // 
            this.btnAddAssessment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddAssessment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAssessment.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAddAssessment.ForeColor = System.Drawing.Color.White;
            this.btnAddAssessment.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddAssessment.IconColor = System.Drawing.Color.White;
            this.btnAddAssessment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddAssessment.IconSize = 35;
            this.btnAddAssessment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAssessment.Location = new System.Drawing.Point(41, 195);
            this.btnAddAssessment.Name = "btnAddAssessment";
            this.btnAddAssessment.Rotation = 0D;
            this.btnAddAssessment.Size = new System.Drawing.Size(172, 47);
            this.btnAddAssessment.TabIndex = 16;
            this.btnAddAssessment.Text = "ADD";
            this.btnAddAssessment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddAssessment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddAssessment.UseVisualStyleBackColor = true;
            this.btnAddAssessment.Click += new System.EventHandler(this.btnAddAssessment_Click);
            // 
            // CreateAssessmentsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(869, 600);
            this.Controls.Add(this.dgvDisplayAssessment);
            this.Controls.Add(this.btnListAssessment);
            this.Controls.Add(this.btnDeleteAssessment);
            this.Controls.Add(this.btnUpdateAssessment);
            this.Controls.Add(this.btnAddAssessment);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.cmbAssessmentType);
            this.Controls.Add(this.ccmbModule);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAssessmentsForm";
            this.Text = "CreateAssessmentsForm";
            this.Load += new System.EventHandler(this.CreateAssessmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayAssessment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ccmbModule;
        private System.Windows.Forms.ComboBox cmbAssessmentType;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnListAssessment;
        private FontAwesome.Sharp.IconButton btnDeleteAssessment;
        private FontAwesome.Sharp.IconButton btnUpdateAssessment;
        private FontAwesome.Sharp.IconButton btnAddAssessment;
        private System.Windows.Forms.DataGridView dgvDisplayAssessment;
    }
}