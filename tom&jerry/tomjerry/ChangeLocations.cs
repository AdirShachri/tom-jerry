using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace tomjerry
{

    [Serializable]
    class ChangeLocations : Negative_points
    {
       
     
        public ChangeLocations (int x,int y): base(x, y)
        {
          
            this.image = new PictureBox();
            this.name = "changeplace";
           
        }

        public void AllLocationChange()
        { 
                foreach(Dot X in Form1.MainList)
                 {
                  X.image.Visible = false;
    
                 }
            Form1.MainList.Clear();


        }
        public override void DrawChange(Panel panel1, int i)
        {

            
            this.image.Image = Properties.Resources.dog1; 
            this.image.Name = i.ToString();
            this.image.Width = 40;
            this.image.Height = 40;
            this.image.Location = new System.Drawing.Point(GetX(), Gety());
            this.image.Visible = true;
            this.image.MouseClick += ChangeLocation;
            panel1.Controls.Add(this.image);


      
        }

        private void ChangeLocation(object sender, MouseEventArgs e)
        {
           
           this.badpoint();
            this.image.Visible = false;
            AllLocationChange();
            
        }
    }
}
