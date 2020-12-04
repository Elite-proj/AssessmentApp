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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDisplayAssessment = new System.Windows.Forms.DataGridView();
            this.btnListAssessment = new FontAwesome.Sharp.IconButton();
            this.btnDeleteAssessment = new FontAwesome.Sharp.IconButton();
            this.btnAddAssessment = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.cmbAssessmentType = new System.Windows.Forms.ComboBox();
            this.cmbModule = new System.Windows.Forms.ComboBox();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.moduleError = new System.Windows.Forms.ErrorProvider(this.components);
            this.descriptionError = new System.Windows.Forms.ErrorProvider(this.components);
            this.typeError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayAssessment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeError)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(1, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 1);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(1, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(870, 1);
            this.panel2.TabIndex = 7;
            // 
            // dgvDisplayAssessment
            // 
            this.dgvDisplayAssessment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDisplayAssessment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisplayAssessment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisplayAssessment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDisplayAssessment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDisplayAssessment.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDisplayAssessment.Location = new System.Drawing.Point(-2, 352);
            this.dgvDisplayAssessment.Name = "dgvDisplayAssessment";
            this.dgvDisplayAssessment.RowHeadersWidth = 62;
            this.dgvDisplayAssessment.RowTemplate.Height = 28;
            this.dgvDisplayAssessment.Size = new System.Drawing.Size(869, 236);
            this.dgvDisplayAssessment.TabIndex = 20;
            this.dgvDisplayAssessment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayAssessment_CellClick);
            // 
            // btnListAssessment
            // 
            this.btnListAssessment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnListAssessment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListAssessment.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnListAssessment.ForeColor = System.Drawing.Color.White;
            this.btnListAssessment.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.btnListAssessment.IconColor = System.Drawing.Color.White;
            this.btnListAssessment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListAssessment.IconSize = 35;
            this.btnListAssessment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListAssessment.Location = new System.Drawing.Point(346, 265);
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
            this.btnDeleteAssessment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteAssessment.BackColor = System.Drawing.Color.Red;
            this.btnDeleteAssessment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAssessment.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDeleteAssessment.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAssessment.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeleteAssessment.IconColor = System.Drawing.Color.White;
            this.btnDeleteAssessment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteAssessment.IconSize = 35;
            this.btnDeleteAssessment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAssessment.Location = new System.Drawing.Point(564, 265);
            this.btnDeleteAssessment.Name = "btnDeleteAssessment";
            this.btnDeleteAssessment.Rotation = 0D;
            this.btnDeleteAssessment.Size = new System.Drawing.Size(172, 47);
            this.btnDeleteAssessment.TabIndex = 18;
            this.btnDeleteAssessment.Text = "DELETE";
            this.btnDeleteAssessment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteAssessment.UseVisualStyleBackColor = false;
            this.btnDeleteAssessment.Click += new System.EventHandler(this.btnDeleteAssessment_Click);
            // 
            // btnAddAssessment
            // 
            this.btnAddAssessment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddAssessment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAssessment.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAddAssessment.ForeColor = System.Drawing.Color.White;
            this.btnAddAssessment.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddAssessment.IconColor = System.Drawing.Color.White;
            this.btnAddAssessment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddAssessment.IconSize = 35;
            this.btnAddAssessment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAssessment.Location = new System.Drawing.Point(120, 265);
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
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(112, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 29);
            this.label4.TabIndex = 30;
            this.label4.Text = "Assesment Decription:";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(371, 86);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(390, 39);
            this.txtDescription.TabIndex = 29;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDueDate.Location = new System.Drawing.Point(218, 198);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(543, 35);
            this.dtpDueDate.TabIndex = 28;
            // 
            // cmbAssessmentType
            // 
            this.cmbAssessmentType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAssessmentType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmbAssessmentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAssessmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAssessmentType.ForeColor = System.Drawing.Color.White;
            this.cmbAssessmentType.FormattingEnabled = true;
            this.cmbAssessmentType.Location = new System.Drawing.Point(318, 141);
            this.cmbAssessmentType.Name = "cmbAssessmentType";
            this.cmbAssessmentType.Size = new System.Drawing.Size(443, 40);
            this.cmbAssessmentType.TabIndex = 27;
            // 
            // cmbModule
            // 
            this.cmbModule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmbModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModule.ForeColor = System.Drawing.Color.White;
            this.cmbModule.FormattingEnabled = true;
            this.cmbModule.Location = new System.Drawing.Point(218, 23);
            this.cmbModule.Name = "cmbModule";
            this.cmbModule.Size = new System.Drawing.Size(543, 40);
            this.cmbModule.TabIndex = 26;
            // 
            // lblDueDate
            // 
            this.lblDueDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.ForeColor = System.Drawing.Color.White;
            this.lblDueDate.Location = new System.Drawing.Point(112, 198);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(100, 25);
            this.lblDueDate.TabIndex = 25;
            this.lblDueDate.Text = "Due Date:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(112, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Assessment Type:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(112, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Module:";
            // 
            // moduleError
            // 
            this.moduleError.ContainerControl = this;
            // 
            // descriptionError
            // 
            this.descriptionError.ContainerControl = this;
            // 
            // typeError
            // 
            this.typeError.ContainerControl = this;
            // 
            // CreateAssessmentsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(869, 600);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.cmbAssessmentType);
            this.Controls.Add(this.cmbModule);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDisplayAssessment);
            this.Controls.Add(this.btnListAssessment);
            this.Controls.Add(this.btnDeleteAssessment);
            this.Controls.Add(this.btnAddAssessment);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAssessmentsForm";
            this.Text = "CreateAssessmentsForm";
            this.Load += new System.EventHandler(this.CreateAssessmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayAssessment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnListAssessment;
        private FontAwesome.Sharp.IconButton btnDeleteAssessment;
        private FontAwesome.Sharp.IconButton btnAddAssessment;
        private System.Windows.Forms.DataGridView dgvDisplayAssessment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.ComboBox cmbAssessmentType;
        private System.Windows.Forms.ComboBox cmbModule;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider moduleError;
        private System.Windows.Forms.ErrorProvider descriptionError;
        private System.Windows.Forms.ErrorProvider typeError;
    }
}