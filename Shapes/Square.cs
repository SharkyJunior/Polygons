using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    
    sealed public class Square : Shape
    {
        static float rectSide;

        public Square()
        {
            this.X = 100;
            this.Y = 100;
        }
        public Square(int x, int y) 
        {
            this.X = x;
            this.Y = y;
        }

        static Square()
        {
            radius = 10;
            color = Color.ForestGreen;
            rectSide = (float)(radius * Math.Sin(Utilities.ToRadians(45)) * 2);
        }

        public override Shape Copy()
        {
            return CopyTo(new Square());
        }

        public override void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(color);
            Pen pen = new Pen(color, 2);
            rectSide = (float)(radius * Math.Sin(Utilities.ToRadians(45)) * 2);
            g.FillRectangle(new SolidBrush(Color.FromArgb(192, color)), X - rectSide / 2, Y - rectSide / 2, rectSide, rectSide);
            g.DrawRectangle(pen, X - rectSide / 2, Y - rectSide / 2, rectSide, rectSide);
        }

        public override bool IsInside(int mouseX, int mouseY)
        {
            if (Math.Abs(mouseX - X) <= rectSide / 2 && Math.Abs(mouseY - Y) <= rectSide / 2)
                return true;
            return false;
        }
    } 
}
