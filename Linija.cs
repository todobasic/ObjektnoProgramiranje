using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingBoard
{
    class Linija : GrafObj
    {
        protected Point mCurrPoint;
        protected Graphics mGraphicsHelper;        

        public Linija(Color color, Point StartPoint, Point CurrPoint, Graphics GraphicsHelper)
        {
            this.mColor = color;
            this.mStartPoint = StartPoint;
            this.mCurrPoint = CurrPoint;
            this.mGraphicsHelper = GraphicsHelper;
        }

        public override void DrawGrafObj()
        {
            mGraphicsHelper.DrawLine(new Pen(this.mColor, 1), this.mStartPoint, this.mCurrPoint);
        }

    }
}
