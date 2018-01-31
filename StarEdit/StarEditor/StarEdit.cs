using System;
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
    public partial class StarEdit : Form
    {
        public static NewProject CurNewProject = null;
        public static ProjectInfo CurProjectInfo = null;
        public static ActiveProject CurProj = null;
        public static StarEdit ActiveEdit = null;
        public static string LastProjectPath = "";
        public StarEdit()
        {
            InitializeComponent();
            ActiveEdit = this;
            LoadLastProject();
            if (LastProjectPath.Length > 0)
            {
                LoadProject(LastProjectPath);
            }
        }

        public void CheckSaveProj()
        {
            
        }

        public void LoadProject(string path)
        {
            if(new DirectoryInfo(path).Exists == false)
            {
                MessageBox.Show("Project path not valid.");
                return;
            }

            var fs = new FileStream(path + "projinfo.txt", FileMode.Open, FileAccess.Read);

            var r = new BinaryReader(fs);

            CurProj = new ActiveProject()
            {
                Name = r.ReadString(),
                Info = r.ReadString(),
                Author = r.ReadString(),
                Path = r.ReadString(),
                Icon = r.ReadString(),
            };

            r.Close();
            r = null;
            fs = null;

            CurProj.IconBit = new Bitmap(CurProj.Icon);


            LastProjectPath = path;

            SaveLastProject();

            ActiveEdit.StarStat.Text = "Project:" + CurProj.Name;

        }
        public static void CreateProject(string name,string author,string info,string path,string iconPath)
        {
            if (CurProj != null)
            {
                ActiveEdit.CheckSaveProj();
            }
            CurProj = new ActiveProject()
            {
                Name = name,
                Author = author,
                Info = info,
                Path = path,
                Icon = iconPath,
                IconBit = new Bitmap(iconPath)
            };
            ActiveEdit.StarStat.Text = "Project:" + CurProj.Name;

            ActiveEdit.SaveProject();

            LastProjectPath = path;

            ActiveEdit.SaveLastProject();

        }

        public void SaveLastProject()
        {

            if (LastProjectPath.Length > 0)
            {
                File.WriteAllText("lastProj.path", LastProjectPath);
            }

        }
        public void LoadLastProject()
        {
            if (new FileInfo("lastproj.path").Exists == false) return;
            LastProjectPath = File.ReadAllText("lastProj.path");
            if (LastProjectPath.Length > 0)
            {
                LoadProject(LastProjectPath);
            }
        }

        public void SaveProject()
        {
            if (CurProj == null)
            {
                MessageBox.Show("There is no active project to save.");
                return;
            }

            LastProjectPath = CurProj.Path;

            var fs = new FileStream(CurProj.Path + "projinfo.txt", FileMode.CreateNew, FileAccess.Write);
            var w = new BinaryWriter(fs);

            w.Write(CurProj.Name);
            w.Write(CurProj.Info);
            w.Write(CurProj.Author);
            w.Write(CurProj.Path);
            w.Write(CurProj.Icon);
            w.Flush();
            w.Close();
            w = null;

        }

        private void exitEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(-1);
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurNewProject = new NewProject();
            CurNewProject.Show();
        }

        // Project Info - Windows
        private void projectInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(CurProj == null)
            {
                MessageBox.Show("No active project.");
                return;
            }
            if (CurProjectInfo != null)
            {
                CurProjectInfo.Close();
            }
            CurProjectInfo = null;
       
            if (CurProjectInfo == null)
            {
                CurProjectInfo = new ProjectInfo();
            }
            else
            {
                CurProjectInfo.Close();
                CurProjectInfo = null;
                return;
            }
                CurProjectInfo.SetName(CurProj.Name);
                CurProjectInfo.SetInfo(CurProj.Info);
                CurProjectInfo.SetAuthor(CurProj.Author);
                CurProjectInfo.SetPath(CurProj.Path);
                CurProjectInfo.SetIcon(CurProj.Icon);
            CurProjectInfo.Show();
           

            
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
