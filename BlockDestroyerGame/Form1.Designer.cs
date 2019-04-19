namespace BlockDestroyerGame
{
    partial class BlockDestroyerGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BallMovement = new System.ComponentModel.BackgroundWorker();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.Stick = new System.Windows.Forms.PictureBox();
            this.CreateBlocks = new System.ComponentModel.BackgroundWorker();
            this.TimeGame = new System.Windows.Forms.Timer(this.components);
            this.timelbl = new System.Windows.Forms.Label();
            this.Lifelbl = new System.Windows.Forms.Label();
            this.LifeTimer = new System.Windows.Forms.Timer(this.components);
            this.Winloselbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stick)).BeginInit();
            this.SuspendLayout();
            // 
            // BallMovement
            // 
            this.BallMovement.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BallMovement_DoWork);
            this.BallMovement.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BallMovement_ProgressChanged);
            // 
            // Ball
            // 
            this.Ball.Image = global::BlockDestroyerGame.Properties.Resources._1421058796390;
            this.Ball.Location = new System.Drawing.Point(307, 414);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(20, 20);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ball.TabIndex = 1;
            this.Ball.TabStop = false;
            // 
            // Stick
            // 
            this.Stick.Image = global::BlockDestroyerGame.Properties.Resources._1421058561125;
            this.Stick.Location = new System.Drawing.Point(260, 435);
            this.Stick.Name = "Stick";
            this.Stick.Size = new System.Drawing.Size(120, 15);
            this.Stick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Stick.TabIndex = 0;
            this.Stick.TabStop = false;

            // 
            // CreateBlocks
            // 
            this.CreateBlocks.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CreateBlocks_DoWork);
            this.CreateBlocks.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.CreateBlocks_ProgressChanged);
            // 
            // TimeGame
            // 
            this.TimeGame.Interval = 1000;
            this.TimeGame.Tick += new System.EventHandler(this.TimeGame_Tick);
            // 
            // timelbl
            // 
            this.timelbl.BackColor = System.Drawing.Color.Black;
            this.timelbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.timelbl.ForeColor = System.Drawing.Color.White;
            this.timelbl.Location = new System.Drawing.Point(0, 0);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(115, 20);
            this.timelbl.TabIndex = 2;

            // 
            // Lifelbl
            // 
            this.Lifelbl.BackColor = System.Drawing.Color.Black;
            this.Lifelbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Lifelbl.ForeColor = System.Drawing.Color.White;
            this.Lifelbl.Location = new System.Drawing.Point(568, 0);
            this.Lifelbl.Name = "Lifelbl";
            this.Lifelbl.Size = new System.Drawing.Size(115, 20);
            this.Lifelbl.TabIndex = 3;
            // 
            // LifeTimer
            // 
            this.LifeTimer.Enabled = true;
            this.LifeTimer.Interval = 1;
            this.LifeTimer.Tick += new System.EventHandler(this.LifeTimer_Tick);
            // 
            // Winloselbl
            // 
            this.Winloselbl.BackColor = System.Drawing.Color.Transparent;
            this.Winloselbl.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Winloselbl.ForeColor = System.Drawing.Color.White;
            this.Winloselbl.Location = new System.Drawing.Point(199, 175);
            this.Winloselbl.Name = "Winloselbl";
            this.Winloselbl.Size = new System.Drawing.Size(300, 95);
            this.Winloselbl.TabIndex = 4;
            this.Winloselbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Winloselbl.Visible = false;
            // 
            // BlockDestroyerGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 466);
            this.Controls.Add(this.Winloselbl);
            this.Controls.Add(this.Lifelbl);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Stick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "BlockDestroyerGame";
            this.Text = "Block Destroyer Game";
            this.Load += new System.EventHandler(this.BlockDestroyerGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BlockDestroyerGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stick)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker BallMovement;
        private System.Windows.Forms.PictureBox Stick;
        private System.Windows.Forms.PictureBox Ball;
        private System.ComponentModel.BackgroundWorker CreateBlocks;
        private System.Windows.Forms.Timer TimeGame;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Label Lifelbl;
        private System.Windows.Forms.Timer LifeTimer;
        private System.Windows.Forms.Label Winloselbl;
    }
}

