namespace ONT2000_Project
{
    partial class LecturerMainForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.lblCurrentTab = new System.Windows.Forms.Label();
            this.currentTabIcon = new FontAwesome.Sharp.IconPictureBox();
            this.btnSearchAssessment = new FontAwesome.Sharp.IconButton();
            this.btnListStudents = new FontAwesome.Sharp.IconButton();
            this.btnCreateAssessment = new FontAwesome.Sharp.IconButton();
            this.btnListModules = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.childFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentTabIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btnSearchAssessment);
            this.panel1.Controls.Add(this.btnListStudents);
            this.panel1.Controls.Add(this.btnCreateAssessment);
            this.panel1.Controls.Add(this.btnListModules);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 733);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.lblCurrentTab);
            this.panel2.Controls.Add(this.currentTabIcon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(293, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(869, 67);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Controls.Add(this.iconPictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(293, 667);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(869, 66);
            this.panel3.TabIndex = 2;
            // 
            // childFormPanel
            // 
            this.childFormPanel.Controls.Add(this.panel4);
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(293, 67);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(869, 600);
            this.childFormPanel.TabIndex = 3;
            // 
            // lblCurrentTab
            // 
            this.lblCurrentTab.AutoSize = true;
            this.lblCurrentTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTab.ForeColor = System.Drawing.Color.White;
            this.lblCurrentTab.Location = new System.Drawing.Point(91, 12);
            this.lblCurrentTab.Name = "lblCurrentTab";
            this.lblCurrentTab.Size = new System.Drawing.Size(61, 22);
            this.lblCurrentTab.TabIndex = 1;
            this.lblCurrentTab.Text = "Home";
            // 
            // currentTabIcon
            // 
            this.currentTabIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.currentTabIcon.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.currentTabIcon.IconColor = System.Drawing.Color.White;
            this.currentTabIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.currentTabIcon.IconSize = 37;
            this.currentTabIcon.Location = new System.Drawing.Point(47, 12);
            this.currentTabIcon.Name = "currentTabIcon";
            this.currentTabIcon.Size = new System.Drawing.Size(37, 37);
            this.currentTabIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.currentTabIcon.TabIndex = 0;
            this.currentTabIcon.TabStop = false;
            // 
            // btnSearchAssessment
            // 
            this.btnSearchAssessment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchAssessment.FlatAppearance.BorderSize = 0;
            this.btnSearchAssessment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchAssessment.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSearchAssessment.ForeColor = System.Drawing.Color.White;
            this.btnSearchAssessment.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchAssessment.IconColor = System.Drawing.Color.White;
            this.btnSearchAssessment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchAssessment.IconSize = 35;
            this.btnSearchAssessment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchAssessment.Location = new System.Drawing.Point(0, 430);
            this.btnSearchAssessment.Name = "btnSearchAssessment";
            this.btnSearchAssessment.Rotation = 0D;
            this.btnSearchAssessment.Size = new System.Drawing.Size(293, 75);
            this.btnSearchAssessment.TabIndex = 4;
            this.btnSearchAssessment.Text = "Search Assessment";
            this.btnSearchAssessment.UseVisualStyleBackColor = true;
            this.btnSearchAssessment.Click += new System.EventHandler(this.btnSearchAssessment_Click);
            // 
            // btnListStudents
            // 
            this.btnListStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListStudents.FlatAppearance.BorderSize = 0;
            this.btnListStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListStudents.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnListStudents.ForeColor = System.Drawing.Color.White;
            this.btnListStudents.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.btnListStudents.IconColor = System.Drawing.Color.White;
            this.btnListStudents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListStudents.IconSize = 35;
            this.btnListStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListStudents.Location = new System.Drawing.Point(0, 355);
            this.btnListStudents.Name = "btnListStudents";
            this.btnListStudents.Rotation = 0D;
            this.btnListStudents.Size = new System.Drawing.Size(293, 75);
            this.btnListStudents.TabIndex = 3;
            this.btnListStudents.Text = "My Students";
            this.btnListStudents.UseVisualStyleBackColor = true;
            this.btnListStudents.Click += new System.EventHandler(this.btnListStudents_Click);
            // 
            // btnCreateAssessment
            // 
            this.btnCreateAssessment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateAssessment.FlatAppearance.BorderSize = 0;
            this.btnCreateAssessment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAssessment.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCreateAssessment.ForeColor = System.Drawing.Color.White;
            this.btnCreateAssessment.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnCreateAssessment.IconColor = System.Drawing.Color.White;
            this.btnCreateAssessment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCreateAssessment.IconSize = 35;
            this.btnCreateAssessment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateAssessment.Location = new System.Drawing.Point(0, 280);
            this.btnCreateAssessment.Name = "btnCreateAssessment";
            this.btnCreateAssessment.Rotation = 0D;
            this.btnCreateAssessment.Size = new System.Drawing.Size(293, 75);
            this.btnCreateAssessment.TabIndex = 2;
            this.btnCreateAssessment.Text = "Create Assesments";
            this.btnCreateAssessment.UseVisualStyleBackColor = true;
            this.btnCreateAssessment.Click += new System.EventHandler(this.btnCreateAssessment_Click);
            // 
            // btnListModules
            // 
            this.btnListModules.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListModules.FlatAppearance.BorderSize = 0;
            this.btnListModules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListModules.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnListModules.ForeColor = System.Drawing.Color.White;
            this.btnListModules.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnListModules.IconColor = System.Drawing.Color.White;
            this.btnListModules.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListModules.IconSize = 35;
            this.btnListModules.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListModules.Location = new System.Drawing.Point(0, 205);
            this.btnListModules.Name = "btnListModules";
            this.btnListModules.Rotation = 0D;
            this.btnListModules.Size = new System.Drawing.Size(293, 75);
            this.btnListModules.TabIndex = 1;
            this.btnListModules.Text = "My Modules";
            this.btnListModules.UseVisualStyleBackColor = true;
            this.btnListModules.Click += new System.EventHandler(this.btnListModules_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 205);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(869, 10);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "NELSON MANDELA UNIVERSITY";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Copyright;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(666, 15);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // LecturerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1162, 733);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LecturerMainForm";
            this.Text = "LecturerMainForm";
            this.Load += new System.EventHandler(this.LecturerMainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.childFormPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currentTabIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnListModules;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnSearchAssessment;
        private FontAwesome.Sharp.IconButton btnListStudents;
        private FontAwesome.Sharp.IconButton btnCreateAssessment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCurrentTab;
        private FontAwesome.Sharp.IconPictureBox currentTabIcon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel childFormPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}