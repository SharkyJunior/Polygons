using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shapes
{
    sealed internal class Triangle : Shape //TODO: finish triangle with heron formula
    {
        public Triangle(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        static Triangle()
        {
            radius = 20;
            color = Color.Green;
        }
    }
}
