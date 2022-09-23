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
        public int offsetX, offsetY;
        protected static int radius;
        protected static Color color;

        public int X => x;
        public int Y => y;

        public abstract void Draw(Graphics g);

        public abstract bool IsInside(int mouseX, int mouseY);

        public abstract void UpdatePosition(int newMouseX, int newMouseY);
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
            g.DrawEllipse(pen, x - radius, y - radius, radius * 2, radius * 2); 
        }

        public override bool IsInside(int mouseX, int mouseY)
        {
            if (Math.Sqrt(Math.Abs(x - mouseX) * Math.Abs(x - mouseX) + Math.Abs(y - mouseY) * Math.Abs(y - mouseY)) <= radius)
            {
                return true;
            }
            return false;
        }

        public override void UpdatePosition(int newMouseX, int newMouseY)
        {
            x = newMouseX - offsetX;
            y = newMouseY - offsetY;
        }
    }
}
