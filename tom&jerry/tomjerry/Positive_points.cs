using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using System.Drawing;



namespace tomjerry
{

    [Serializable]
      class Positive_points : Dot 
    {
        private  int points;
        
       

        public Positive_points( int x,int y): base(x, y)
        {
            this.points = 5;
           
            this.image = new PictureBox();
            this.name = "positive";

        }


        public void Draw_P(Panel panel1, int i)
        {

            this.image.Image = Properties.Resources.jerry;
           
            this.image.Name = "positive";
            this.image.Width = 40;
            this.image.Height = 40;
            this.image.Location = new System.Drawing.Point(GetX(), Gety());
            this.image.Visible = true;
            this.image.MouseClick += Pic_MouseClick;
            panel1.Controls.Add(this.image);

        }

        private void Pic_MouseClick(object sender, MouseEventArgs e)
        {
        
            Form1.points = Form1.points + this.points;
            Form1.score.Text = "Score: " + (Form1.points);
            Form1.MainList.Remove(this);
            this.image.Visible = false;
          
        }
    }
}
