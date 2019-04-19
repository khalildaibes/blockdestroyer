using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace BlockDestroyerGame
{
    public partial class BlockDestroyerGame : Form
    {
        public void CheckBall()
        {
            if (this.x > this.Width - 50)
                this.gx = -10;
            else if (this.x < 0)
                this.gx = 10;
            if (Ball.Bounds.IntersectsWith(Stick.Bounds))
            {
                if (this.x + 20 >= Stick.Location.X && this.x < Stick.Location.X + 60)
                    this.gx = -10;

                else if (this.x > Stick.Location.X + 60 && this.x <= Stick.Location.X + 120)
                    this.gx = 10;
                this.gy = -10;
            }
            else if (this.y < 0)
                this.gy = 10;
            
        }
        public void CheckBoom(Label b,int i)
        {
            if (b.Bounds.IntersectsWith(Ball.Bounds) && b.Visible == true)
            {
                score++;
                //Location X
                if (Ball.Location.X + 20 >= b.Location.X && Ball.Location.X <= b.Location.X + 45 || Ball.Location.X > b.Location.X + 45 && Ball.Location.X <= b.Location.X + 90)
                {
                    if (this.boom[i] == 2)
                    {
                        b.BackColor = Color.Green;
                        this.boom[i]--;
                    }
                    else
                    {
                        b.Visible = false;
                        this.boom[i]--;
                    }
                    this.gy *= -1;
                }
               
                //Location Y
                else if (Ball.Location.Y + 20 >= b.Location.Y && Ball.Location.Y <= b.Location.Y + 15 || Ball.Location.Y > b.Location.Y + 15 && Ball.Location.Y <= b.Location.Y + 25)
                {
                    if (this.boom[i] == 2)
                    {
                        b.BackColor = Color.Green;
                        this.boom[i]--;
                    }
                    else
                    {
                        b.Visible = false;
                        this.boom[i]--;
                    }
                    this.gx *= -1;
                }
            }
        }
        public BlockDestroyerGame()
        {
            InitializeComponent();
        }
        private Label[] blocks;
        private int gx=10, gy=10, x, y, xb = 34, yb = 34, t=0, m=0, l=3, score = 0;
        private int[] boom = new int[24];
        private bool flag = false;
        private void BallMovement_DoWork(object sender, DoWorkEventArgs e)
        {
            while (flag)
            {
                BallMovement.ReportProgress(1);
                Thread.Sleep(35);
            }
        }
        private void BallMovement_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            CheckBall();
            for (int i = 0; i < 24; i++)
                CheckBoom(blocks[i], i);
            Point p1;
            x += gx;
            y += gy;
            p1 = new Point(x, y);
            Ball.Location = p1;
        }
        private void BlockDestroyerGame_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 24; i++)
            {
                if (i == 8 || i == 9 || i == 14 || i == 15)
                    boom[i] = 1;
                else
                boom[i] = 2;
            }            
            CreateBlocks.WorkerReportsProgress = true;
            CreateBlocks.RunWorkerAsync();
        }
        private void BlockDestroyerGame_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    if (this.score != 44 && l > 0)
                    {
                        if (Stick.Location.X + 120 < this.Width - 50)
                        {
                            Stick.Left += 50;
                            if (!flag)
                                Ball.Left += 50;
                        }
                    }
                    break;
                case Keys.Left:
                    if (this.score != 44 && l > 0)
                    {
                        if (Stick.Location.X > 50)
                        {
                            Stick.Left -= 50;
                            if (!flag)
                                Ball.Left -= 50;
                        }
                    }
                    break;
                case Keys.Space:
                    if (this.score != 44 && l > 0)
                    {
                        this.flag = true;
                        if (!BallMovement.IsBusy)
                        {
                            BallMovement.WorkerReportsProgress = true;
                            BallMovement.RunWorkerAsync();
                            this.x = Stick.Location.X + 47;
                            this.y = Stick.Location.Y - 15;
                        }
                        TimeGame.Enabled = true;
                        LifeTimer.Enabled = true;
                    }
                                 break;
            }
        }
        private void CreateBlocks_DoWork(object sender, DoWorkEventArgs e)
        {
            blocks = new Label[24];
            for (int i = 0; i < 24; i++)
            {
                CreateBlocks.ReportProgress(i);
                Thread.Sleep(20);
            }
        }
        private void CreateBlocks_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if ((yb == 71 && xb == 246) || (yb == 71 && xb == 352) || (yb == 108 && xb == 246) || (yb == 108 && xb == 352))
            {
                blocks[e.ProgressPercentage] = new Label();
                blocks[e.ProgressPercentage].AutoSize = false;
                blocks[e.ProgressPercentage].Size = new System.Drawing.Size(90, 25);
                blocks[e.ProgressPercentage].BackColor = Color.Green;
                blocks[e.ProgressPercentage].Location = new Point(xb, yb);
                this.Controls.Add(blocks[e.ProgressPercentage]);
            }
            else
            {
                blocks[e.ProgressPercentage] = new Label();
                blocks[e.ProgressPercentage].AutoSize = false;
                blocks[e.ProgressPercentage].Size = new System.Drawing.Size(90, 25);
                blocks[e.ProgressPercentage].BackColor = Color.Red;
                blocks[e.ProgressPercentage].Location = new Point(xb, yb);
                this.Controls.Add(blocks[e.ProgressPercentage]);
            }
            xb += 106;
            
            if (xb == 670)
            {
                xb = 34;
                yb += 37;
            }
            
        }
        private void TimeGame_Tick(object sender, EventArgs e)
        {
            if (t == 60)
            {
                m++;
                t=0;
            }
            t++;
            timelbl.Text = "Time: 0" + m + ":" + t;           
        }
        private void LifeTimer_Tick(object sender, EventArgs e)
        {
            Lifelbl.Text = "Life: " + l;
            if (this.score == 44)
            {
                Winloselbl.BackColor = Color.Green;
                Winloselbl.Text = "YOU WIN";
                Winloselbl.Visible = true;
                this.flag = false;
                TimeGame.Enabled = false;
                LifeTimer.Enabled = false;
            }
            if (Ball.Location.Y > this.Height)
            {
                    this.flag = false;
                    Ball.Location = new Point(Stick.Location.X + 47, Stick.Location.Y - 20);
                    l--;
                    if (this.l == 0)
                    {
                        Winloselbl.Text = "GAME OVER, Your Score Is:" + this.score + "";
                        Winloselbl.BackColor = Color.Red;
                        Winloselbl.Visible = true;
                    }
                    Lifelbl.Text = "Life: " + l;
                    TimeGame.Enabled = false;
                    LifeTimer.Enabled = false;
                
            }
        }


    }
}
