using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StarData;

namespace StarEditor
{
    public partial class StatesEdit : Form
    {
        public ActiveProject CurProj = null;
        public StarState CurState = null;
        public StateControl CurEdit = null;
        public StatesEdit()
        {
            InitializeComponent();
        }

    

        // Add State
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var ss = new StarState();
            CurProj.AddState(ss);
            RebuildUI();
            SetActiveState(ss);
        }
        public void SetActiveState(StarState ss)
        {
            CurState = ss;

        }
        public void RebuildUI()
        {
            StateTree.Nodes[0].Nodes.Clear();
            foreach (var ss in CurProj.States)
            {
                var sn = new TreeNode("State:" + ss.Name + ":" + ss.Type.ToString());
                StateTree.Nodes[0].Nodes.Add(sn);
            }
            StateTree.Nodes[0].Expand();
            StateTree.Invalidate();
            RebuildEditUI();

        }

        private void RebuildEditUI()
        {
            var an = StateTree.SelectedNode;
            int nid = 0;
            bool found = false;
            foreach (var tn in StateTree.Nodes[0].Nodes)
            {
                if (an == tn)
                {
                    found = true;
                    break;
                }
                nid++;
            }
            if(found == false)
            {
                StateEditPan.Controls.Clear();
                return;
            }
            var es = CurProj.States[nid];
            StateEditPan.Controls.Clear();
            switch (es.Type)
            {
                case StateType.Cine:
                    CurEdit = new StateCine();
                    StateEditPan.Controls.Add(CurEdit);
                    CurEdit.Dock = DockStyle.Fill;
                    CurEdit.Invalidate();
                    break;
            }
        }

        private void StateTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            RebuildEditUI();
        }
    }
}
