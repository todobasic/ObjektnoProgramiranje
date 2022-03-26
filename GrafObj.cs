using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingBoard
{
    public abstract class GrafObj
    {
        protected Color mColor;
        protected Point mStartPoint;

        public GrafObj() { }

        public GrafObj(Color color, Point point) { this.mColor = color; this.mStartPoint = point; }

        public void setColor(Color color)
        {
            this.mColor = color;
        }
        public Color getColor()
        {
            return this.mColor;
        }

        public virtual void DrawGrafObj()
        {

        }
    }
}
