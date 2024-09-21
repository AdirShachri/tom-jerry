using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;



namespace tomjerry
{


    public partial class Form1 : Form
    {


        public static int points = 0;
        public static int max_points = 0;
        public static int Tick;
        public static List<Dot> MainList = new List<Dot>();
        public static Label score = new Label();





        public Form1()
        {
            InitializeComponent();
            high_Score.Text = "Your Highest Score Is: " + points;
            this.Cursor = new Cursor(Application.StartupPath + "\\tom.cur");

            score.Text = "Score:" + points;
            score.Width = 120;
            score.Height = 70;
            score.Location = new System.Drawing.Point(0, 0);
            score.Font = new System.Drawing.Font("Imprint MT Shadow", 13);
            score.Visible = true;
            this.Controls.Add(score);
            Game_Menu.Hide();
            ContinueButton.Hide();


        }




        public void Game_Over()
        {
            foreach (Dot X in Form1.MainList)
            {
                X.image.Visible = false;

            }
            Form1.MainList.Clear();

            Tick = 0;
            real_timer.Text = "Time Left: " + (Tick);
            timer1.Stop();



            Game_Menu.Show();

            replay.Enabled = true;

            if (max_points < points)
            {

                max_points = points;
                high_Score.Text = "Your Highest Score Is: " + points;
            }
            points = 0;
            score.Text = "Score: " + (points);




        }

        public void Restart()   //  restart  the game 
        {
            load.Enabled = false;
            Tick = 0;
            timer1.Start();
            MainMenuLables();

        }



        private void Create_Position_points()
        {
            Random rnd = new Random();

            for (int i = 0; i < 1; i++)
            {

                int X = rnd.Next(10, 550);
                int Y = rnd.Next(10, 270);

                Positive_points p = new Positive_points(X, Y);

                MainList.Add(p);
                p.Draw_P(gamePanel, i);


            }

        }
        private void timer1_Tick(object sender, EventArgs e) //     implution timer amd use
        {
            Tick++;
            real_timer.Text = "Time Left: " + (25 - Tick);
            Random rnd = new Random();
            Create_Position_points();

            if (Tick >= 25)
            {
                Game_Over();
            }

            // Change Locations 

            if (Tick == 2 || Tick == 5 || Tick == 10 || Tick == 16 || Tick == 19 || Tick == 22)
            {
                for (int i = 0; i < 2; i++)
                {
                    int X = rnd.Next(10, 550);
                    int Y = rnd.Next(10, 270);

                    Negative_points CL = new ChangeLocations(X, Y);
                    MainList.Add(CL);

                    CL.DrawChange(gamePanel, i);
                }
            }

            // Timer Reducer

            if (Tick == 1 || Tick == 5 || Tick == 13 || Tick == 17 || Tick == 18 || Tick == 24)
            {
                for (int i = 0; i < 1; i++)
                {
                    int x = rnd.Next(15, 550);
                    int y = rnd.Next(15, 270);


                    Negative_points DL = new Negative_points(x, y);

                    MainList.Add(DL);

                    DL.DrawChange(gamePanel, i);
                }

            }
            if (Tick == 4 || Tick == 6 || Tick == 11 || Tick == 15 || Tick == 20 || Tick == 23)
            {
                for (int i = 0; i < 2; i++)
                {
                    int X = rnd.Next(10, 550);
                    int Y = rnd.Next(10, 270);

                    Negative_points RT = new Reduces_Time(X, Y);
                    MainList.Add(RT);

                    RT.DrawChange(gamePanel, i);
                }
            }

        }





        private void replay_Click(object sender, EventArgs e)
        {
            Game_Menu.Hide();
            gamePanel.Show();
            Restart();                               // Restart Via "Play" Button"
            replay.Enabled = false;

        }

        private void lbl_restart_Click(object sender, EventArgs e)
        {

            gamePanel.Show();
            Game_Menu.Hide();            // Restart Via Game Menu
            Restart();
            replay.Enabled = false;

        }





