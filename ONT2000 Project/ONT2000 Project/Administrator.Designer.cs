namespace ONT2000_Project
{
    partial class Administrator
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.cmbTitle = new System.Windows.Forms.ComboBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PasswordIcon = new FontAwesome.Sharp.IconPictureBox();
            this.emailIcon = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.userIcon = new FontAwesome.Sharp.IconPictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(97, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(322, 28);
            this.txtName.TabIndex = 3;
            this.txtName.TabStop = false;
            this.txtName.Text = "Name";
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.ForeColor = System.Drawing.Color.White;
            this.txtSurname.Location = new System.Drawing.Point(97, 107);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(322, 28);
            this.txtSurname.TabIndex = 4;
            this.txtSurname.TabStop = false;
            this.txtSurname.Text = "Surname";
            // 
            // cmbTitle
            // 
            this.cmbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmbTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTitle.ForeColor = System.Drawing.Color.White;
            this.cmbTitle.FormattingEnabled = true;
            this.cmbTitle.Location = new System.Drawing.Point(97, 173);
            this.cmbTitle.Name = "cmbTitle";
            this.cmbTitle.Size = new System.Drawing.Size(322, 32);
            this.cmbTitle.TabIndex = 7;
            this.cmbTitle.TabStop = false;
            this.cmbTitle.Text = "Select title";
            // 
            // cmbRole
            // 
            this.cmbRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.ForeColor = System.Drawing.Color.White;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(97, 233);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(322, 32);
            this.cmbRole.TabIndex = 8;
            this.cmbRole.TabStop = false;
            this.cmbRole.Text = "Select role";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtEmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAddress.ForeColor = System.Drawing.Color.White;
            this.txtEmailAddress.Location = new System.Drawing.Point(97, 305);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(322, 25);
            this.txtEmailAddress.TabIndex = 9;
            this.txtEmailAddress.TabStop = false;
            this.txtEmailAddress.Text = "Email Address";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(97, 368);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(322, 25);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.TabStop = false;
            this.txtPassword.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 47);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(199, 440);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 47);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(338, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 47);
            this.button2.TabIndex = 16;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // PasswordIcon
            // 
            this.PasswordIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PasswordIcon.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.PasswordIcon.IconColor = System.Drawing.Color.White;
            this.PasswordIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PasswordIcon.IconSize = 42;
            this.PasswordIcon.Location = new System.Drawing.Point(38, 368);
            this.PasswordIcon.Name = "PasswordIcon";
            this.PasswordIcon.Size = new System.Drawing.Size(42, 42);
            this.PasswordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PasswordIcon.TabIndex = 13;
            this.PasswordIcon.TabStop = false;
            // 
            // emailIcon
            // 
            this.emailIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.emailIcon.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.emailIcon.IconColor = System.Drawing.Color.White;
            this.emailIcon.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.emailIcon.IconSize = 42;
            this.emailIcon.Location = new System.Drawing.Point(38, 305);
            this.emailIcon.Name = "emailIcon";
            this.emailIcon.Size = new System.Drawing.Size(42, 42);
            this.emailIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.emailIcon.TabIndex = 10;
            this.emailIcon.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 42;
            this.iconPictureBox1.Location = new System.Drawing.Point(38, 107);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(42, 42);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox1.TabIndex = 6;
            this.iconPictureBox1.TabStop = false;
            // 
            // userIcon
            // 
            this.userIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.userIcon.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.userIcon.IconColor = System.Drawing.Color.White;
            this.userIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.userIcon.IconSize = 42;
            this.userIcon.Location = new System.Drawing.Point(38, 47);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(42, 42);
            this.userIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.userIcon.TabIndex = 5;
            this.userIcon.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(461, 440);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 47);
            this.button3.TabIndex = 17;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(573, 548);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PasswordIcon);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.emailIcon);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.cmbTitle);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.userIcon);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Name = "Administrator";
            this.Text = "Administrator";
            ((System.ComponentModel.ISupportInitialize)(this.PasswordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private FontAwesome.Sharp.IconPictureBox userIcon;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.ComboBox cmbTitle;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private FontAwesome.Sharp.IconPictureBox emailIcon;
        private System.Windows.Forms.TextBox txtPassword;
        private FontAwesome.Sharp.IconPictureBox PasswordIcon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}