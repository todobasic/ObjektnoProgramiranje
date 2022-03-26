using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingBoard
{
    class Pravokutnik : Linija
    {
        public Pravokutnik(Color color, Point StartPoint, Point CurrentPoint, Graphics GraphicsHelper) : base(color, StartPoint, CurrentPoint, GraphicsHelper) { }

        public override void DrawGrafObj()
        {
            mGraphicsHelper.DrawRectangle(new Pen(this.mColor, 1), this.mStartPoint.X, this.mStartPoint.Y, this.mCurrPoint.X - this.mStartPoint.X, this.mCurrPoint.Y - this.mStartPoint.Y);
        }
    }
}
