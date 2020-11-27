namespace ONT2000_Project
{
    partial class Registerform
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userIcon = new FontAwesome.Sharp.IconPictureBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.cmbTitle = new System.Windows.Forms.ComboBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.namePanel = new System.Windows.Forms.Panel();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.emailIcon = new FontAwesome.Sharp.IconPictureBox();
            this.emailPanel = new System.Windows.Forms.Panel();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.PasswordIcon = new FontAwesome.Sharp.IconPictureBox();
            this.btnRegisterUser = new FontAwesome.Sharp.IconButton();
            this.btnSignIn = new FontAwesome.Sharp.IconButton();
            this.namePanel1 = new System.Windows.Forms.Panel();
            this.btnHide = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ONT2000_Project.Properties.Resources.Nelson__Logo;
            this.pictureBox1.Location = new System.Drawing.Point(226, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // userIcon
            // 
            this.userIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.userIcon.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.userIcon.IconColor = System.Drawing.Color.White;
            this.userIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.userIcon.IconSize = 42;
            this.userIcon.Location = new System.Drawing.Point(207, 317);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(42, 42);
            this.userIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.userIcon.TabIndex = 1;
            this.userIcon.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(267, 317);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(322, 41);
            this.txtName.TabIndex = 2;
            this.txtName.TabStop = false;
            this.txtName.Text = "Name";
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.ForeColor = System.Drawing.Color.White;
            this.txtSurname.Location = new System.Drawing.Point(267, 375);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(322, 41);
            this.txtSurname.TabIndex = 3;
            this.txtSurname.TabStop = false;
            this.txtSurname.Text = "Surname";
            this.txtSurname.Click += new System.EventHandler(this.txtSurname_Click);
            // 
            // cmbTitle
            // 
            this.cmbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmbTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTitle.ForeColor = System.Drawing.Color.White;
            this.cmbTitle.FormattingEnabled = true;
            this.cmbTitle.Location = new System.Drawing.Point(267, 427);
            this.cmbTitle.Name = "cmbTitle";
            this.cmbTitle.Size = new System.Drawing.Size(322, 40);
            this.cmbTitle.TabIndex = 4;
            this.cmbTitle.TabStop = false;
            this.cmbTitle.Text = "Select title";
            this.cmbTitle.SelectedIndexChanged += new System.EventHandler(this.cmbTitle_SelectedIndexChanged);
            this.cmbTitle.Click += new System.EventHandler(this.cmbTitle_Click);
            // 
            // cmbRole
            // 
            this.cmbRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.ForeColor = System.Drawing.Color.White;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(267, 480);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(322, 40);
            this.cmbRole.TabIndex = 5;
            this.cmbRole.TabStop = false;
            this.cmbRole.Text = "Select role";
            this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.cmbRole_SelectedIndexChanged);
            this.cmbRole.Click += new System.EventHandler(this.cmbRole_Click);
            // 
            // namePanel
            // 
            this.namePanel.BackColor = System.Drawing.Color.White;
            this.namePanel.Location = new System.Drawing.Point(207, 520);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(382, 1);
            this.namePanel.TabIndex = 6;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtEmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAddress.ForeColor = System.Drawing.Color.White;
            this.txtEmailAddress.Location = new System.Drawing.Point(267, 567);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(322, 37);
            this.txtEmailAddress.TabIndex = 8;
            this.txtEmailAddress.TabStop = false;
            this.txtEmailAddress.Text = "Email Address";
            this.txtEmailAddress.Click += new System.EventHandler(this.txtEmailAddress_Click);
            // 
            // emailIcon
            // 
            this.emailIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.emailIcon.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.emailIcon.IconColor = System.Drawing.Color.White;
            this.emailIcon.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.emailIcon.IconSize = 42;
            this.emailIcon.Location = new System.Drawing.Point(207, 567);
            this.emailIcon.Name = "emailIcon";
            this.emailIcon.Size = new System.Drawing.Size(42, 42);
            this.emailIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.emailIcon.TabIndex = 7;
            this.emailIcon.TabStop = false;
            // 
            // emailPanel
            // 
            this.emailPanel.BackColor = System.Drawing.Color.White;
            this.emailPanel.Location = new System.Drawing.Point(207, 615);
            this.emailPanel.Name = "emailPanel";
            this.emailPanel.Size = new System.Drawing.Size(382, 1);
            this.emailPanel.TabIndex = 9;
            // 
            // passwordPanel
            // 
            this.passwordPanel.BackColor = System.Drawing.Color.White;
            this.passwordPanel.Location = new System.Drawing.Point(207, 711);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(382, 1);
            this.passwordPanel.TabIndex = 12;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(267, 663);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(322, 37);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.TabStop = false;
            this.txtPassword.Text = "Password";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // PasswordIcon
            // 
            this.PasswordIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PasswordIcon.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.PasswordIcon.IconColor = System.Drawing.Color.White;
            this.PasswordIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PasswordIcon.IconSize = 42;
            this.PasswordIcon.Location = new System.Drawing.Point(207, 663);
            this.PasswordIcon.Name = "PasswordIcon";
            this.PasswordIcon.Size = new System.Drawing.Size(42, 42);
            this.PasswordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PasswordIcon.TabIndex = 10;
            this.PasswordIcon.TabStop = false;
            // 
            // btnRegisterUser
            // 
            this.btnRegisterUser.BackColor = System.Drawing.Color.White;
            this.btnRegisterUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterUser.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnRegisterUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRegisterUser.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnRegisterUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRegisterUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegisterUser.IconSize = 48;
            this.btnRegisterUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterUser.Location = new System.Drawing.Point(452, 752);
            this.btnRegisterUser.Name = "btnRegisterUser";
            this.btnRegisterUser.Rotation = 0D;
            this.btnRegisterUser.Size = new System.Drawing.Size(265, 60);
            this.btnRegisterUser.TabIndex = 13;
            this.btnRegisterUser.Text = "Register User";
            this.btnRegisterUser.UseVisualStyleBackColor = false;
            this.btnRegisterUser.Click += new System.EventHandler(this.btnRegisterUser_Click);
            this.btnRegisterUser.MouseEnter += new System.EventHandler(this.btnRegisterUser_MouseEnter);
            this.btnRegisterUser.MouseLeave += new System.EventHandler(this.btnRegisterUser_MouseLeave);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.White;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSignIn.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnSignIn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSignIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSignIn.IconSize = 48;
            this.btnSignIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignIn.Location = new System.Drawing.Point(134, 752);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Rotation = 0D;
            this.btnSignIn.Size = new System.Drawing.Size(265, 60);
            this.btnSignIn.TabIndex = 14;
            this.btnSignIn.Text = "Go to sign in";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            this.btnSignIn.MouseEnter += new System.EventHandler(this.btnSignIn_MouseEnter);
            this.btnSignIn.MouseLeave += new System.EventHandler(this.btnSignIn_MouseLeave_1);
            // 
            // namePanel1
            // 
            this.namePanel1.BackColor = System.Drawing.Color.White;
            this.namePanel1.Location = new System.Drawing.Point(207, 375);
            this.namePanel1.Name = "namePanel1";
            this.namePanel1.Size = new System.Drawing.Size(382, 1);
            this.namePanel1.TabIndex = 10;
            // 
            // btnHide
            // 
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnHide.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnHide.IconColor = System.Drawing.Color.Black;
            this.btnHide.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnHide.IconSize = 45;
            this.btnHide.Location = new System.Drawing.Point(691, 3);
            this.btnHide.Name = "btnHide";
            this.btnHide.Rotation = 0D;
            this.btnHide.Size = new System.Drawing.Size(37, 32);
            this.btnHide.TabIndex = 15;
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            this.btnHide.MouseEnter += new System.EventHandler(this.btnHide_MouseEnter);
            this.btnHide.MouseLeave += new System.EventHandler(this.btnHide_MouseLeave);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnClose.IconSize = 30;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(751, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0D;
            this.btnClose.Size = new System.Drawing.Size(37, 32);
            this.btnClose.TabIndex = 16;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // Registerform
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 830);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.namePanel1);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.btnRegisterUser);
            this.Controls.Add(this.passwordPanel);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.PasswordIcon);
            this.Controls.Add(this.emailPanel);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.emailIcon);
            this.Controls.Add(this.namePanel);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.cmbTitle);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.userIcon);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registerform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registerform";
            this.Load += new System.EventHandler(this.Registerform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox userIcon;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.ComboBox cmbTitle;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private FontAwesome.Sharp.IconPictureBox emailIcon;
        private System.Windows.Forms.Panel emailPanel;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.TextBox txtPassword;
        private FontAwesome.Sharp.IconPictureBox PasswordIcon;
        private FontAwesome.Sharp.IconButton btnRegisterUser;
        private FontAwesome.Sharp.IconButton btnSignIn;
        private System.Windows.Forms.Panel namePanel1;
        private FontAwesome.Sharp.IconButton btnHide;
        private FontAwesome.Sharp.IconButton btnClose;
    }
}