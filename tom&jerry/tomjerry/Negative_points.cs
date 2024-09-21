using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;




namespace tomjerry
{

    [Serializable]
     class Negative_points : Dot
    {
        private int points;
        
    

        public Negative_points(int x,int y): base(x, y)
        {
           
            this.points = -15;
            this.image = new PictureBox();
            this.name = "negative";
        
        }

        public virtual void DrawChange(Panel panel1, int i)
        {

         
            this.image.Image = Properties.Resources.Boom; //<<<<<<
           
            this.image.Name = i.ToString();
            this.image.Width = 50;
            this.image.Height =60;
            this.image.Location = new System.Drawing.Point(GetX(),Gety());
            this.image.Visible = true;
            this.image.MouseClick += endgame;
      
            panel1.Controls.Add(this.image);


          
           

        }

        public void badpoint()
        {
            Form1.points = Form1.points + this.points;
            Form1.score.Text = "Score:" + (Form1.points);
        }

        private void endgame(object sender, MouseEventArgs e)
        {

            Form1.points = 0;
            Form1.Tick +=25;


        }



    }
}
