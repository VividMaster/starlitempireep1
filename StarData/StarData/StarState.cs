using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarData
{
    public enum StateType
    {
      Map,Battle,Cine,Menu,None
    }
    public enum ActionType
    {
        PlaySound,PlayMusic,DisplayImage,DisplayString,DisplayAnim,DisplayFMV,None
    }
    public class StarCol
    {
        public int R = 255, G = 255, B = 255, A = 255;
        public StarCol(int r, int g, int b, int a = 255)
        {
            R = r;
            G = g;
            B = b;
            A = a;
        }
    }
    public class StarActionGroup
    {
        public List<StarAction> Actions = new List<StarAction>();
        public void AddAction(StarAction act)
        {
            Actions.Add(act);
        }
    }
    public class StarAction
    {
        public ActionType Type = ActionType.None;
        public string DataPath = "";
        public string SubDataPAth = "";
        public int X=0, Y=0, Z=0;
        public StarCol Col1, Col2, Col3, Col4;
    }
    public class StarState
    {
        public StateType Type = StateType.Cine;
        public string Name = "";
        public List<StarActionGroup> Groups = new List<StarActionGroup>();
        public int CurAct = 0;
    }
}
