using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IRF_Patterns_1031.Abstractions
{
    public abstract class Toy:Label
    {
        public Toy()
        {
            // el kéne olvasni a feladat leírását...
            AutoSize = false;
            Height = Width = 50;
            Paint += Toy_Paint;
        }

        private void Toy_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        protected abstract void DrawImage(Graphics graphics);       

        public virtual void MoveToy()
        {
            Left += 1;
        }
    }
}
