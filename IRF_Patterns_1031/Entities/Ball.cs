using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using IRF_Patterns_1031.Abstractions;

namespace IRF_Patterns_1031.Entities
{
    public class Ball: Toy
    {
        public SolidBrush BallColor { get; private set; }
        public Ball(Color color)
        {
            // el kéne olvasni a feladat leírását...
            BallColor = new SolidBrush(color);
            AutoSize = false;
            Height = Width = 50;
            Paint += Ball_Paint;
        }

        private void Ball_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        protected override void DrawImage(Graphics g)
        {
            g.FillEllipse(BallColor, 0, 0, Width, Height);
        }

        public void MoveBall()
        {
            Left += 1;
        }
    }
}
