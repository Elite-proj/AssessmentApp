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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCurrentTab = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ChildFormPanel = new System.Windows.Forms.Panel();
            this.currentTabIcon = new FontAwesome.Sharp.IconPictureBox();
            this.btnEnrollStudent = new FontAwesome.Sharp.IconButton();
            this.btnAssignLecturer = new FontAwesome.Sharp.IconButton();
            this.btnManageModules = new FontAwesome.Sharp.IconButton();
            this.btnManageUsers = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSearchModule = new FontAwesome.Sharp.IconButton();
            this.btnSearchUser = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentTabIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
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
            this.panel1.Size = new System.Drawing.Size(268, 673);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.lblCurrentTab);
            this.panel2.Controls.Add(this.currentTabIcon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(268, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(953, 78);
            this.panel2.TabIndex = 1;
            // 
            // lblCurrentTab
            // 
            this.lblCurrentTab.AutoSize = true;
            this.lblCurrentTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTab.ForeColor = System.Drawing.Color.White;
            this.lblCurrentTab.Location = new System.Drawing.Point(60, 24);
            this.lblCurrentTab.Name = "lblCurrentTab";
            this.lblCurrentTab.Size = new System.Drawing.Size(57, 22);
            this.lblCurrentTab.TabIndex = 1;
            this.lblCurrentTab.Text = "Home";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(268, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(953, 17);
            this.panel3.TabIndex = 2;
            // 
            // ChildFormPanel
            // 
            this.ChildFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ChildFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildFormPanel.Location = new System.Drawing.Point(268, 95);
            this.ChildFormPanel.Name = "ChildFormPanel";
            this.ChildFormPanel.Size = new System.Drawing.Size(953, 578);
            this.ChildFormPanel.TabIndex = 3;
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
            // btnEnrollStudent
            // 
            this.btnEnrollStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEnrollStudent.FlatAppearance.BorderSize = 0;
            this.btnEnrollStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnrollStudent.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEnrollStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnrollStudent.ForeColor = System.Drawing.Color.White;
            this.btnEnrollStudent.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.btnEnrollStudent.IconColor = System.Drawing.Color.White;
            this.btnEnrollStudent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEnrollStudent.IconSize = 60;
            this.btnEnrollStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnrollStudent.Location = new System.Drawing.Point(0, 425);
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
            this.btnAssignLecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignLecturer.ForeColor = System.Drawing.Color.White;
            this.btnAssignLecturer.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnAssignLecturer.IconColor = System.Drawing.Color.White;
            this.btnAssignLecturer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAssignLecturer.IconSize = 48;
            this.btnAssignLecturer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssignLecturer.Location = new System.Drawing.Point(0, 345);
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
            this.btnManageModules.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageModules.ForeColor = System.Drawing.Color.White;
            this.btnManageModules.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnManageModules.IconColor = System.Drawing.Color.White;
            this.btnManageModules.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnManageModules.IconSize = 48;
            this.btnManageModules.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageModules.Location = new System.Drawing.Point(0, 265);
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
            this.btnManageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.ForeColor = System.Drawing.Color.White;
            this.btnManageUsers.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.btnManageUsers.IconColor = System.Drawing.Color.White;
            this.btnManageUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnManageUsers.IconSize = 48;
            this.btnManageUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageUsers.Location = new System.Drawing.Point(0, 185);
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
            this.pictureBox1.Image = global::ONT2000_Project.Properties.Resources.Nelson__Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 185);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSearchModule
            // 
            this.btnSearchModule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchModule.FlatAppearance.BorderSize = 0;
            this.btnSearchModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchModule.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSearchModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchModule.ForeColor = System.Drawing.Color.White;
            this.btnSearchModule.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchModule.IconColor = System.Drawing.Color.White;
            this.btnSearchModule.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchModule.IconSize = 60;
            this.btnSearchModule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchModule.Location = new System.Drawing.Point(0, 505);
            this.btnSearchModule.Name = "btnSearchModule";
            this.btnSearchModule.Rotation = 0D;
            this.btnSearchModule.Size = new System.Drawing.Size(268, 80);
            this.btnSearchModule.TabIndex = 5;
            this.btnSearchModule.Text = "Search Module";
            this.btnSearchModule.UseVisualStyleBackColor = true;
            this.btnSearchModule.Click += new System.EventHandler(this.btnSearchModule_Click);
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchUser.FlatAppearance.BorderSize = 0;
            this.btnSearchUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchUser.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchUser.ForeColor = System.Drawing.Color.White;
            this.btnSearchUser.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchUser.IconColor = System.Drawing.Color.White;
            this.btnSearchUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchUser.IconSize = 60;
            this.btnSearchUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchUser.Location = new System.Drawing.Point(0, 585);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Rotation = 0D;
            this.btnSearchUser.Size = new System.Drawing.Size(268, 80);
            this.btnSearchUser.TabIndex = 6;
            this.btnSearchUser.Text = "Search User";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1221, 673);
            this.Controls.Add(this.ChildFormPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminMainForm";
            this.Text = "AdminMainForm";
            this.Load += new System.EventHandler(this.AdminMainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentTabIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}