using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BubbleTrouble
{
    class Harpoon
    {

        int speed = 5;
        public int harpoonLeft;
        public int harpoonTop;
        PictureBox ceilingWall;

        PictureBox harpoon = new PictureBox();
        private Timer harpoonTimer = new Timer();
        
        
        public Harpoon(Form1 form1)
        {
            this.ceilingWall = form1.getCeiling();
        }

        public void MakeHarpoon(Form form,int len)
        {
            if (Balloon.harpoon == null)
            {
                harpoon.BackColor = Color.Transparent;
                harpoon.Image = Properties.Resources.chain;
                harpoon.SizeMode = PictureBoxSizeMode.StretchImage;
                harpoon.Size = new Size(5, len);
                harpoon.Tag = "harpoon";
                harpoon.Left = harpoonLeft;
                harpoon.Top = harpoonTop;

                form.Controls.Add(harpoon);

                Balloon.harpoon = harpoon;
                harpoonTimer.Interval = speed;
                harpoonTimer.Tick += new EventHandler(HarpoonTimerEvent);
                harpoonTimer.Start();
            }
        }

        private void HarpoonTimerEvent(object sender, EventArgs e) 
        {
            harpoon.Top -= speed;
            
            if (harpoon.Bounds.IntersectsWith(ceilingWall.Bounds)){
                RemoveHarpoon();
                Balloon.harpoon = null;
            }

            if (Balloon.destroy)
            {
                try
                {
                    RemoveHarpoon();
                }catch(Exception ex)
                {

                }

                Balloon.harpoon = null;
                Balloon.destroy = false;
            }
        }

        private void RemoveHarpoon()
        {
            harpoonTimer.Stop();
            harpoonTimer.Dispose();
            harpoon.Dispose();

            harpoonTimer = null;
            harpoon = null;
        }
    }


}
