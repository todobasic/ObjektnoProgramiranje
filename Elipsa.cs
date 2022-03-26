using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingBoard
{
    class Elipsa : Kruznica
    {
        public Elipsa(Color color, Point StartPoint, Point CurrentPoint, Graphics GraphicsHelper) : base(color, StartPoint, CurrentPoint, GraphicsHelper)
        {
        }
        public override void DrawGrafObj()
        {
            mGraphicsHelper.DrawEllipse(new Pen(this.mColor, 1), this.mStartPoint.X, this.mStartPoint.Y, this.mCurrentPoint.X - this.mStartPoint.X, this.mCurrentPoint.Y - this.mStartPoint.Y);
        }
    }
}
