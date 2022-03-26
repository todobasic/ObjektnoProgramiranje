using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingBoard
{
    class Poligon : GrafObj
    {
        protected Point mCurrPoint;
        protected Graphics mGraphicsHelper;
        
        public Poligon(Color color, Point StartPoint, Point CurrPoint, Graphics GraphicsHelper)
        {
            this.mStartPoint = StartPoint;
            this.mCurrPoint = CurrPoint;
            this.mColor = color;
            this.mGraphicsHelper = GraphicsHelper;
        }
        public override void DrawGrafObj()
        {            
             Point[] pointsArray = { mStartPoint, new Point(mStartPoint.X + 20, mStartPoint.Y + 20), new Point(mStartPoint.X + 30, mStartPoint.Y + 50), mCurrPoint };
             mGraphicsHelper.DrawPolygon(new Pen(this.mColor, 1), pointsArray);              
           
        }
    }

}

