using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BubbleTrouble
{
    class Balloon
    {
        int speedX = 4; // brzina kretanja balona
        int speedY = 0; // koristim 2 promjenljive, jednu za gore dolje, drugu za lijevo desno
        bool ind = false;// govori da li se frame preskocio, tj da li je doslo do promjene pravca lopte
        int tempSpeed = 0; // sluzi da upamti vrijednost speedY u frameu koji se preskace
        
        int maxHeight; // maksimalna visina koju balon moze da dostigne
        RoundPB balloon; // potrebno za pravljenje okruglog pictureboxa
        public int balloonLeft; // unose se kad se objekat instancira
        public int balloonTop; // 
        public int dir; // pravac nove lopte

        int level; // nivo na kom se balon nalazi
        int radius; // precnik balona
        Form1 form1; // ****moze biti korisno
        public static int destPosX, destPosY; // pozicija na kojoj se balon nalazio kada je unisten

        PictureBox ceiling,left,right,bottom; // ivice zidova
        public static PictureBox harpoon; // harpun
        public static bool destroy = false; // promjenljiva koja govori da je potrebno unistiti harpun
        public static bool makeMore = false; // promjenljiva koja govori da je moguce napraviti manjih balona
        private Timer balloonTimer = new Timer(); // tajmer za kretanje balona
        public static int toMake; // nivo balona koji treba napraviti
        public static bool gameOver = false; // kaze da je balon udario igraca
        public static int count = 0; // ukupan broj balona
        public static bool finished = false; // ubrzava timer i izbacuje congratulations


        public Balloon(Form1 form1, int level)
        {
            this.form1 = form1;
            this.ceiling = form1.getCeiling();
            this.bottom = form1.getBottom();
            this.left = form1.getLeft();
            this.right = form1.getRight();
            this.level = level;
            this.radius = level * 25;
            this.balloon = new RoundPB(radius);

            
        }

        public void ShowBalloon(Form form)
        {
            balloon.BackColor = Color.Red;
            balloon.Left = this.balloonLeft; // x koordinata
            balloon.Top = this.balloonTop; // y koordinata
            balloon.Tag = "balloon";
            balloon.Size = new Size(radius, radius); // pravimo balon
            /**balloon.Image = Properties.Resources.gameBalloon1;
            balloon.SizeMode = PictureBoxSizeMode.CenterImage;**/

            this.maxHeight = 100 + (3 - level) * 50; // racunamo maksimalnu visinu koji balon moze da dostigne zavisno od nivoa 
            
            this.speedX *= dir; // postavljamo da se jedan balon krece lijevo a drugi desno
            form.Controls.Add(balloon);

            balloonTimer.Interval = 20; // interval timera
            balloonTimer.Tick += new EventHandler(BalloonTimerEvent); // dodajemo event koji se desaava svaki tick
            balloonTimer.Start(); // zapocinjemo timer
        }

        private void BalloonTimerEvent(object sender, EventArgs e)
        {
            if (!ind)
            {
                // ako je udario u neki zid, balon mijenja pravac
                balloon.Left += speedX;
                if (balloon.Left <= this.left.Width || balloon.Left + radius + Convert.ToInt32(radius/3) >= (form1.Size.Width - this.right.Width))
                    speedX = -speedX;

                // ako udari dolje ili gore, mijenja pravac
                balloon.Top += speedY;
                if (balloon.Top + balloon.Size.Height + Convert.ToInt32(radius / 2) > (form1.Size.Height - this.bottom.Height) || balloon.Top == maxHeight)
                {
                    // 
                    this.ind = true;
                    this.tempSpeed = speedY;
                    speedY = -speedY;

                }

                speedY++;
                
            }
            else
            {
                // ovdje ulazi kada je jedan frame "preskocen", tj kada balon promijeni pravac, i ne stigne da se promijeni vrijednost brzine u trenutku promjene pravca
                balloon.Left += speedX;
                if (balloon.Left <= this.left.Width || balloon.Left + radius + Convert.ToInt32(radius / 3) >= (form1.Size.Width - this.right.Width))
                    speedX = -speedX;

                balloon.Top -= this.tempSpeed;
                this.ind = false; // vracamo u normalan pravac
            }

            // ako je harpun pogodio balon, postavlja odgovarajuce promjenljive za nestanak harpuna i pravljenje manjih balona
            if (harpoon != null && balloon.Bounds.IntersectsWith(harpoon.Bounds))
            {
                form1.sound.Play();
                destPosX = balloon.Left;
                destPosY = maxHeight;

                if (this.level > 1)
                {
                    // ako nije prvi nivo, napravi nove, manje balone
                    toMake = this.level;
                    destPosY = 100 + (3 - level + 1) * 50;
                    makeMore = true;
                }
                count--;
                Form1.score += radius * 100;
                destroy = true;
                Cleanup();
                

                
            }

            // ako je balon udario igraca, zavrsi igru
            if ((balloon != null && balloon.Bounds.IntersectsWith(form1.getPlayer().Bounds)) || form1.timeExpired)
            {
                Cleanup();
                gameOver = true;
            }

            // ako je igrac probusio sve balone, zavrsi igru
            if(count == 0)
            { 
                finished = true;
            }
            

        }

        private void Cleanup()
        {
            // funkcija za gasenje timera i brisanje balona
            balloonTimer.Stop();
            balloonTimer.Dispose();

            balloon.Dispose();
            

            balloonTimer = null;
            balloon = null;
        }
        
    }
}
