using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    sealed internal class Circle : Shape
    {
        public Circle(int x, int y)
        {
            this.x = x;
            this.y = y;
            isDragged = false;
        }

        static Circle()
        {
            radius = 20;
            color = Color.Green;
        }

        public override void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(color);
            Pen pen = new Pen(color, 2);
            g.DrawEllipse(pen, x - radius, y - radius, radius * 2, radius * 2);
        }

        public override bool IsInside(int mouseX, int mouseY)
        {
            //Math.Sqrt(Math.Abs(x - mouseX) * Math.Abs(x - mouseX) + Math.Abs(y - mouseY) * Math.Abs(y - mouseY))
            if (Utilities.DistanceBetweenPoints(x, y, mouseX, mouseY) <= radius)
            {
                return true;
            }
            return false;
        }
    }
}
