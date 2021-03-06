﻿namespace StarEditor
{
    partial class ProjectInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.ProjName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProjAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProjInfo = new System.Windows.Forms.RichTextBox();
            this.ProjIcon = new System.Windows.Forms.GroupBox();
            this.IconView = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ProjPath = new System.Windows.Forms.TextBox();
            this.ProjectFoldB = new System.Windows.Forms.FolderBrowserDialog();
            this.BrowseIcon = new System.Windows.Forms.OpenFileDialog();
            this.ProjIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name";
            // 
            // ProjName
            // 
            this.ProjName.Location = new System.Drawing.Point(100, 9);
            this.ProjName.Name = "ProjName";
            this.ProjName.ReadOnly = true;
            this.ProjName.Size = new System.Drawing.Size(535, 20);
            this.ProjName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Project Author/s";
            // 
            // ProjAuthor
            // 
            this.ProjAuthor.Location = new System.Drawing.Point(100, 40);
            this.ProjAuthor.Name = "ProjAuthor";
            this.ProjAuthor.ReadOnly = true;
            this.ProjAuthor.Size = new System.Drawing.Size(535, 20);
            this.ProjAuthor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Project Info";
            // 
            // ProjInfo
            // 
            this.ProjInfo.Location = new System.Drawing.Point(99, 72);
            this.ProjInfo.Name = "ProjInfo";
            this.ProjInfo.ReadOnly = true;
            this.ProjInfo.Size = new System.Drawing.Size(535, 120);
            this.ProjInfo.TabIndex = 5;
            this.ProjInfo.Text = "";
            // 
            // ProjIcon
            // 
            this.ProjIcon.Controls.Add(this.IconView);
            this.ProjIcon.Location = new System.Drawing.Point(651, 40);
            this.ProjIcon.Name = "ProjIcon";
            this.ProjIcon.Size = new System.Drawing.Size(273, 152);
            this.ProjIcon.TabIndex = 8;
            this.ProjIcon.TabStop = false;
            this.ProjIcon.Text = "Project Icon";
            // 
            // IconView
            // 
            this.IconView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IconView.Location = new System.Drawing.Point(3, 16);
            this.IconView.Name = "IconView";
            this.IconView.Size = new System.Drawing.Size(267, 133);
            this.IconView.TabIndex = 0;
            this.IconView.Paint += new System.Windows.Forms.PaintEventHandler(this.IconView_Paint);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(651, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(273, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Set Image";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Project Path";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ProjPath
            // 
            this.ProjPath.Location = new System.Drawing.Point(99, 206);
            this.ProjPath.Name = "ProjPath";
            this.ProjPath.ReadOnly = true;
            this.ProjPath.Size = new System.Drawing.Size(425, 20);
            this.ProjPath.TabIndex = 11;
            // 
            // ProjectFoldB
            // 
            this.ProjectFoldB.Description = "Select Folder To Create Project";
            this.ProjectFoldB.RootFolder = System.Environment.SpecialFolder.UserProfile;
            // 
            // BrowseIcon
            // 
            this.BrowseIcon.DefaultExt = "png";
            this.BrowseIcon.Title = "Select an image as the project\'s Icon.";
            // 
            // ProjectInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(939, 260);
            this.Controls.Add(this.ProjPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ProjIcon);
            this.Controls.Add(this.ProjInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProjAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProjName);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectInfo";
            this.Text = "Project Info";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ProjectInfo_Load);
            this.ProjIcon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProjName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProjAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox ProjInfo;
        private System.Windows.Forms.GroupBox ProjIcon;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProjPath;
        private System.Windows.Forms.FolderBrowserDialog ProjectFoldB;
        private System.Windows.Forms.OpenFileDialog BrowseIcon;
        private System.Windows.Forms.Panel IconView;
    }
}