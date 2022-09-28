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
        public bool isDragged;
        public bool isTemporary;

        public int X => x;
        public int Y => y;

        public Color Color
        {
            get => color;
            set { color = value; }
        }

        public abstract void Draw(Graphics g);

        public abstract bool IsInside(int mouseX, int mouseY);

        public virtual void UpdatePosition(int newMouseX, int newMouseY)
        {
            x = newMouseX - offsetX;
            y = newMouseY - offsetY;
        }
    }
}
