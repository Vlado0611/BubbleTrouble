using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace BubbleTrouble
{
    public partial class Form1 : Form
    {

        bool moveRight, moveLeft; // govore da li se karakter krece lijevo ili desno
        int speed = 6; // brzina kojom se karakter krece
        int level = 3, timeLeft = 80; // level je nivo na kom se nalazi pocetna lopta, subIndex broj
        public bool timeExpired = false; // govori da li je isteklo vrijeme, sluzi za klasu balloon
        public static int score = 0;
        bool beginGame = false;
        List<PlayerScore> scoreList;
        public SoundPlayer sound = new SoundPlayer(Properties.Resources.pop);

        public Form1()
        {
            InitializeComponent();
            this.lblGameOver.Hide(); // krijemo gameover labelu
            this.congrats.Hide(); // krijemo congrats labelu
            this.BackgroundImage = Properties.Resources.landscape2;
            this.BackColor = Color.White;
            this.BackgroundImageLayout = ImageLayout.Center;
            this.Player1.BackColor = Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }

        private void moveTimerEvent(object sender, EventArgs e)
        {
                if (moveLeft && !Player1.Bounds.IntersectsWith(leftWall.Bounds))
                {
                    // pomjeramo igraca lijevo 
                    Player1.Left -= speed;

                }

                if (moveRight && !Player1.Bounds.IntersectsWith(rightWall.Bounds))
                {
                    // pomjeramo igraca desno
                    Player1.Left += speed;                   
                    

                }

                ///bottomWall.Height = this.Height - Player1.Location.Y - 2*Player1.Height + 20; // za fullscreen, povecava donji zid
                // dodati skaliranje za igraca, druge zidove i balone


                if (Balloon.makeMore)
                {   // ako je balon probusen, dodaj dva nova
                    MakeBalloon(Balloon.toMake - 1, Balloon.destPosX + 10, Balloon.destPosY, 1);
                    MakeBalloon(Balloon.toMake - 1, Balloon.destPosX - 10, Balloon.destPosY, -1);
                    Balloon.makeMore = false;
                }

                if (Balloon.gameOver)
                {
                    // ukoliko je igra gotova, zaustavljamo timere i pokazujemo labele
                    moveTimer.Stop();
                    moveTimer.Dispose();

                    this.lblGameOver.Enabled = true;
                    this.lblGameOver.Show();
                }

                if (Balloon.finished)
                {
                    moveTimer.Stop();
                    moveTimer.Dispose();
                    this.congrats.Enabled = true;
                    this.congrats.Show();
                }

                this.lblScoreVal.Text = Convert.ToString(score);
            
        }

        // funkcije za input
        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                moveLeft = true;
                this.Player1.Image = Properties.Resources.moveLeft;
                this.Player1.SizeMode = PictureBoxSizeMode.CenterImage;

            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = true;
                this.Player1.Image = Properties.Resources.moveRight;
                this.Player1.SizeMode = PictureBoxSizeMode.CenterImage;

            }
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = false;
                this.Player1.Image = Properties.Resources.backturned;
                this.Player1.SizeMode = PictureBoxSizeMode.CenterImage;


            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = false;
                this.Player1.Image = Properties.Resources.backturned;
                this.Player1.SizeMode = PictureBoxSizeMode.CenterImage;

            }

            if(e.KeyCode == Keys.Space && !Balloon.gameOver)
            {
                if(beginGame && !Balloon.finished && Balloon.harpoon == null)
                    ShootHarpoon();
            }

            if(e.KeyCode == Keys.Escape &&  (Balloon.gameOver || timeExpired))
            {
                this.Close();
            }

            if(e.KeyCode == Keys.E)
            {
                // MakeBalloon(level, 150, 100,1);
                if (!this.beginGame)
                {
                    this.timeExpired = true;
                    this.beginGame = true;
                    this.lblBegin.Visible = false;
                    this.timeExpired = false;
                    MakeBalloon(level, 250, 100, -1); // prvi balon
                    MakeBalloon(level, 500, 100, 1); // drugi balon
                    MakeBalloon(level, 750, 100, 1); // treci balon
                    ///MakeBalloon(level, 800, 100, 1); // cetvrti balon
                    Balloon.count = ((int)Math.Pow(2, level) - 1)*3; // racunamo koliko je ukupno balona u igri
                    this.countdownTimer.Enabled = true;
                    this.moveTimer.Enabled = true;
                }else
                {   /*
                    MakeBalloon(level, 150, 100, 1);
                    Balloon.count += ((int)Math.Pow(2, level) - 1); // novi balon
                    */
                }
            }
        }

        private void ShootHarpoon()
        {   
            // pravi novi harpun, dodaje mu koordinate i poziva metodu za prikazivanje na ekranu
            Harpoon shootHarpoon = new Harpoon(this);
            shootHarpoon.harpoonLeft = Player1.Left + Player1.Width / 2;
            shootHarpoon.harpoonTop = Player1.Top;
            int len = this.Height - (ceilingWall.Height + bottomWall.Height);
            shootHarpoon.MakeHarpoon(this, len);
        }

        private void MakeBalloon(int level,int xPos,int yPos, int dir)
        {
            // novi balon, i prikazuje ga
            Balloon bal = new Balloon(this, level);
            bal.balloonLeft = xPos;
            bal.balloonTop = yPos;
            bal.dir = dir;
            bal.ShowBalloon(this);

            
        }

        public void Player1_Click()
        {

        }

        public PictureBox getCeiling()
        {
                return this.ceilingWall;
        }

        public PictureBox getLeft()
        {
            return this.leftWall;
        }

        public PictureBox getRight()
        {
            return this.rightWall;
        }

        public PictureBox getPlayer()
        {
            return this.Player1;
        }

        private void countdownTimerEvent(object sender, EventArgs e)
        {
                if (timeLeft > 0 && !Balloon.gameOver && !Balloon.finished)
                {
                    timeLeft--;
                    this.timeRemaining.Value = timeLeft;
                    this.timeRemainingVal.Text = Convert.ToString(timeLeft);

                }
                else if (Balloon.finished && timeLeft > 0)
                {
                    this.countdownTimer.Interval = 20;
                    timeLeft--;
                    this.timeRemaining.Value = timeLeft;
                    score += timeLeft*10;
                    this.lblScoreVal.Text = Convert.ToString(score);

                }
                else
                {
                    countdownTimer.Stop();
                    this.timeExpired = true;

                    // upisivanje u fajl
                    Write_Highscore();

                }
            
        }

        private void Write_Highscore()
        {
            InsertUsername insr = new InsertUsername();
            insr.ShowDialog();
            string username = InsertUsername.username;

            Load_Scores();

            this.scoreList.Add(new PlayerScore(username, score));

            List<PlayerScore> SortedList = this.scoreList.OrderByDescending(o => o.score).ToList();

            TextWriter tw = new StreamWriter("highscore.txt");
            
            for(int i = 0; i < SortedList.Count; i++)
            {
                tw.WriteLine(SortedList[i].username + "\t" + SortedList[i].score);
            }

            tw.Close();
        }

        private void Load_Scores()
        {
            FileInfo finfo = new FileInfo("highscore.txt");

            if (!finfo.Exists)
            {
                File.Create("highscore.txt");
            }

            System.IO.StreamReader sr = new StreamReader("highscore.txt");
            if (sr == null) return;

            this.scoreList = new List<PlayerScore>();

            
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] entry = line.Split(new string[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);
                if (entry[0] != null) ;
                this.scoreList.Add(new PlayerScore(entry[0], Convert.ToInt32(entry[1])));
            }

            sr.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.UserPaint |
            ControlStyles.DoubleBuffer,
            true);
        }

        public PictureBox getBottom()
        {
            return this.bottomWall;
        }



    }
}
