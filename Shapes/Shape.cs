using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;
using System.CodeDom;

namespace Shapes
{
    [Serializable]
    [XmlRoot("Shape")]
    [XmlInclude(typeof(Circle)), XmlInclude(typeof(Square)), XmlInclude(typeof(Triangle))]
    public abstract class Shape
    {
        #region Fields & Properties
        [XmlIgnore]
        public int offsetX, offsetY;

        [XmlIgnore]
        public bool isDragged;

        public int X { get; set; }
        public int Y { get; set; }

        [XmlIgnore]
        public static Color color { get; set; }

        [XmlIgnore]
        public static int radius { get; set; }

        #endregion

        #region Methods
        public abstract void Draw(Graphics g);

        public abstract bool IsInside(int mouseX, int mouseY);

        protected Shape CopyTo(Shape copy)
        {
            copy.X = X;
            copy.Y = Y;
            return copy;
        }

        public abstract Shape Copy();

        public virtual void UpdatePosition(int newMouseX, int newMouseY)
        {
            X = newMouseX - offsetX;
            Y = newMouseY - offsetY;
        }
        #endregion 
    }
}
