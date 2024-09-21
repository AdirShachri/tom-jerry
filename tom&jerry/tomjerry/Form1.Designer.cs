
namespace tomjerry
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timer1 = new System.Windows.Forms.Timer(components);
            real_timer = new System.Windows.Forms.Label();
            replay = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            save = new System.Windows.Forms.Button();
            load = new System.Windows.Forms.Button();
            gamePanel = new System.Windows.Forms.Panel();
            label8 = new System.Windows.Forms.Label();
            boom = new System.Windows.Forms.PictureBox();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            dog = new System.Windows.Forms.PictureBox();
            nibbles = new System.Windows.Forms.PictureBox();
            Jerry = new System.Windows.Forms.PictureBox();
            GameNameLabel = new System.Windows.Forms.Label();
            ContinueButton = new System.Windows.Forms.Button();
            Game_Menu = new System.Windows.Forms.GroupBox();
            lbl_quit = new System.Windows.Forms.Label();
            lbl_restart = new System.Windows.Forms.Label();
            lbl_over = new System.Windows.Forms.Label();
            high_Score = new System.Windows.Forms.Label();
            gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)boom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nibbles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Jerry).BeginInit();
            Game_Menu.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // real_timer
            // 
            real_timer.AutoSize = true;
            real_timer.BackColor = System.Drawing.Color.Transparent;
            real_timer.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            real_timer.Location = new System.Drawing.Point(48, 38);
            real_timer.Name = "real_timer";
            real_timer.Size = new System.Drawing.Size(191, 42);
            real_timer.TabIndex = 2;
            real_timer.Text = "Time Left: 25";
            // 
            // replay
            // 
            replay.BackColor = System.Drawing.Color.RoyalBlue;
            replay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            replay.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            replay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            replay.Location = new System.Drawing.Point(322, 20);
            replay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            replay.Name = "replay";
            replay.Size = new System.Drawing.Size(162, 60);
            replay.TabIndex = 3;
            replay.Text = "Play";
            replay.UseVisualStyleBackColor = false;
            replay.Click += replay_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(9, 21);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 35);
            label1.TabIndex = 5;
            // 
            // save
            // 
            save.BackColor = System.Drawing.Color.Azure;
            save.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            save.Location = new System.Drawing.Point(594, 30);
            save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            save.Name = "save";
            save.Size = new System.Drawing.Size(78, 43);
            save.TabIndex = 6;
            save.Text = "Save";
            save.UseVisualStyleBackColor = false;
            save.Click += save_Click;
            // 
            // load
            // 
            load.BackColor = System.Drawing.Color.Azure;
            load.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            load.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            load.Location = new System.Drawing.Point(678, 30);
            load.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            load.Name = "load";
            load.Size = new System.Drawing.Size(78, 43);
            load.TabIndex = 7;
            load.Text = "Load";
            load.UseVisualStyleBackColor = false;
            load.Click += load_Click;
            // 
            // gamePanel
            // 
            gamePanel.BackColor = System.Drawing.Color.CadetBlue;
            gamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            gamePanel.Controls.Add(label8);
            gamePanel.Controls.Add(boom);
            gamePanel.Controls.Add(label7);
            gamePanel.Controls.Add(label6);
            gamePanel.Controls.Add(label5);
            gamePanel.Controls.Add(label4);
            gamePanel.Controls.Add(label3);
            gamePanel.Controls.Add(label2);
            gamePanel.Controls.Add(dog);
            gamePanel.Controls.Add(nibbles);
            gamePanel.Controls.Add(Jerry);
            gamePanel.Controls.Add(GameNameLabel);
            gamePanel.ForeColor = System.Drawing.Color.Coral;
            gamePanel.Location = new System.Drawing.Point(63, 87);
            gamePanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new System.Drawing.Size(693, 418);
            gamePanel.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
            label8.Location = new System.Drawing.Point(489, 173);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(136, 35);
            label8.TabIndex = 23;
            label8.Text = "endgame";
            // 
            // boom
            // 
            boom.Image = Properties.Resources.Boom;
            boom.Location = new System.Drawing.Point(380, 160);
            boom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            boom.Name = "boom";
            boom.Size = new System.Drawing.Size(103, 51);
            boom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            boom.TabIndex = 22;
            boom.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
            label7.Location = new System.Drawing.Point(240, 347);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(307, 70);
            label7.TabIndex = 21;
            label7.Text = "-15 + Kill All Objects\r\n\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
            label6.Location = new System.Drawing.Point(240, 259);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(277, 70);
            label6.TabIndex = 20;
            label6.Text = "-15 + Time Reduce\r\n\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.Green;
            label5.Location = new System.Drawing.Point(294, 173);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(49, 35);
            label5.TabIndex = 19;
            label5.Text = "+5";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(87, 347);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(171, 35);
            label4.TabIndex = 18;
            label4.Text = "Bad Point: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(87, 259);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(171, 35);
            label3.TabIndex = 17;
            label3.Text = "Bad Point: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(87, 173);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(226, 35);
            label2.TabIndex = 16;
            label2.Text = "Positive Point: ";
            // 
            // dog
            // 
            dog.Image = (System.Drawing.Image)resources.GetObject("dog.Image");
            dog.Location = new System.Drawing.Point(0, 333);
            dog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dog.Name = "dog";
            dog.Size = new System.Drawing.Size(102, 51);
            dog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            dog.TabIndex = 15;
            dog.TabStop = false;
            // 
            // nibbles
            // 
            nibbles.Image = (System.Drawing.Image)resources.GetObject("nibbles.Image");
            nibbles.Location = new System.Drawing.Point(-1, 244);
            nibbles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            nibbles.Name = "nibbles";
            nibbles.Size = new System.Drawing.Size(103, 52);
            nibbles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            nibbles.TabIndex = 14;
            nibbles.TabStop = false;
            // 
            // Jerry
            // 
            Jerry.Image = (System.Drawing.Image)resources.GetObject("Jerry.Image");
            Jerry.Location = new System.Drawing.Point(-1, 160);
            Jerry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Jerry.Name = "Jerry";
            Jerry.Size = new System.Drawing.Size(103, 51);
            Jerry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            Jerry.TabIndex = 13;
            Jerry.TabStop = false;
            // 
            // GameNameLabel
            // 
            GameNameLabel.AutoSize = true;
            GameNameLabel.BackColor = System.Drawing.Color.White;
            GameNameLabel.Font = new System.Drawing.Font("Magneto", 50F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            GameNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            GameNameLabel.Location = new System.Drawing.Point(30, 12);
            GameNameLabel.Name = "GameNameLabel";
            GameNameLabel.Size = new System.Drawing.Size(595, 101);
            GameNameLabel.TabIndex = 11;
            GameNameLabel.Text = "Catch Jerry";
            // 
            // ContinueButton
            // 
            ContinueButton.BackColor = System.Drawing.Color.RoyalBlue;
            ContinueButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            ContinueButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ContinueButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            ContinueButton.Location = new System.Drawing.Point(260, 13);
            ContinueButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ContinueButton.Name = "ContinueButton";
            ContinueButton.Size = new System.Drawing.Size(288, 65);
            ContinueButton.TabIndex = 11;
            ContinueButton.Text = "Continue";
            ContinueButton.UseVisualStyleBackColor = false;
            ContinueButton.Click += ContinueButton_Click;
            // 
            // Game_Menu
            // 
            Game_Menu.BackColor = System.Drawing.Color.LightCyan;
            Game_Menu.BackgroundImage = (System.Drawing.Image)resources.GetObject("Game_Menu.BackgroundImage");
            Game_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Game_Menu.Controls.Add(lbl_quit);
            Game_Menu.Controls.Add(lbl_restart);
            Game_Menu.Controls.Add(lbl_over);
            Game_Menu.Controls.Add(high_Score);
            Game_Menu.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Game_Menu.Location = new System.Drawing.Point(-5, -1);
            Game_Menu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Game_Menu.Name = "Game_Menu";
            Game_Menu.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Game_Menu.Size = new System.Drawing.Size(801, 553);
            Game_Menu.TabIndex = 9;
            Game_Menu.TabStop = false;
            Game_Menu.Text = "End Menu";
            // 
            // lbl_quit
            // 
            lbl_quit.AutoSize = true;
            lbl_quit.BackColor = System.Drawing.Color.PowderBlue;
            lbl_quit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lbl_quit.Font = new System.Drawing.Font("Imprint MT Shadow", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_quit.Location = new System.Drawing.Point(7, 429);
            lbl_quit.Name = "lbl_quit";
            lbl_quit.Size = new System.Drawing.Size(123, 58);
            lbl_quit.TabIndex = 10;
            lbl_quit.Text = "Quit";
            lbl_quit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            lbl_quit.Click += lbl_quit_Click;
            // 
            // lbl_restart
            // 
            lbl_restart.AutoSize = true;
            lbl_restart.BackColor = System.Drawing.Color.DodgerBlue;
            lbl_restart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lbl_restart.Font = new System.Drawing.Font("Matura MT Script Capitals", 34.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_restart.Location = new System.Drawing.Point(549, 465);
            lbl_restart.Name = "lbl_restart";
            lbl_restart.Size = new System.Drawing.Size(234, 78);
            lbl_restart.TabIndex = 9;
            lbl_restart.Text = "Restart";
            lbl_restart.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            lbl_restart.Click += lbl_restart_Click;
            // 
            // lbl_over
            // 
            lbl_over.AutoSize = true;
            lbl_over.BackColor = System.Drawing.Color.Goldenrod;
            lbl_over.Font = new System.Drawing.Font("Jokerman", 48F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            lbl_over.Location = new System.Drawing.Point(155, 39);
            lbl_over.Name = "lbl_over";
            lbl_over.Size = new System.Drawing.Size(551, 117);
            lbl_over.TabIndex = 8;
            lbl_over.Text = "Game - Over";
            lbl_over.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // high_Score
            // 
            high_Score.AutoSize = true;
            high_Score.BackColor = System.Drawing.Color.PowderBlue;
            high_Score.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            high_Score.Location = new System.Drawing.Point(7, 497);
            high_Score.Name = "high_Score";
            high_Score.Size = new System.Drawing.Size(164, 37);
            high_Score.TabIndex = 4;
            high_Score.Text = "High Score:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.SkyBlue;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new System.Drawing.Size(790, 551);
            Controls.Add(Game_Menu);
            Controls.Add(ContinueButton);
            Controls.Add(replay);
            Controls.Add(gamePanel);
            Controls.Add(save);
            Controls.Add(label1);
            Controls.Add(load);
            Controls.Add(real_timer);
            DoubleBuffered = true;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            gamePanel.ResumeLayout(false);
            gamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)boom).EndInit();
            ((System.ComponentModel.ISupportInitialize)dog).EndInit();
            ((System.ComponentModel.ISupportInitialize)nibbles).EndInit();
            ((System.ComponentModel.ISupportInitialize)Jerry).EndInit();
            Game_Menu.ResumeLayout(false);
            Game_Menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label real_timer;
        private System.Windows.Forms.Button replay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Label GameNameLabel;
        private System.Windows.Forms.GroupBox Game_Menu;
        private System.Windows.Forms.Label lbl_quit;
        private System.Windows.Forms.Label lbl_restart;
        private System.Windows.Forms.Label lbl_over;
        private System.Windows.Forms.Label high_Score;
        private System.Windows.Forms.PictureBox dog;
        private System.Windows.Forms.PictureBox nibbles;
        private System.Windows.Forms.PictureBox Jerry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox boom;
    }
}

