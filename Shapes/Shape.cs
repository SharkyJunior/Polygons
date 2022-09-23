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
        static int radius;
        static Color color;

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

        }
        public override void Draw(Graphics g)
        {
            
        }
    }
}
