using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shapes
{
    internal abstract class Shape
    {
        protected int x, y;
        protected static int radius;
        protected static Color color;

        public abstract void Draw(Graphics g);

        public abstract bool IsInside(int mouseX, int mouseY);
    }

    internal class Circle : Shape
    {
        public Circle(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        static Circle()
        {
            radius = 20;
            color = Color.Green;
        }
        public override void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(color);
            Pen pen = new Pen(color, 5);
            g.DrawLine(pen, x, y, x + radius, y + radius);
            g.DrawEllipse(pen, 100, 100, radius, radius); //x - radius, y - radius, radius, radius
        }

        public override bool IsInside(int mouseX, int mouseY)
        {
            return true; //TODO: make isInside
        }
    }
}
