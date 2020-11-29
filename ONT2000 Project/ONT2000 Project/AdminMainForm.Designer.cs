namespace ONT2000_Project
{
    partial class AdminMainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnManageModuleType = new FontAwesome.Sharp.IconButton();
            this.btnLogOut = new FontAwesome.Sharp.IconButton();
            this.btnModuleStudents = new FontAwesome.Sharp.IconButton();
            this.btnSearchUser = new FontAwesome.Sharp.IconButton();
            this.btnSearchModule = new FontAwesome.Sharp.IconButton();
            this.btnEnrollStudent = new FontAwesome.Sharp.IconButton();
            this.btnAssignLecturer = new FontAwesome.Sharp.IconButton();
            this.btnManageModules = new FontAwesome.Sharp.IconButton();
            this.btnManageUsers = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblProfile = new System.Windows.Forms.Label();
            this.lblCurrentTab = new System.Windows.Forms.Label();
            this.currentTabIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ChildFormPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentTabIcon)).BeginInit();
            this.ChildFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btnManageModuleType);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnModuleStudents);
            this.panel1.Controls.Add(this.btnSearchUser);
            this.panel1.Controls.Add(this.btnSearchModule);
            this.panel1.Controls.Add(this.btnEnrollStudent);
            this.panel1.Controls.Add(this.btnAssignLecturer);
            this.panel1.Controls.Add(this.btnManageModules);
            this.panel1.Controls.Add(this.btnManageUsers);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 926);
            this.panel1.TabIndex = 0;
            // 
            // btnManageModuleType
            // 
            this.btnManageModuleType.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageModuleType.FlatAppearance.BorderSize = 0;
            this.btnManageModuleType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageModuleType.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnManageModuleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageModuleType.ForeColor = System.Drawing.Color.White;
            this.btnManageModuleType.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.btnManageModuleType.IconColor = System.Drawing.Color.White;
            this.btnManageModuleType.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnManageModuleType.IconSize = 50;
            this.btnManageModuleType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageModuleType.Location = new System.Drawing.Point(0, 744);
            this.btnManageModuleType.Name = "btnManageModuleType";
            this.btnManageModuleType.Rotation = 0D;
            this.btnManageModuleType.Size = new System.Drawing.Size(268, 80);
            this.btnManageModuleType.TabIndex = 10;
            this.btnManageModuleType.Text = "Assessment Type";
            this.btnManageModuleType.UseVisualStyleBackColor = true;
            this.btnManageModuleType.Click += new System.EventHandler(this.btnManageModuleType_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogOut.IconColor = System.Drawing.Color.White;
            this.btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogOut.IconSize = 38;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(12, 861);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Rotation = 0D;
            this.btnLogOut.Size = new System.Drawing.Size(131, 53);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnModuleStudents
            // 
            this.btnModuleStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModuleStudents.FlatAppearance.BorderSize = 0;
            this.btnModuleStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModuleStudents.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnModuleStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModuleStudents.ForeColor = System.Drawing.Color.White;
            this.btnModuleStudents.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.btnModuleStudents.IconColor = System.Drawing.Color.White;
            this.btnModuleStudents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModuleStudents.IconSize = 50;
            this.btnModuleStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModuleStudents.Location = new System.Drawing.Point(0, 664);
            this.btnModuleStudents.Name = "btnModuleStudents";
            this.btnModuleStudents.Rotation = 0D;
            this.btnModuleStudents.Size = new System.Drawing.Size(268, 80);
            this.btnModuleStudents.TabIndex = 7;
            this.btnModuleStudents.Text = "Module Students";
            this.btnModuleStudents.UseVisualStyleBackColor = true;
            this.btnModuleStudents.Click += new System.EventHandler(this.btnModuleStudents_Click);
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchUser.FlatAppearance.BorderSize = 0;
            this.btnSearchUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchUser.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchUser.ForeColor = System.Drawing.Color.White;
            this.btnSearchUser.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchUser.IconColor = System.Drawing.Color.White;
            this.btnSearchUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchUser.IconSize = 60;
            this.btnSearchUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchUser.Location = new System.Drawing.Point(0, 584);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Rotation = 0D;
            this.btnSearchUser.Size = new System.Drawing.Size(268, 80);
            this.btnSearchUser.TabIndex = 6;
            this.btnSearchUser.Text = "Search User";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // btnSearchModule
            // 
            this.btnSearchModule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchModule.FlatAppearance.BorderSize = 0;
            this.btnSearchModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchModule.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSearchModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchModule.ForeColor = System.Drawing.Color.White;
            this.btnSearchModule.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchModule.IconColor = System.Drawing.Color.White;
            this.btnSearchModule.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchModule.IconSize = 60;
            this.btnSearchModule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchModule.Location = new System.Drawing.Point(0, 504);
            this.btnSearchModule.Name = "btnSearchModule";
            this.btnSearchModule.Rotation = 0D;
            this.btnSearchModule.Size = new System.Drawing.Size(268, 80);
            this.btnSearchModule.TabIndex = 5;
            this.btnSearchModule.Text = "Search Module";
            this.btnSearchModule.UseVisualStyleBackColor = true;
            this.btnSearchModule.Click += new System.EventHandler(this.btnSearchModule_Click);
            // 
            // btnEnrollStudent
            // 
            this.btnEnrollStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEnrollStudent.FlatAppearance.BorderSize = 0;
            this.btnEnrollStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnrollStudent.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEnrollStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnrollStudent.ForeColor = System.Drawing.Color.White;
            this.btnEnrollStudent.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.btnEnrollStudent.IconColor = System.Drawing.Color.White;
            this.btnEnrollStudent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEnrollStudent.IconSize = 60;
            this.btnEnrollStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnrollStudent.Location = new System.Drawing.Point(0, 424);
            this.btnEnrollStudent.Name = "btnEnrollStudent";
            this.btnEnrollStudent.Rotation = 0D;
            this.btnEnrollStudent.Size = new System.Drawing.Size(268, 80);
            this.btnEnrollStudent.TabIndex = 4;
            this.btnEnrollStudent.Text = "Enroll Student";
            this.btnEnrollStudent.UseVisualStyleBackColor = true;
            this.btnEnrollStudent.Click += new System.EventHandler(this.btnEnrollStudent_Click);
            // 
            // btnAssignLecturer
            // 
            this.btnAssignLecturer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAssignLecturer.FlatAppearance.BorderSize = 0;
            this.btnAssignLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignLecturer.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAssignLecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignLecturer.ForeColor = System.Drawing.Color.White;
            this.btnAssignLecturer.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnAssignLecturer.IconColor = System.Drawing.Color.White;
            this.btnAssignLecturer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAssignLecturer.IconSize = 48;
            this.btnAssignLecturer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssignLecturer.Location = new System.Drawing.Point(0, 344);
            this.btnAssignLecturer.Name = "btnAssignLecturer";
            this.btnAssignLecturer.Rotation = 0D;
            this.btnAssignLecturer.Size = new System.Drawing.Size(268, 80);
            this.btnAssignLecturer.TabIndex = 3;
            this.btnAssignLecturer.Text = "Assign Lecturer";
            this.btnAssignLecturer.UseVisualStyleBackColor = true;
            this.btnAssignLecturer.Click += new System.EventHandler(this.btnAssignLecturer_Click);
            // 
            // btnManageModules
            // 
            this.btnManageModules.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageModules.FlatAppearance.BorderSize = 0;
            this.btnManageModules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageModules.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnManageModules.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageModules.ForeColor = System.Drawing.Color.White;
            this.btnManageModules.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnManageModules.IconColor = System.Drawing.Color.White;
            this.btnManageModules.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnManageModules.IconSize = 48;
            this.btnManageModules.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageModules.Location = new System.Drawing.Point(0, 264);
            this.btnManageModules.Name = "btnManageModules";
            this.btnManageModules.Rotation = 0D;
            this.btnManageModules.Size = new System.Drawing.Size(268, 80);
            this.btnManageModules.TabIndex = 2;
            this.btnManageModules.Text = "Manage Modules";
            this.btnManageModules.UseVisualStyleBackColor = true;
            this.btnManageModules.Click += new System.EventHandler(this.btnManageModules_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageUsers.FlatAppearance.BorderSize = 0;
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnManageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.ForeColor = System.Drawing.Color.White;
            this.btnManageUsers.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.btnManageUsers.IconColor = System.Drawing.Color.White;
            this.btnManageUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnManageUsers.IconSize = 48;
            this.btnManageUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageUsers.Location = new System.Drawing.Point(0, 184);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Rotation = 0D;
            this.btnManageUsers.Size = new System.Drawing.Size(268, 80);
            this.btnManageUsers.TabIndex = 1;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::ONT2000_Project.Properties.Resources.nmu_logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.lblProfile);
            this.panel2.Controls.Add(this.lblCurrentTab);
            this.panel2.Controls.Add(this.currentTabIcon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(268, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1076, 78);
            this.panel2.TabIndex = 1;
            // 
            // lblProfile
            // 
            this.lblProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProfile.AutoSize = true;
            this.lblProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.ForeColor = System.Drawing.Color.White;
            this.lblProfile.Location = new System.Drawing.Point(853, 31);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(79, 29);
            this.lblProfile.TabIndex = 4;
            this.lblProfile.Text = "label2";
            // 
            // lblCurrentTab
            // 
            this.lblCurrentTab.AutoSize = true;
            this.lblCurrentTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTab.ForeColor = System.Drawing.Color.White;
            this.lblCurrentTab.Location = new System.Drawing.Point(60, 24);
            this.lblCurrentTab.Name = "lblCurrentTab";
            this.lblCurrentTab.Size = new System.Drawing.Size(71, 26);
            this.lblCurrentTab.TabIndex = 1;
            this.lblCurrentTab.Text = "Home";
            // 
            // currentTabIcon
            // 
            this.currentTabIcon.BackColor = System.Drawing.Color.Navy;
            this.currentTabIcon.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.currentTabIcon.IconColor = System.Drawing.Color.White;
            this.currentTabIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.currentTabIcon.Location = new System.Drawing.Point(22, 24);
            this.currentTabIcon.Name = "currentTabIcon";
            this.currentTabIcon.Size = new System.Drawing.Size(32, 32);
            this.currentTabIcon.TabIndex = 0;
            this.currentTabIcon.TabStop = false;
            this.currentTabIcon.Click += new System.EventHandler(this.currentTabIcon_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(268, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1076, 17);
            this.panel3.TabIndex = 2;
            // 
            // ChildFormPanel
            // 
            this.ChildFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ChildFormPanel.Controls.Add(this.pictureBox2);
            this.ChildFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildFormPanel.Location = new System.Drawing.Point(268, 95);
            this.ChildFormPanel.Name = "ChildFormPanel";
            this.ChildFormPanel.Size = new System.Drawing.Size(1076, 831);
            this.ChildFormPanel.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::ONT2000_Project.Properties.Resources.nmu_logo;
            this.pictureBox2.Location = new System.Drawing.Point(337, 197);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(455, 310);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1344, 926);
            this.Controls.Add(this.ChildFormPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminMainForm";
            this.Text = "AdminMainForm";
            this.Load += new System.EventHandler(this.AdminMainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentTabIcon)).EndInit();
            this.ChildFormPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnManageUsers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnAssignLecturer;
        private FontAwesome.Sharp.IconButton btnManageModules;
        private FontAwesome.Sharp.IconButton btnEnrollStudent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCurrentTab;
        private FontAwesome.Sharp.IconPictureBox currentTabIcon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel ChildFormPanel;
        private FontAwesome.Sharp.IconButton btnSearchUser;
        private FontAwesome.Sharp.IconButton btnSearchModule;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblProfile;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private FontAwesome.Sharp.IconButton btnModuleStudents;
        private FontAwesome.Sharp.IconButton btnManageModuleType;
    }
}