        private void save_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;


            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    IFormatter formatter = new BinaryFormatter();
                    using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                    {

                        SAVE s = new SAVE();
                        s.TICk = Tick;
                        s.points = points;
                        s.highscore = max_points;

                        foreach (Dot d in MainList)
                        {
                            if (d.Getname() == "positive") { s.P++; }
                            if (d.Getname() == "timer-reduce") { s.RT++; }
                            if (d.Getname() == "changeplace") { s.CL++; }
                            if (d.Getname() == "negative") { s.DL++; }


                        }
                        formatter.Serialize(stream, s);
                    }
                }
            }

            catch (IOException)
            {
                var result = MessageBox.Show("The file name is similar. Would you like to change the file name automatically?", "File Name Conflict", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string originalFileName = saveFileDialog1.FileName;
                    string newFileName = originalFileName;
                    int counter = 1;

                    while (File.Exists(newFileName))
                    {
                        string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(originalFileName);
                        string fileExtension = Path.GetExtension(originalFileName);


                        string newFileNameWithoutExtension = $"{fileNameWithoutExtension}_{counter}";


                        newFileName = Path.Combine(Path.GetDirectoryName(originalFileName), newFileNameWithoutExtension + fileExtension);

                        counter++;
                    }


                    IFormatter formatter = new BinaryFormatter();
                    using (Stream stream = new FileStream(newFileName, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        SAVE s = new SAVE();
                        s.TICk = Tick;
                        s.points = points;
                        s.highscore = max_points;

                        foreach (Dot d in MainList)
                        {
                            if (d.Getname() == "positive") { s.P++; }
                            if (d.Getname() == "timer-reduce") { s.RT++; }
                            if (d.Getname() == "changeplace") { s.CL++; }
                            if (d.Getname() == "negative") { s.DL++; }
                        }
                        formatter.Serialize(stream, s);
                    }
                }

            }

            timer1.Start();
        }


        private void load_Click(object sender, EventArgs e)
        {
            MainMenuLables();
            replay.Enabled = false;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                SAVE S = (SAVE)binaryFormatter.Deserialize(stream);


                Random rnd = new Random();

                for (int i = 0; i < S.P; i++)
                {

                    Create_Position_points();

                }
                for (int i = 0; i < S.DL; i++)
                {
                    int x = rnd.Next(15, 550);
                    int y = rnd.Next(15, 230);


                    Negative_points DL = new Negative_points(x, y);

                    MainList.Add(DL);

                    DL.DrawChange(gamePanel, i);


                }
                for (int i = 0; i < S.CL; i++)
                {

                    int X = rnd.Next(10, 550);
                    int Y = rnd.Next(10, 270);

                    Negative_points CL = new ChangeLocations(X, Y);
                    MainList.Add(CL);

                    CL.DrawChange(gamePanel, i);




                }

                for (int i = 0; i < S.RT; i++)
                {
                    int X = rnd.Next(10, 550);
                    int Y = rnd.Next(10, 270);

                    Negative_points RT = new Reduces_Time(X, Y);
                    MainList.Add(RT);

                    RT.DrawChange(gamePanel, i);


                }
                load.Enabled = false;
                //ContinueButton.Show();
                points = S.points;
                score.Text = "Score: " + S.points;
                Tick = S.TICk;
                real_timer.Text = "time left: " + (25 - Tick);
                max_points = S.highscore;
                high_Score.Text = "Your Highest Score Is: " + max_points;
                timer1.Start();

            }
            else
            {

                ContinueButton.Show();

            }

        }
        void ContinueButton_Click(object sender, EventArgs e)
        {
            ContinueButton.Hide();
            timer1.Start();
        }
        private void lbl_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenuLables()
        {
            GameNameLabel.Hide();
            Jerry.Hide();
            nibbles.Hide();
            dog.Hide();
            boom.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
        }

    }
}








