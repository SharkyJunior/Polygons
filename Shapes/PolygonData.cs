using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.CodeDom;

namespace Shapes
{
    [Serializable]
    public class PolygonData
    {
        public List<Shape> shapes;
        public int innerColor, linesColor, vertexesColor, radius;

        [XmlIgnore]
        public List<Shape> Shapes => shapes;
        public Color InnerColor => Color.FromArgb(innerColor);
        public Color LinesColor => Color.FromArgb(linesColor);
        public Color VertexesColor => Color.FromArgb(vertexesColor);

        public int Radius => radius;

        public PolygonData()
        {
            this.shapes = new List<Shape>();
            this.innerColor = new Color().ToArgb();
            this.linesColor = new Color().ToArgb();
        }

        public PolygonData(List<Shape> shapes, Color innerColor, Color linesColor, Color vertexesColor, int radius)
        {
            this.shapes = Utilities.CopyFrom(shapes);
            this.innerColor = Utilities.CopyColor(innerColor).ToArgb();
            this.linesColor = Utilities.CopyColor(linesColor).ToArgb();
            this.vertexesColor = Utilities.CopyColor(vertexesColor).ToArgb();
            this.radius = radius;
        }
    }
}
