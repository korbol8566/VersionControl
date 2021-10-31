using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IRF_Patterns_1031.Entities
{
    public class Ball:Label
    {
        public Ball()
        {
            // el kéne olvasni a feladat leírását...
            AutoSize = false;
            Height = Width = 50;
            Paint += Ball_Paint;
        }

        private void Ball_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        protected void DrawImage(Graphics graphics)
        {
            graphics.FillEllipse(new SolidBrush(Color.Red),0,0,Width,Height);
        }

        public void MoveBall()
        {
            Left += 1;
        }
    }
}
