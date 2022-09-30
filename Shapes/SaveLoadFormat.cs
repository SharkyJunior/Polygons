using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Shapes
{
    [Serializable]
    public class SaveLoadFormat
    {
        public List<Shape> shapes;
        public int innerColor, linesColor, vertexesColor, radius;

        public Color InnerColor => Color.FromArgb(innerColor);
        public Color LinesColor => Color.FromArgb(linesColor);
        public SaveLoadFormat()
        {
            this.shapes = new List<Shape>();
            this.innerColor = new Color().ToArgb();
            this.linesColor = new Color().ToArgb();
        }
        public SaveLoadFormat(List<Shape> shapes, Color innerColor, Color linesColor, Color vertexesColor, int radius)
        {
            this.shapes = shapes;
            this.innerColor = innerColor.ToArgb();
            this.linesColor = linesColor.ToArgb();
            this.vertexesColor = vertexesColor.ToArgb();
            this.radius = radius;
        }
    }
}
