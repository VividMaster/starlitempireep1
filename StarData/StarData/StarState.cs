using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarData
{
    public enum StateType
    {
      Map,Battle,Cine,Menu,Intro,None
    }
    public enum ActionType
    {
        PlaySound,PlayMusic,DisplayImage,DisplayString,DisplayAnim,DisplayFMV,None
    }
    public class StarCol
    {
        public int R=255, G=255, B=255, A=255;
        public StarCol(int r,int g,int b,int a = 255)
        {
            R = r;
            G = g;
            B = b;
            A = a;
        }
    }
    public class StarAction
    {
        public ActionType Type = ActionType.None;
        public string DataPath = "";
        public string SubDataPAth = "";
        public int X=0, Y=0, Z=0;
        public 
    }
    public class StarState
    {
        public StateType Type = StateType.None;
        public string Name = "";
    }
}
