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
        Shape[] shapes;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = CreateGraphics();
            textBox1.Text = Convert.ToString(Cursor.Position.X) + ' ' + Convert.ToString(Cursor.Position.Y);
            Circle circle = new Circle(Cursor.Position.X, Cursor.Position.Y);
            circle.Draw(g);
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
