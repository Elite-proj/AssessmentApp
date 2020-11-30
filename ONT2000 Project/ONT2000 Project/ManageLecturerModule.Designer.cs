namespace ONT2000_Project
{
    partial class ManageLecturerModule
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
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbModule = new System.Windows.Forms.ComboBox();
            this.cmbLecturer = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnListLecturer = new FontAwesome.Sharp.IconButton();
            this.btnDeleteLecturer = new FontAwesome.Sharp.IconButton();
            this.btnUpdateLecturer = new FontAwesome.Sharp.IconButton();
            this.btnAssignLecturer = new FontAwesome.Sharp.IconButton();
            this.cmbModuleError = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbLecturerError = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbStatusError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbModuleError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLecturerError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStatusError)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(169, 28);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 29);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Module:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(169, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lecturer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(169, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(169, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status";
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
            this.cmbModule.Location = new System.Drawing.Point(309, 21);
            this.cmbModule.Name = "cmbModule";
            this.cmbModule.Size = new System.Drawing.Size(472, 37);
            this.cmbModule.TabIndex = 4;
            // 
            // cmbLecturer
            // 
            this.cmbLecturer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLecturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmbLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLecturer.ForeColor = System.Drawing.Color.White;
            this.cmbLecturer.FormattingEnabled = true;
            this.cmbLecturer.Location = new System.Drawing.Point(309, 68);
            this.cmbLecturer.Name = "cmbLecturer";
            this.cmbLecturer.Size = new System.Drawing.Size(472, 37);
            this.cmbLecturer.TabIndex = 5;
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
            this.cmbStatus.Location = new System.Drawing.Point(309, 161);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(478, 37);
            this.cmbStatus.TabIndex = 6;
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(311, 113);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(472, 35);
            this.dtpDate.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(3, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 1);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(3, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(987, 1);
            this.panel2.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 331);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(987, 235);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnListLecturer
            // 
            this.btnListLecturer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnListLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListLecturer.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnListLecturer.ForeColor = System.Drawing.Color.White;
            this.btnListLecturer.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.btnListLecturer.IconColor = System.Drawing.Color.White;
            this.btnListLecturer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListLecturer.IconSize = 35;
            this.btnListLecturer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListLecturer.Location = new System.Drawing.Point(723, 244);
            this.btnListLecturer.Name = "btnListLecturer";
            this.btnListLecturer.Rotation = 0D;
            this.btnListLecturer.Size = new System.Drawing.Size(153, 50);
            this.btnListLecturer.TabIndex = 13;
            this.btnListLecturer.Text = "LIST";
            this.btnListLecturer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListLecturer.UseVisualStyleBackColor = true;
            this.btnListLecturer.Click += new System.EventHandler(this.btnListLecturer_Click);
            // 
            // btnDeleteLecturer
            // 
            this.btnDeleteLecturer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteLecturer.BackColor = System.Drawing.Color.Red;
            this.btnDeleteLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteLecturer.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDeleteLecturer.ForeColor = System.Drawing.Color.White;
            this.btnDeleteLecturer.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeleteLecturer.IconColor = System.Drawing.Color.White;
            this.btnDeleteLecturer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteLecturer.IconSize = 35;
            this.btnDeleteLecturer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteLecturer.Location = new System.Drawing.Point(531, 244);
            this.btnDeleteLecturer.Name = "btnDeleteLecturer";
            this.btnDeleteLecturer.Rotation = 0D;
            this.btnDeleteLecturer.Size = new System.Drawing.Size(166, 50);
            this.btnDeleteLecturer.TabIndex = 12;
            this.btnDeleteLecturer.Text = "DELETE";
            this.btnDeleteLecturer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteLecturer.UseVisualStyleBackColor = false;
            this.btnDeleteLecturer.Click += new System.EventHandler(this.btnDeleteLecturer_Click);
            // 
            // btnUpdateLecturer
            // 
            this.btnUpdateLecturer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdateLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateLecturer.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUpdateLecturer.ForeColor = System.Drawing.Color.White;
            this.btnUpdateLecturer.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.btnUpdateLecturer.IconColor = System.Drawing.Color.White;
            this.btnUpdateLecturer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateLecturer.IconSize = 35;
            this.btnUpdateLecturer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateLecturer.Location = new System.Drawing.Point(319, 244);
            this.btnUpdateLecturer.Name = "btnUpdateLecturer";
            this.btnUpdateLecturer.Rotation = 0D;
            this.btnUpdateLecturer.Size = new System.Drawing.Size(179, 50);
            this.btnUpdateLecturer.TabIndex = 11;
            this.btnUpdateLecturer.Text = "UPDATE";
            this.btnUpdateLecturer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateLecturer.UseVisualStyleBackColor = true;
            this.btnUpdateLecturer.Click += new System.EventHandler(this.btnUpdateLecturer_Click);
            // 
            // btnAssignLecturer
            // 
            this.btnAssignLecturer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAssignLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignLecturer.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAssignLecturer.ForeColor = System.Drawing.Color.White;
            this.btnAssignLecturer.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.btnAssignLecturer.IconColor = System.Drawing.Color.White;
            this.btnAssignLecturer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAssignLecturer.IconSize = 35;
            this.btnAssignLecturer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssignLecturer.Location = new System.Drawing.Point(126, 244);
            this.btnAssignLecturer.Name = "btnAssignLecturer";
            this.btnAssignLecturer.Rotation = 0D;
            this.btnAssignLecturer.Size = new System.Drawing.Size(166, 50);
            this.btnAssignLecturer.TabIndex = 10;
            this.btnAssignLecturer.Text = "ASSIGN";
            this.btnAssignLecturer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAssignLecturer.UseVisualStyleBackColor = true;
            this.btnAssignLecturer.Click += new System.EventHandler(this.btnAssignLecturer_Click);
            // 
            // cmbModuleError
            // 
            this.cmbModuleError.ContainerControl = this;
            // 
            // cmbLecturerError
            // 
            this.cmbLecturerError.ContainerControl = this;
            // 
            // cmbStatusError
            // 
            this.cmbStatusError.ContainerControl = this;
            // 
            // ManageLecturerModule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(991, 578);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnListLecturer);
            this.Controls.Add(this.btnDeleteLecturer);
            this.Controls.Add(this.btnUpdateLecturer);
            this.Controls.Add(this.btnAssignLecturer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbLecturer);
            this.Controls.Add(this.cmbModule);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageLecturerModule";
            this.Text = "ManageLecturerModule";
            this.Load += new System.EventHandler(this.ManageLecturerModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbModuleError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLecturerError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStatusError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbModule;
        private System.Windows.Forms.ComboBox cmbLecturer;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnAssignLecturer;
        private FontAwesome.Sharp.IconButton btnUpdateLecturer;
        private FontAwesome.Sharp.IconButton btnDeleteLecturer;
        private FontAwesome.Sharp.IconButton btnListLecturer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider cmbModuleError;
        private System.Windows.Forms.ErrorProvider cmbLecturerError;
        private System.Windows.Forms.ErrorProvider cmbStatusError;
    }
}