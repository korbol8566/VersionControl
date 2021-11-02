using IRF_Patterns_1031.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_Patterns_1031.Entities
{
    class Present : Toy
    {
        public Present()
        {
        }

        public Present(Color ribbon, Color box)
        {

        }
        protected override void DrawImage(Graphics graphics)
        {
            Image imageFile = Image.FromFile("Images/gift-png-icon-12.jpg");
            graphics.DrawImage(imageFile, new Rectangle(0, 0, Width, Height));
        }
    }
}
