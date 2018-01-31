using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarEditor
{
    public partial class StarEdit : Form
    {
        public static NewProject CurNewProject = null;
        public StarEdit()
        {
            InitializeComponent();
        }

        public static void CreateProject(string name,string author,string info,string path,string iconPath)
        {

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
    }
}
