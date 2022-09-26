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

        public Square(int x, int y) 
        {
            this.x = x;
            this.y = y;
        }

        static Square()
        {
            radius = 20;
            color = Color.Green;
        }

        public override void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(color);
            Pen pen = new Pen(color, 5);
            g.DrawRectangle(pen, radius * Math.Sin(U))
        }
    }
}
