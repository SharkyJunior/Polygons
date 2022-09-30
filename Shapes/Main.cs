using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        bool isDynamic = false;
        string FILE_PATH = null;


        private int vertexRadius = 10;

        public int VertexRadius
        {
            get => vertexRadius;
            set => vertexRadius = value;
        }

        Color linesColor = Color.OliveDrab;
        Color innerColor = Color.Honeydew;
        Color vertexesColor = Color.ForestGreen;
        Graphics g;

        Random random = new Random();

        public Main()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Shape.radius = vertexRadius;
            
            if (shapes.Count > 0)
                playButton.Enabled = true;
            else playButton.Enabled = false;

            if (shapes.Count > 2)
            {
                List<Point> hull = Utilities.ConvertShapesToPoints(Utilities.GrahamScan(shapes));
                g.FillPolygon(new SolidBrush(innerColor), hull.ToArray());
                g.DrawPolygon(new Pen(linesColor, 2), hull.ToArray());
                
            }
            foreach (Shape shape in shapes)
            {
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
                        if (!Utilities.GrahamScan(ref shapes).Contains(newShape))
                        {
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
                foreach (Shape shape in shapes)
                {
                    if (shape.IsInside(e.X, e.Y))
                    {
                        shapes.Remove(shape);
                        break;
                    }
                }
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
                Utilities.GrahamScan(ref shapes);
            }
            Refresh();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                foreach (Shape shape in shapes)
                    if (shape.isDragged)
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
                vertexesColor = colorDialog.Color;
                foreach (Shape shape in shapes)
                    Shape.color = colorDialog.Color;
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

        private async void RandomShapeMovements()
        {
            while (isDynamic)
            {
                foreach(Shape shape in shapes)
                {
                    shape.X += random.Next(-5, 5);
                    shape.Y += random.Next(-5, 5);
                }
                Utilities.GrahamScan(ref shapes);
                Refresh();
                await Task.Delay(100);
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            playButton.Enabled = false;
            stopButton.Enabled = true;
            isDynamic = true;
            RandomShapeMovements();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            playButton.Enabled = true;
            stopButton.Enabled = false;
            isDynamic = false;
        }

        private void vertexRadiusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RadiusSliderForm radiusSliderForm = new RadiusSliderForm(this);
            radiusSliderForm.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlgRes = DialogResult.Cancel;
            if (FILE_PATH == null)
            {
                dlgRes = MessageBox.Show("Do you want to save changes?", "Polygons", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                switch (dlgRes)
                {
                    case DialogResult.Yes:
                        FILE_PATH = CallSaveWindow();
                        shapes.Clear();
                        FILE_PATH = null;
                        Refresh();
                        break;
                    case DialogResult.No:
                        shapes.Clear();
                        FILE_PATH = null;
                        Refresh();
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
            else
            {
                shapes.Clear();
                Refresh();
                FILE_PATH = null;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FILE_PATH == null)
            {
                DialogResult dlgRes = DialogResult.No;
                dlgRes = MessageBox.Show("Do you want to save changes?", "Polygons", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (dlgRes)
                {
                    case DialogResult.Yes:
                        FILE_PATH = CallSaveWindow();
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            else
            {
                try
                {
                    XmlOperations.SaveToXml(FILE_PATH, new SaveLoadFormat(shapes, innerColor, linesColor, vertexesColor, vertexRadius));
                }
                catch
                {
                    DialogResult dlgRes = DialogResult.No;
                    dlgRes = MessageBox.Show("Do you want to save changes?", "Polygons", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    switch (dlgRes)
                    {
                        case DialogResult.Yes:
                            FILE_PATH = CallSaveWindow();
                            break;
                        case DialogResult.No:
                            break;
                    }
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FILE_PATH = CallSaveWindow();
        }

        private string CallSaveWindow()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "polygon files (*.polygon)|*.polygon";
            saveFileDialog.DefaultExt = "polygon";
            saveFileDialog.AddExtension = true;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlOperations.SaveToXml(saveFileDialog.FileName, new SaveLoadFormat(shapes, innerColor, linesColor, vertexesColor, vertexRadius));
                return saveFileDialog.FileName;
            }
            return null;
        }

    }
}
