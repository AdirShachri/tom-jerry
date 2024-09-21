using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;


namespace tomjerry
{

    [Serializable]
    class Reduces_Time : Negative_points
    {
        private int timereduce;
      
        public Reduces_Time(int x,int y): base(x, y)
        {
          
            this.image = new PictureBox();
            this.name = "timer-reduce";
            Random rnd = new Random();
            this.timereduce = rnd.Next(5, 10);

        }


        public override void DrawChange(Panel panel1, int i)
        {
            this.image.Image = Properties.Resources.nibbles; 
            this.image.Name = i.ToString();
            this.image.Width = 40;
            this.image.Height = 40;
            this.image.Location = new System.Drawing.Point(GetX(), Gety());
            this.image.Visible = true;
            this.image.MouseClick += ReduceTime;
            panel1.Controls.Add(this.image);
        }

        private void ReduceTime(object sender, MouseEventArgs e)
        {
            Form1.MainList.Remove(this);
            Form1.Tick += this.timereduce;
            this.image.Visible = false;
            this.badpoint();
        }
    }
}
