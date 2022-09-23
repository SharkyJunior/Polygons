using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{
    public partial class Form1 : Form
    {
        List<Shape> shapes = new List<Shape>();
        List<Shape> draggedShapes = new List<Shape>();
        bool isDragging = false;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Shape shape in shapes)
            {
                shape.Draw(g);
            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            g = CreateGraphics();
            if (e.Button == MouseButtons.Left)
            {
                foreach (Shape shape in shapes)
                {
                    if (shape.IsInside(e.X, e.Y))
                    {
                        isDragging = true;
                        shape.offsetX = e.X - shape.X;
                        shape.offsetY = e.Y - shape.Y;
                        draggedShapes.Add(shape);
                    }
                }
                if (!isDragging)
                    shapes.Add(new Circle(e.X, e.Y));
            }
            else if (e.Button == MouseButtons.Right)
                shapes.Remove(shapes.Last());

            Invalidate();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            draggedShapes.Clear();
            Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                foreach (Shape shape in draggedShapes)
                    shape.UpdatePosition(e.X, e.Y);
                Invalidate();
            }
            
        }
    }
}
