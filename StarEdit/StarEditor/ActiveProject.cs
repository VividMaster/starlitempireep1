using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using StarData;
namespace StarEditor
{
    public class ActiveProject
    {
        public string Name = "";
        public string Author = "";
        public string Info = "";
        public string Path = "";
        public string Icon = "";
        public Bitmap IconBit = null;
        public List<StarState> States = new List<StarState>();
        public void AddState(StarState state)
        {
            States.Add(state);
        }

    }
}
