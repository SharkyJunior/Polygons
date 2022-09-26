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
                        shape.isDragged = true;
                        isDragging = true;
                        shape.offsetX = e.X - shape.X;
                        shape.offsetY = e.Y - shape.Y;
                    }
                }
                if (!isDragging)
                    shapes.Add(new Circle(e.X, e.Y));
            }
            else if (e.Button == MouseButtons.Right)
                shapes.Remove(shapes.Last());

            Refresh();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            foreach (Shape shape in shapes) 
                shape.isDragged = false;
            Refresh();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                foreach (Shape shape in shapes)
                    if(shape.isDragged)
                        shape.UpdatePosition(e.X, e.Y);
                Refresh();
            }
            
        }
    }
}
