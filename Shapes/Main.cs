﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        #region Fields

        List<Shape> shapes;
        bool isDragging, isDynamic, isSaved;
        string FILE_PATH;
        const string FILE_FILTER = "polygon files (*.polygon)|*.polygon";
        Buffer buffer; 

        public int vertexRadius { get; set; }

        Color linesColor, innerColor, vertexesColor;

        Random random;

        RadiusSliderForm radiusSliderForm;

        #endregion

        #region Constructor
        public Main()
        {
            InitializeComponent();

            shapes = new List<Shape>();
            KeyPreview = true;
            buffer = new Buffer();
            linesColor = Color.OliveDrab;
            innerColor = Color.Honeydew;
            vertexesColor = Color.FromArgb(192, Color.ForestGreen);
            vertexRadius = 10;
            isDragging = false;
            isDynamic = false;
            isSaved = false;
            FILE_PATH = null;
            random = new Random();
            radiusSliderForm = new RadiusSliderForm(this);

            SaveCurrentState();
            UpdateTitle(false);
            Refresh();
        }

        #endregion Constructor
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (var g = CreateGraphics())
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                Shape.radius = vertexRadius;
                Shape.color = vertexesColor;

                if (shapes.Count > 0 && !isDynamic)
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

                UpdateTitle(false);
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
                    if (circleToolStripMenuItem.Checked) 
                    {
                        newShape = new Circle(e.X, e.Y);
                        shapes.Add(newShape); 
                    }
                    else if (squareToolStripMenuItem.Checked)
                    {
                        newShape = new Square(e.X, e.Y);
                        shapes.Add(newShape);
                    }
                    else if (triangleToolStripMenuItem.Checked)
                    {
                        newShape = new Triangle(e.X, e.Y);
                        shapes.Add(newShape);
                    }
                    else
                        MessageBox.Show("Unknown shape. Please select a shape.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    if (shapes.Count > 2 && newShape != null)
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
            //Debug.WriteLine("mouse up");
            if (!isDynamic)
                SaveCurrentState();
            isDragging = false;
            foreach (Shape shape in shapes)
                shape.isDragged = false;
            if (shapes.Count > 2)
                Utilities.GrahamScan(ref shapes);
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

        #region Colors
        private void vertexesColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.ShowHelp = true;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
               SaveCurrentState();
               vertexesColor = colorDialog.Color;
               SaveCurrentState();
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
                SaveCurrentState();
                linesColor = colorDialog.Color;
                SaveCurrentState();
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
                SaveCurrentState();
                innerColor = colorDialog.Color;
                SaveCurrentState();
            } 
            Refresh();
        }

        #endregion Colors

        #region Dynamics
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
                await Task.Delay(50);
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
            SaveCurrentState();
            playButton.Enabled = true;
            stopButton.Enabled = false;
            isDynamic = false;
        }
        #endregion Dynamics

        private void vertexRadiusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (radiusSliderForm.IsDisposed == true)
                radiusSliderForm = new RadiusSliderForm(this);

            radiusSliderForm.Show();
            radiusSliderForm.WindowState = FormWindowState.Normal;
            radiusSliderForm.Select();
        }

        //TODO: refactor newFileEvent
        #region SaveLoad 
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlgRes = DialogResult.Cancel;
            if (FILE_PATH == null)
            {
                dlgRes = MessageBox.Show("Do you want to save changes?", "Polygons", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                switch (dlgRes)
                {
                    case DialogResult.Yes:
                        DialogResult saveDlg = CallSaveWindow();
                        if (saveDlg == DialogResult.OK)
                            ResetPolygon();
                        Refresh();
                        break;
                    case DialogResult.No:
                        ResetPolygon();
                        Refresh();
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
            else if (!isSaved && FILE_PATH != null)
            {
                dlgRes = MessageBox.Show("Do you want to save changes?", "Polygons", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                switch (dlgRes)
                {
                    case DialogResult.Yes:
                        XmlOperations.SaveToXml(FILE_PATH, new PolygonData(shapes, innerColor, linesColor, vertexesColor, vertexRadius));
                        ResetPolygon();
                        Refresh();
                        break;
                    case DialogResult.No:
                        ResetPolygon();
                        Refresh();
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
            else
            {
                ResetPolygon();
                Refresh();
            }
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
                        DialogResult dr = CallSaveWindow();
                        if (dr == DialogResult.OK)
                            UpdateTitle(true);
                        else
                            UpdateTitle(false);
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            else
            {
                try
                {
                    XmlOperations.SaveToXml(FILE_PATH, new PolygonData(shapes, innerColor, linesColor, vertexesColor, vertexRadius));
                    UpdateTitle(true);
                }
                catch
                {
                    DialogResult dlgRes = DialogResult.No;
                    dlgRes = MessageBox.Show("Do you want to save changes?", "Polygons", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    switch (dlgRes)
                    {
                        case DialogResult.Yes:
                            DialogResult dr = CallSaveWindow();
                            if (dr == DialogResult.OK)
                                UpdateTitle(true);
                            else
                                UpdateTitle(false);
                            break;
                        case DialogResult.No:
                            break;
                    }
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallSaveWindow();
            UpdateTitle(true);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = FILE_FILTER;
                openFileDialog.DefaultExt = "polygon";
                openFileDialog.AddExtension = true;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PolygonData save = XmlOperations.LoadFromXml(openFileDialog.FileName);
                    FILE_PATH = openFileDialog.FileName;
                    shapes = Utilities.CopyFrom(save.Shapes);
                    innerColor = save.InnerColor;
                    linesColor = save.LinesColor;
                    vertexesColor = save.VertexesColor;
                    foreach (Shape shape in shapes)
                        Shape.color = vertexesColor;
                    buffer.Clear();
                    UpdateTitle(true);
                    Refresh();
                }
            }
        }

        private DialogResult CallSaveWindow()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = FILE_FILTER;
            saveFileDialog.DefaultExt = "polygon";
            saveFileDialog.AddExtension = true;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName += "Untitled.polygon";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlOperations.SaveToXml(saveFileDialog.FileName, new PolygonData(shapes, innerColor, linesColor, vertexesColor, vertexRadius));
                FILE_PATH = saveFileDialog.FileName;
                return DialogResult.OK;
            }
            return DialogResult.Cancel;
        }

        #endregion SaveLoad

        private void UpdateTitle(bool isSaved)
        {
            if (FILE_PATH == null)
                this.Text = "Untitled";
            else 
                this.Text = Path.GetFileNameWithoutExtension(FILE_PATH);
            if (isSaved)
                this.Text += $" - Polygons";
            else
                this.Text += $"* - Polygons";

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Z))
            {
                PolygonData previousState = buffer.RevertToPreviousState();
                UpdatePolygon(previousState.Shapes, previousState.radius, previousState.InnerColor, previousState.LinesColor, previousState.VertexesColor);
                UpdateTitle(false);
            }
            if (keyData == (Keys.Control | Keys.Shift | Keys.Z))
            {
                PolygonData nextState = buffer.RevertToNextState();
                UpdatePolygon(nextState.Shapes, nextState.radius, nextState.InnerColor, nextState.LinesColor, nextState.VertexesColor);
                UpdateTitle(false);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public void SaveCurrentState()
        {
           buffer.SaveCurrentState(new PolygonData(shapes, innerColor, linesColor, vertexesColor, vertexRadius));
        }

        private void UpdatePolygon(List<Shape> shapes, int vertexRadius, Color innerColor, Color linesColor, Color vertexesColor)
        {
            this.shapes = Utilities.CopyFrom(shapes);
            this.vertexRadius = vertexRadius;
            this.innerColor = Utilities.CopyColor(innerColor);
            this.linesColor = Utilities.CopyColor(linesColor);
            this.vertexesColor = Utilities.CopyColor(vertexesColor);
            radiusSliderForm.radiusTrackBar.Value = vertexRadius;
            UpdateTitle(false);
            Refresh();
        }

        private void ResetPolygon()
        {
            FILE_PATH = null;
            UpdateTitle(false);
            shapes.Clear();
            buffer.Clear();
            vertexRadius = 10;
            linesColor = Color.OliveDrab;
            innerColor = Color.Honeydew;
            vertexesColor = Color.ForestGreen;
            Shape.color = vertexesColor;
            SaveCurrentState();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSaved)
            {
                DialogResult dlgRes = MessageBox.Show("Do you want to save changes?", "Polygons", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                switch (dlgRes)
                {
                    case DialogResult.Yes:
                        if (FILE_PATH == null)
                        {
                            DialogResult saveDlg = CallSaveWindow();
                            if (saveDlg == DialogResult.Cancel)
                                e.Cancel = true;
                        }
                        else
                        {
                            XmlOperations.SaveToXml(FILE_PATH, new PolygonData(shapes, innerColor, linesColor, vertexesColor, vertexRadius));
                        }
                        Refresh();
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        Refresh();
                        break;
                }
            }

        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circleToolStripMenuItem.Checked = true;
            squareToolStripMenuItem.Checked = false;
            triangleToolStripMenuItem.Checked = false;
        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circleToolStripMenuItem.Checked = false;
            squareToolStripMenuItem.Checked = true;
            triangleToolStripMenuItem.Checked = false;
        }

        private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circleToolStripMenuItem.Checked = false;
            squareToolStripMenuItem.Checked = false;
            triangleToolStripMenuItem.Checked = true;
        }
    }
}
