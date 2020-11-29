namespace ONT2000_Project
{
    partial class StudentsMainForm
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
            this.btnLogOut = new FontAwesome.Sharp.IconButton();
            this.btnListAssessments = new FontAwesome.Sharp.IconButton();
            this.btnSearchAssessments = new FontAwesome.Sharp.IconButton();
            this.btnSearchModule = new FontAwesome.Sharp.IconButton();
            this.btnListModules = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblProfile = new System.Windows.Forms.Label();
            this.lblCurrentTab = new System.Windows.Forms.Label();
            this.currentTabIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentTabIcon)).BeginInit();
            this.childFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnListAssessments);
            this.panel1.Controls.Add(this.btnSearchAssessments);
            this.panel1.Controls.Add(this.btnSearchModule);
            this.panel1.Controls.Add(this.btnListModules);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 742);
            this.panel1.TabIndex = 0;
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
            this.btnLogOut.Location = new System.Drawing.Point(3, 685);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Rotation = 0D;
            this.btnLogOut.Size = new System.Drawing.Size(140, 54);
            this.btnLogOut.TabIndex = 11;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnListAssessments
            // 
            this.btnListAssessments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListAssessments.FlatAppearance.BorderSize = 0;
            this.btnListAssessments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListAssessments.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnListAssessments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListAssessments.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnListAssessments.IconColor = System.Drawing.Color.White;
            this.btnListAssessments.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListAssessments.IconSize = 38;
            this.btnListAssessments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListAssessments.Location = new System.Drawing.Point(0, 445);
            this.btnListAssessments.Name = "btnListAssessments";
            this.btnListAssessments.Rotation = 0D;
            this.btnListAssessments.Size = new System.Drawing.Size(332, 87);
            this.btnListAssessments.TabIndex = 4;
            this.btnListAssessments.Text = "List Assessments";
            this.btnListAssessments.UseVisualStyleBackColor = true;
            this.btnListAssessments.Click += new System.EventHandler(this.btnListAssessments_Click);
            // 
            // btnSearchAssessments
            // 
            this.btnSearchAssessments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchAssessments.FlatAppearance.BorderSize = 0;
            this.btnSearchAssessments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchAssessments.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSearchAssessments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAssessments.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchAssessments.IconColor = System.Drawing.Color.White;
            this.btnSearchAssessments.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchAssessments.IconSize = 38;
            this.btnSearchAssessments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchAssessments.Location = new System.Drawing.Point(0, 358);
            this.btnSearchAssessments.Name = "btnSearchAssessments";
            this.btnSearchAssessments.Rotation = 0D;
            this.btnSearchAssessments.Size = new System.Drawing.Size(332, 87);
            this.btnSearchAssessments.TabIndex = 3;
            this.btnSearchAssessments.Text = "Complete/Missed Work";
            this.btnSearchAssessments.UseVisualStyleBackColor = true;
            this.btnSearchAssessments.Click += new System.EventHandler(this.btnSearchAssessments_Click);
            // 
            // btnSearchModule
            // 
            this.btnSearchModule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchModule.FlatAppearance.BorderSize = 0;
            this.btnSearchModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchModule.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSearchModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchModule.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchModule.IconColor = System.Drawing.Color.White;
            this.btnSearchModule.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchModule.IconSize = 38;
            this.btnSearchModule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchModule.Location = new System.Drawing.Point(0, 271);
            this.btnSearchModule.Name = "btnSearchModule";
            this.btnSearchModule.Rotation = 0D;
            this.btnSearchModule.Size = new System.Drawing.Size(332, 87);
            this.btnSearchModule.TabIndex = 2;
            this.btnSearchModule.Text = "Search Module";
            this.btnSearchModule.UseVisualStyleBackColor = true;
            this.btnSearchModule.Click += new System.EventHandler(this.btnSearchModule_Click);
            // 
            // btnListModules
            // 
            this.btnListModules.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListModules.FlatAppearance.BorderSize = 0;
            this.btnListModules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListModules.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnListModules.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListModules.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnListModules.IconColor = System.Drawing.Color.White;
            this.btnListModules.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListModules.IconSize = 38;
            this.btnListModules.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListModules.Location = new System.Drawing.Point(0, 184);
            this.btnListModules.Name = "btnListModules";
            this.btnListModules.Rotation = 0D;
            this.btnListModules.Size = new System.Drawing.Size(332, 87);
            this.btnListModules.TabIndex = 1;
            this.btnListModules.Text = "My Modules";
            this.btnListModules.UseVisualStyleBackColor = true;
            this.btnListModules.Click += new System.EventHandler(this.btnListModules_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::ONT2000_Project.Properties.Resources.nmu_logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(332, 685);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(918, 57);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Controls.Add(this.lblProfile);
            this.panel3.Controls.Add(this.lblCurrentTab);
            this.panel3.Controls.Add(this.currentTabIcon);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(332, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(918, 59);
            this.panel3.TabIndex = 2;
            // 
            // lblProfile
            // 
            this.lblProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProfile.AutoSize = true;
            this.lblProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.ForeColor = System.Drawing.Color.White;
            this.lblProfile.Location = new System.Drawing.Point(667, 19);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(79, 29);
            this.lblProfile.TabIndex = 3;
            this.lblProfile.Text = "label2";
            // 
            // lblCurrentTab
            // 
            this.lblCurrentTab.AutoSize = true;
            this.lblCurrentTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTab.Location = new System.Drawing.Point(69, 12);
            this.lblCurrentTab.Name = "lblCurrentTab";
            this.lblCurrentTab.Size = new System.Drawing.Size(82, 29);
            this.lblCurrentTab.TabIndex = 1;
            this.lblCurrentTab.Text = "Home";
            // 
            // currentTabIcon
            // 
            this.currentTabIcon.BackColor = System.Drawing.Color.Navy;
            this.currentTabIcon.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.currentTabIcon.IconColor = System.Drawing.Color.White;
            this.currentTabIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.currentTabIcon.Location = new System.Drawing.Point(31, 12);
            this.currentTabIcon.Name = "currentTabIcon";
            this.currentTabIcon.Size = new System.Drawing.Size(32, 32);
            this.currentTabIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.currentTabIcon.TabIndex = 0;
            this.currentTabIcon.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(332, 59);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(918, 10);
            this.panel4.TabIndex = 3;
            // 
            // childFormPanel
            // 
            this.childFormPanel.Controls.Add(this.pictureBox2);
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(332, 69);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(918, 616);
            this.childFormPanel.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::ONT2000_Project.Properties.Resources.nmu_logo;
            this.pictureBox2.Location = new System.Drawing.Point(260, 115);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(422, 334);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // StudentsMainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1250, 742);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "StudentsMainForm";
            this.Text = "StudentsMainForm";
            this.Load += new System.EventHandler(this.StudentsMainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentTabIcon)).EndInit();
            this.childFormPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnListModules;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnSearchAssessments;
        private FontAwesome.Sharp.IconButton btnSearchModule;
        private FontAwesome.Sharp.IconButton btnListAssessments;
        private System.Windows.Forms.Label lblCurrentTab;
        private FontAwesome.Sharp.IconPictureBox currentTabIcon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel childFormPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblProfile;
        private FontAwesome.Sharp.IconButton btnLogOut;
    }
}