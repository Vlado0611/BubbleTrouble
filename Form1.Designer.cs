
namespace BubbleTrouble
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.timeRemaining = new System.Windows.Forms.ProgressBar();
            this.lblTimeRemaining = new System.Windows.Forms.Label();
            this.timeRemainingVal = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreVal = new System.Windows.Forms.Label();
            this.congrats = new System.Windows.Forms.Label();
            this.lblBegin = new System.Windows.Forms.Label();
            this.ceilingWall = new System.Windows.Forms.PictureBox();
            this.rightWall = new System.Windows.Forms.PictureBox();
            this.leftWall = new System.Windows.Forms.PictureBox();
            this.bottomWall = new System.Windows.Forms.PictureBox();
            this.Player1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ceilingWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            this.SuspendLayout();
            // 
            // moveTimer
            // 
            this.moveTimer.Interval = 20;
            this.moveTimer.Tick += new System.EventHandler(this.moveTimerEvent);
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimerEvent);
            // 
            // lblGameOver
            // 
            this.lblGameOver.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblGameOver.Enabled = false;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGameOver.Location = new System.Drawing.Point(569, 173);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(220, 33);
            this.lblGameOver.TabIndex = 5;
            this.lblGameOver.Text = "Game Over";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeRemaining
            // 
            this.timeRemaining.BackColor = System.Drawing.SystemColors.Control;
            this.timeRemaining.Location = new System.Drawing.Point(0, 474);
            this.timeRemaining.Maximum = 80;
            this.timeRemaining.Name = "timeRemaining";
            this.timeRemaining.Size = new System.Drawing.Size(1333, 23);
            this.timeRemaining.TabIndex = 6;
            this.timeRemaining.Value = 80;
            // 
            // lblTimeRemaining
            // 
            this.lblTimeRemaining.AutoSize = true;
            this.lblTimeRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTimeRemaining.Location = new System.Drawing.Point(12, 519);
            this.lblTimeRemaining.Name = "lblTimeRemaining";
            this.lblTimeRemaining.Size = new System.Drawing.Size(147, 24);
            this.lblTimeRemaining.TabIndex = 7;
            this.lblTimeRemaining.Text = "Time remaining:";
            // 
            // timeRemainingVal
            // 
            this.timeRemainingVal.AutoSize = true;
            this.timeRemainingVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeRemainingVal.Location = new System.Drawing.Point(165, 516);
            this.timeRemainingVal.Name = "timeRemainingVal";
            this.timeRemainingVal.Size = new System.Drawing.Size(0, 27);
            this.timeRemainingVal.TabIndex = 8;
            this.timeRemainingVal.UseCompatibleTextRendering = true;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblScore.Location = new System.Drawing.Point(1120, 519);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(65, 24);
            this.lblScore.TabIndex = 9;
            this.lblScore.Text = "Score:";
            // 
            // lblScoreVal
            // 
            this.lblScoreVal.AutoSize = true;
            this.lblScoreVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblScoreVal.Location = new System.Drawing.Point(1202, 519);
            this.lblScoreVal.Name = "lblScoreVal";
            this.lblScoreVal.Size = new System.Drawing.Size(20, 24);
            this.lblScoreVal.TabIndex = 10;
            this.lblScoreVal.Text = "0";
            // 
            // congrats
            // 
            this.congrats.BackColor = System.Drawing.SystemColors.ControlDark;
            this.congrats.Enabled = false;
            this.congrats.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.congrats.Location = new System.Drawing.Point(569, 173);
            this.congrats.Name = "congrats";
            this.congrats.Size = new System.Drawing.Size(244, 51);
            this.congrats.TabIndex = 11;
            this.congrats.Text = "Congratulations !";
            this.congrats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBegin
            // 
            this.lblBegin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblBegin.Enabled = false;
            this.lblBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBegin.Location = new System.Drawing.Point(569, 173);
            this.lblBegin.Name = "lblBegin";
            this.lblBegin.Size = new System.Drawing.Size(244, 51);
            this.lblBegin.TabIndex = 12;
            this.lblBegin.Text = "Press E to start";
            this.lblBegin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ceilingWall
            // 
            this.ceilingWall.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ceilingWall.Dock = System.Windows.Forms.DockStyle.Top;
            this.ceilingWall.Image = global::BubbleTrouble.Properties.Resources.brickCeiling1;
            this.ceilingWall.Location = new System.Drawing.Point(122, 0);
            this.ceilingWall.Name = "ceilingWall";
            this.ceilingWall.Size = new System.Drawing.Size(1083, 50);
            this.ceilingWall.TabIndex = 4;
            this.ceilingWall.TabStop = false;
            // 
            // rightWall
            // 
            this.rightWall.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rightWall.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightWall.Image = ((System.Drawing.Image)(resources.GetObject("rightWall.Image")));
            this.rightWall.Location = new System.Drawing.Point(1205, 0);
            this.rightWall.Name = "rightWall";
            this.rightWall.Size = new System.Drawing.Size(128, 468);
            this.rightWall.TabIndex = 3;
            this.rightWall.TabStop = false;
            // 
            // leftWall
            // 
            this.leftWall.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.leftWall.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftWall.Image = ((System.Drawing.Image)(resources.GetObject("leftWall.Image")));
            this.leftWall.Location = new System.Drawing.Point(0, 0);
            this.leftWall.Name = "leftWall";
            this.leftWall.Size = new System.Drawing.Size(122, 468);
            this.leftWall.TabIndex = 2;
            this.leftWall.TabStop = false;
            // 
            // bottomWall
            // 
            this.bottomWall.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bottomWall.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomWall.Image = ((System.Drawing.Image)(resources.GetObject("bottomWall.Image")));
            this.bottomWall.Location = new System.Drawing.Point(0, 468);
            this.bottomWall.Name = "bottomWall";
            this.bottomWall.Size = new System.Drawing.Size(1333, 84);
            this.bottomWall.TabIndex = 1;
            this.bottomWall.TabStop = false;
            // 
            // Player1
            // 
            this.Player1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player1.BackColor = System.Drawing.Color.DarkRed;
            this.Player1.Image = global::BubbleTrouble.Properties.Resources.backturned;
            this.Player1.Location = new System.Drawing.Point(630, 402);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(43, 66);
            this.Player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Player1.TabIndex = 0;
            this.Player1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 552);
            this.Controls.Add(this.lblBegin);
            this.Controls.Add(this.congrats);
            this.Controls.Add(this.lblScoreVal);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.timeRemainingVal);
            this.Controls.Add(this.lblTimeRemaining);
            this.Controls.Add(this.timeRemaining);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.ceilingWall);
            this.Controls.Add(this.rightWall);
            this.Controls.Add(this.leftWall);
            this.Controls.Add(this.bottomWall);
            this.Controls.Add(this.Player1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.ceilingWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player1;
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.PictureBox bottomWall;
        private System.Windows.Forms.PictureBox leftWall;
        private System.Windows.Forms.PictureBox rightWall;
        private System.Windows.Forms.PictureBox ceilingWall;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.ProgressBar timeRemaining;
        private System.Windows.Forms.Label lblTimeRemaining;
        private System.Windows.Forms.Label timeRemainingVal;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScoreVal;
        private System.Windows.Forms.Label congrats;
        private System.Windows.Forms.Label lblBegin;
    }
}

