using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace tomjerry
{


    [Serializable]
    public abstract class Dot
    {

        public int x;
        public int y;
        protected string name;
        public PictureBox image;

        public string Getname() { return name; }
       


        public Dot(int x, int y)
        {
            this.x = x;
            this.y = y;
        }


       public int GetX()
        {
            return x;
        }

        public void SetX(int x)
        {
            this.x = x;
        }

        public int Gety()
        {
            return y;
        }

        public void SetY(int y)
        {
            this.y = y;
        }

        


    }
}
