using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Shapes
{
    sealed public class Circle : Shape
    {
        public Circle()
        {
            this.X = 100;
            this.Y = 100;
        }
        public Circle(int x, int y)
        {
            this.X = x;
            this.Y = y;
            isDragged = false;
        }

        static Circle()
        {
            radius = 10;
            color = Color.ForestGreen;
        }

        public override void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(color);
            Pen pen = new Pen(color, 2);
            g.FillEllipse(new SolidBrush(Color.FromArgb(192, color)), X - radius, Y - radius, radius * 2, radius * 2);
            g.DrawEllipse(pen, X - radius, Y - radius, radius * 2, radius * 2);
        }

        public override Shape Copy()
        {
            return CopyTo(new Circle());
        }

        public override bool IsInside(int mouseX, int mouseY)
        {
            //Math.Sqrt(Math.Abs(x - mouseX) * Math.Abs(x - mouseX) + Math.Abs(y - mouseY) * Math.Abs(y - mouseY))
            if (Utilities.DistanceBetweenPoints(X, Y, mouseX, mouseY) <= radius)
            {
                return true;
            }
            return false;
        }
    }
}
