using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleTrouble
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.brickWall;
            this.pboxTorch1.BackColor = Color.Transparent;
            this.pboxTorch2.BackColor = Color.Transparent;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Balloon.gameOver = false;
            f1.timeExpired = false;
            Balloon.finished = false;
            Form1.score = 0;
            f1.ShowDialog();
            
        }

        private void pboxTorch1_Click(object sender, EventArgs e)
        {

        }

        private void btnScoreboard_Click(object sender, EventArgs e)
        {
            Scoreboard sb = new Scoreboard();
            sb.ShowDialog();
        }
    }
}
