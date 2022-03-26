using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingBoard
{
    class Kruznica : GrafObj
    {
        protected Point mCurrentPoint;
        protected Graphics mGraphicsHelper;
        public Kruznica(Color color, Point StartPoint, Point CurrentPoint, Graphics GraphicsHelper)
        {
            this.mColor = color;
            this.mStartPoint = StartPoint;
            this.mCurrentPoint = CurrentPoint;
            this.mGraphicsHelper = GraphicsHelper;
        }
        public override void DrawGrafObj()
        {
            mGraphicsHelper.DrawEllipse(new Pen(this.mColor, 1), this.mStartPoint.X, this.mStartPoint.Y, this.mCurrentPoint.X - this.mStartPoint.X, this.mCurrentPoint.X - this.mStartPoint.X);
        }

    }
}
