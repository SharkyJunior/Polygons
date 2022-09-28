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
    public partial class Main : Form
    {
        List<Shape> shapes = new List<Shape>();
        bool isDragging = false;
        Color linesColor = Color.Red;
        Color innerColor = Color.Beige;
        Graphics g;

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (shapes.Count > 2)
            {
                List<Point> hull = Utilities.ConvertShapesToPoints(Utilities.GrahamScan(shapes));
                g.FillPolygon(new SolidBrush(innerColor), hull.ToArray());
                g.DrawPolygon(new Pen(linesColor), hull.ToArray());
                
            }
            foreach (Shape shape in shapes)
            {
                if (!shape.isTemporary)
                    shape.Draw(g);
            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
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
                {
                    Shape newShape = null;
                    switch (ShapeSelectionComboBox.SelectedItem)
                    {
                        case "Circle":
                            newShape = new Circle(e.X, e.Y);
                            shapes.Add(newShape);
                            break;
                        case "Square":
                            newShape = new Square(e.X, e.Y);
                            shapes.Add(newShape);
                            break;
                        case "Triangle":
                            newShape = new Triangle(e.X, e.Y);
                            shapes.Add(newShape);
                            break;
                        default:
                            MessageBox.Show("Unknown shape. Please select a shape.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                    if (shapes.Count > 2)
                    {
                        if (!Utilities.GrahamScan(shapes).Contains(newShape))
                        {
                            shapes[shapes.Count - 1].isTemporary = true;
                            isDragging = true;
                            foreach (Shape shape in shapes)
                            {
                                shape.isDragged = true;
                                shape.offsetX = e.X - shape.X;
                                shape.offsetY = e.Y - shape.Y;
                            }
                        }
                    }
                    Refresh();
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                shapes.Remove(shapes.Last());
                Refresh();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            foreach (Shape shape in shapes)
                shape.isDragged = false;
            if (shapes.Count > 2)
            {
                shapes = Utilities.GrahamScan(shapes);
            }
            Refresh();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                foreach (Shape shape in shapes)
                    if(shape.isDragged)
                        shape.UpdatePosition(e.X, e.Y);
                Invalidate();
            }
        }

        private void vertexesColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.ShowHelp = true;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (Shape shape in shapes)
                    shape.Color = colorDialog.Color;
            }
            Refresh();
        }

        private void linesColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.ShowHelp = true;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                linesColor = colorDialog.Color;
            }
            Refresh();
        }

        private void innerAreaColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.ShowHelp = true;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                innerColor = colorDialog.Color;
            }
            Refresh();
        }
    }
}
