using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace BubbleTrouble
{
    class RoundPB : PictureBox
    {
        int radius;

        public RoundPB(int radius)
        {
            this.radius = radius;
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath grpath = new GraphicsPath();
            grpath.AddEllipse(0, 0, radius, radius);
            this.Region = new System.Drawing.Region(grpath);

            base.OnPaint(pe);
        }

    }
}
