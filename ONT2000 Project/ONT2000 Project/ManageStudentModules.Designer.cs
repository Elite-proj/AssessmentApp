namespace ONT2000_Project
{
    partial class ManageStudentModules
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbModule = new System.Windows.Forms.ComboBox();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDisplayStudent = new System.Windows.Forms.DataGridView();
            this.btnListStudents = new FontAwesome.Sharp.IconButton();
            this.btnDeleteStudent = new FontAwesome.Sharp.IconButton();
            this.btnAddStudent = new FontAwesome.Sharp.IconButton();
            this.moduleError = new System.Windows.Forms.ErrorProvider(this.components);
            this.studentError = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateError = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusError)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(169, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Module:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(169, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(169, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date:";
            // 
            // cmbModule
            // 
            this.cmbModule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmbModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModule.ForeColor = System.Drawing.Color.White;
            this.cmbModule.FormattingEnabled = true;
            this.cmbModule.Location = new System.Drawing.Point(274, 36);
            this.cmbModule.Name = "cmbModule";
            this.cmbModule.Size = new System.Drawing.Size(566, 37);
            this.cmbModule.TabIndex = 4;
            // 
            // cmbStudent
            // 
            this.cmbStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmbStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStudent.ForeColor = System.Drawing.Color.White;
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(274, 86);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(566, 37);
            this.cmbStudent.TabIndex = 5;
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(274, 137);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(566, 35);
            this.dtpDate.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(1, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 1);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(1, 334);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(989, 1);
            this.panel2.TabIndex = 9;
            // 
            // dgvDisplayStudent
            // 
            this.dgvDisplayStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDisplayStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisplayStudent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisplayStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDisplayStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDisplayStudent.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDisplayStudent.Location = new System.Drawing.Point(1, 342);
            this.dgvDisplayStudent.Name = "dgvDisplayStudent";
            this.dgvDisplayStudent.RowHeadersWidth = 62;
            this.dgvDisplayStudent.RowTemplate.Height = 28;
            this.dgvDisplayStudent.Size = new System.Drawing.Size(989, 224);
            this.dgvDisplayStudent.TabIndex = 14;
            this.dgvDisplayStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayStudent_CellClick);
            // 
            // btnListStudents
            // 
            this.btnListStudents.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnListStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListStudents.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnListStudents.ForeColor = System.Drawing.Color.White;
            this.btnListStudents.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.btnListStudents.IconColor = System.Drawing.Color.White;
            this.btnListStudents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListStudents.IconSize = 35;
            this.btnListStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListStudents.Location = new System.Drawing.Point(724, 257);
            this.btnListStudents.Name = "btnListStudents";
            this.btnListStudents.Rotation = 0D;
            this.btnListStudents.Size = new System.Drawing.Size(152, 55);
            this.btnListStudents.TabIndex = 13;
            this.btnListStudents.Text = "LIST";
            this.btnListStudents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListStudents.UseVisualStyleBackColor = true;
            this.btnListStudents.Click += new System.EventHandler(this.btnListStudents_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteStudent.BackColor = System.Drawing.Color.Red;
            this.btnDeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStudent.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDeleteStudent.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStudent.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeleteStudent.IconColor = System.Drawing.Color.White;
            this.btnDeleteStudent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteStudent.IconSize = 35;
            this.btnDeleteStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteStudent.Location = new System.Drawing.Point(435, 257);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Rotation = 0D;
            this.btnDeleteStudent.Size = new System.Drawing.Size(152, 55);
            this.btnDeleteStudent.TabIndex = 12;
            this.btnDeleteStudent.Text = "DELETE";
            this.btnDeleteStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.btnAddStudent.IconColor = System.Drawing.Color.White;
            this.btnAddStudent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddStudent.IconSize = 35;
            this.btnAddStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStudent.Location = new System.Drawing.Point(116, 257);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Rotation = 0D;
            this.btnAddStudent.Size = new System.Drawing.Size(170, 55);
            this.btnAddStudent.TabIndex = 10;
            this.btnAddStudent.Text = "ENROLL";
            this.btnAddStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // moduleError
            // 
            this.moduleError.ContainerControl = this;
            // 
            // studentError
            // 
            this.studentError.ContainerControl = this;
            // 
            // dateError
            // 
            this.dateError.ContainerControl = this;
            // 
            // statusError
            // 
            this.statusError.ContainerControl = this;
            // 
            // ManageStudentModules
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(991, 578);
            this.Controls.Add(this.dgvDisplayStudent);
            this.Controls.Add(this.btnListStudents);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbStudent);
            this.Controls.Add(this.cmbModule);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageStudentModules";
            this.Text = "ManageStudentModules";
            this.Load += new System.EventHandler(this.ManageStudentModules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbModule;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnAddStudent;
        private FontAwesome.Sharp.IconButton btnDeleteStudent;
        private FontAwesome.Sharp.IconButton btnListStudents;
        private System.Windows.Forms.DataGridView dgvDisplayStudent;
        private System.Windows.Forms.ErrorProvider moduleError;
        private System.Windows.Forms.ErrorProvider studentError;
        private System.Windows.Forms.ErrorProvider dateError;
        private System.Windows.Forms.ErrorProvider statusError;
    }
}