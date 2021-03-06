﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StarEditor
{
    public partial class NewProject : Form
    {
        public static string IconPath = "";
        public static Bitmap IconBit = null;
        public NewProject()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StarEdit.CurNewProject.Close();
            StarEdit.CurNewProject = null;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var dr = ProjectFoldB.ShowDialog();
            switch (dr)
            {
                case DialogResult.OK:
                    ProjPath.Text = ProjectFoldB.SelectedPath +"\\";
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        // Set Image
        private void button3_Click(object sender, EventArgs e)
        {
            var dr = BrowseIcon.ShowDialog();
            switch (dr)
            {
                case DialogResult.OK:
                    var imgp = BrowseIcon.FileName;
                    if(new FileInfo(imgp).Exists)
                    {
                        IconPath = imgp;
                        IconBit = new Bitmap(imgp);
                        IconView.Invalidate();
                       
                        if (IconBit == null)
                        {
                            IconPath = "";

                        }
                    }
                    break;
            }
        }

        private void IconView_Paint(object sender, PaintEventArgs e)
        {

            if (IconBit == null)
            {
                e.Graphics.DrawString("None Selected", DefaultFont, Brushes.Black,new PointF(5, 5));
            }
            else
            {
                e.Graphics.DrawImage(IconBit, new Rectangle(0, 0, IconView.Width, IconView.Height));
            }
        }

        // Create Project
        private void button1_Click(object sender, EventArgs e)
        {
            if(new DirectoryInfo(ProjPath.Text).Exists == false)
            {
                MessageBox.Show("No path has been selected for the project.");
                return;
            }
            if(new FileInfo(IconPath).Exists == false)
            {
                MessageBox.Show("No project icon has been set.");
                return;
            }
            StarEdit.CreateProject(ProjName.Text, ProjAuthor.Text, ProjInfo.Text,ProjPath.Text,IconPath );
            Close();
            StarEdit.CurNewProject = null;
        }
    }
}
