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

namespace BubbleTrouble
{
    public partial class Scoreboard : Form
    {
        List<PlayerScore> scoreList;
        public Scoreboard()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.scoreboard;
            this.lblTitle.BackColor = Color.Transparent;
            this.tblLayout.BackColor = Color.Transparent;

        }

        private void Scoreboard_Load(object sender, EventArgs e)
        {
            FileInfo finfo = new FileInfo("highscore.txt");

            if (!finfo.Exists || finfo.Length == 0)
            {
                
                MessageBox.Show("Scoreboard is empty");
                this.Dispose();
                return;
            }

            System.IO.StreamReader sr = new StreamReader("highscore.txt");

            this.scoreList = new List<PlayerScore>();

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] entry = line.Split(new string[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);
                this.scoreList.Add(new PlayerScore(entry[0], Convert.ToInt32(entry[1])));
                
            }
            int k = Math.Min(this.tblLayout.RowCount, this.scoreList.Count);

            for (int i = 0; i < k; i++)
            {
                for(int j = 0; j < this.tblLayout.ColumnCount; j++)
                {
                    Control c = this.tblLayout.GetControlFromPosition(j, i);
                    if (j % 2 == 0)
                    {
                        c.Text = this.scoreList[i].username;
                    }
                    else
                    {
                        c.Text = Convert.ToString(this.scoreList[i].score);
                    }
                }
            }

            sr.Close();

        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
