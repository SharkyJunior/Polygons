using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    
    sealed internal class Square : Shape
    {
        static float rectSide;
        public Square(int x, int y) 
        {
            this.x = x;
            this.y = y;
        }

        static Square()
        {
            radius = 20;
            color = Color.Green;
            rectSide = (float)(radius * Math.Sin(Utilities.ToRadians(45)) * 2);
        }

        public override void Draw(Graphics g)
        {
            if (!isTemporary)
            {
                Brush brush = new SolidBrush(color);
                Pen pen = new Pen(color, 2);
                g.DrawRectangle(pen, x - rectSide / 2, y - rectSide / 2, rectSide, rectSide);
                g.FillRectangle(brush, x - rectSide / 2, y - rectSide / 2, rectSide, rectSide);
            }
        }

        public override bool IsInside(int mouseX, int mouseY)
        {
            if (Math.Abs(mouseX - x) <= rectSide / 2 && Math.Abs(mouseY - y) <= rectSide / 2)
                return true;
            return false;
        }
    } 
}
