﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shapes
{
    sealed internal class Triangle : Shape
    {
        Point[] vertexes = new Point[3];
        double area;
        public Triangle(int x, int y)
        {
            this.x = x;
            this.y = y;
            CalculateVertexes();
            CalculateArea();
        }

        static Triangle()
        {
            radius = 20;
            color = Color.Green;
        }

        private void CalculateVertexes()
        {
            // calculating left bottom vertex
            vertexes[0] = new Point(x - Convert.ToInt32(Math.Sqrt(radius * radius - (radius / 2) * (radius / 2))), y + radius / 2);

            // calculating middle upper vertex
            vertexes[1] = new Point(x, y - radius);

            // calculatin right bottom vertex
            vertexes[2] = new Point(x + Convert.ToInt32(Math.Sqrt(radius * radius - (radius / 2) * (radius / 2))), y + radius / 2);
        }

        // area is calculated by heron formula
        private void CalculateArea()
        {
            area = Math.Round(Utilities.HeronFormula(Utilities.DistanceBetweenPoints(vertexes[0].X, vertexes[0].Y, vertexes[1].X, vertexes[1].Y),
                Utilities.DistanceBetweenPoints(vertexes[1].X, vertexes[1].Y, vertexes[2].X, vertexes[2].Y),
                Utilities.DistanceBetweenPoints(vertexes[2].X, vertexes[2].Y, vertexes[0].X, vertexes[0].Y)));
        }

        public override void Draw(Graphics g)
        {
            CalculateVertexes();
            Brush brush = new SolidBrush(color);
            Pen pen = new Pen(color, 2);
            g.DrawPolygon(pen, vertexes);
        }

        //checking if triangle area == area of every triangle where vertexes are mouseCoords and 2 other triangle vertexes
        public override bool IsInside(int mouseX, int mouseY)
        {
            double condArea = 0;
            for (int i = 0; i < vertexes.Length; i++)
            {
                int k = (i + 1) % 3; //to calculate area for points 0-1, 1-2, 2-0
                condArea += Utilities.HeronFormula(Utilities.DistanceBetweenPoints(vertexes[i].X, vertexes[i].Y, vertexes[k].X, vertexes[k].Y),
                Utilities.DistanceBetweenPoints(vertexes[i].X, vertexes[i].Y, mouseX, mouseY),
                Utilities.DistanceBetweenPoints(vertexes[k].X, vertexes[k].Y, mouseX, mouseY));
            }
            if (Math.Round(condArea) == area)
                return true;
            return false;
        }
    }
}
