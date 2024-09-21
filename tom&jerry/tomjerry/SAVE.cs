using System;
using System.Collections.Generic;
using System.Text;

namespace tomjerry
{

    [Serializable]
    class SAVE
    {
        public int P;
        public int CL;
        public int DL;
        public int RT;
        public int TICk;
        public int points;
        public int highscore;


       public SAVE()
        {
            this.DL = 0;
            this.P = 0;
            this.CL = 0;
            this.RT = 0;
            
        }


    }


}
