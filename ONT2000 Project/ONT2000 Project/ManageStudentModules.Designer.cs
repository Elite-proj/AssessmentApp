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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbModule = new System.Windows.Forms.ComboBox();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDisplayStudent = new System.Windows.Forms.DataGridView();
            this.btnListStudents = new FontAwesome.Sharp.IconButton();
            this.btnDeleteStudent = new FontAwesome.Sharp.IconButton();
            this.btnUpdateStudent = new FontAwesome.Sharp.IconButton();
            this.btnAddStudent = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(169, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
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
            this.label2.Size = new System.Drawing.Size(70, 20);
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
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(169, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status:";
            // 
            // cmbModule
            // 
            this.cmbModule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmbModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModule.FormattingEnabled = true;
            this.cmbModule.Location = new System.Drawing.Point(274, 36);
            this.cmbModule.Name = "cmbModule";
            this.cmbModule.Size = new System.Drawing.Size(566, 28);
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
            this.cmbStudent.Size = new System.Drawing.Size(566, 28);
            this.cmbStudent.TabIndex = 5;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.ForeColor = System.Drawing.Color.White;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(274, 177);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(566, 28);
            this.cmbStatus.TabIndex = 6;
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(274, 137);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(566, 26);
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
            this.dgvDisplayStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayStudent.Location = new System.Drawing.Point(1, 342);
            this.dgvDisplayStudent.Name = "dgvDisplayStudent";
            this.dgvDisplayStudent.RowHeadersWidth = 62;
            this.dgvDisplayStudent.RowTemplate.Height = 28;
            this.dgvDisplayStudent.Size = new System.Drawing.Size(989, 224);
            this.dgvDisplayStudent.TabIndex = 14;
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
            this.btnDeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStudent.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDeleteStudent.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStudent.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeleteStudent.IconColor = System.Drawing.Color.White;
            this.btnDeleteStudent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteStudent.IconSize = 35;
            this.btnDeleteStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteStudent.Location = new System.Drawing.Point(537, 257);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Rotation = 0D;
            this.btnDeleteStudent.Size = new System.Drawing.Size(152, 55);
            this.btnDeleteStudent.TabIndex = 12;
            this.btnDeleteStudent.Text = "DELETE";
            this.btnDeleteStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStudent.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUpdateStudent.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStudent.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.btnUpdateStudent.IconColor = System.Drawing.Color.White;
            this.btnUpdateStudent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateStudent.IconSize = 35;
            this.btnUpdateStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateStudent.Location = new System.Drawing.Point(323, 257);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Rotation = 0D;
            this.btnUpdateStudent.Size = new System.Drawing.Size(177, 55);
            this.btnUpdateStudent.TabIndex = 11;
            this.btnUpdateStudent.Text = "UPDATE";
            this.btnUpdateStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
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
            // ManageStudentModules
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(991, 578);
            this.Controls.Add(this.dgvDisplayStudent);
            this.Controls.Add(this.btnListStudents);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnUpdateStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbStudent);
            this.Controls.Add(this.cmbModule);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageStudentModules";
            this.Text = "ManageStudentModules";
            this.Load += new System.EventHandler(this.ManageStudentModules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbModule;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnAddStudent;
        private FontAwesome.Sharp.IconButton btnUpdateStudent;
        private FontAwesome.Sharp.IconButton btnDeleteStudent;
        private FontAwesome.Sharp.IconButton btnListStudents;
        private System.Windows.Forms.DataGridView dgvDisplayStudent;
    }
}