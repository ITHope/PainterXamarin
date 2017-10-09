using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Util;
using Android.Graphics.Drawables;
using Android.Graphics;

namespace VectPaint.Droid
{
    [Register("VectPaint.Droid.PDraw")]
    public class PDraw: View
    {
        public PDraw(Context context, IAttributeSet attrs) :
            base(context, attrs)
        {
        }
        public XDataAndroid data { get; set; }
        float x;
        float y;
        List<IFigure> figures = new List<IFigure>();
        Paint paint;
        Canvas canvas;

        protected override void OnDraw(Canvas canvas)
        {
            this.canvas = canvas;
            canvas.ClipRect(new Rect(0, 0, Width, Height));
            paint = new Paint();
            paint.SetStyle(Paint.Style.Stroke);
            paint.StrokeJoin = Paint.Join.Round;
            paint.StrokeCap = Paint.Cap.Round;
            paint.AntiAlias = true;

            foreach (Figure f in figures)
            {
                paint.StrokeWidth = f.StrokeWidth;
                paint.Color = f.Color;
                canvas.DrawPath(f.Path, paint);
            }
        }

        private void AddFigure(float curX, float curY)
        {
            Figure figure = new Figure(new PointF(x, y), new PointF(curX, curY), data.Color, data.Width, data.Type);
            figures.Add(figure);

        }

        //private void DrawFigure(float curX, float curY)
        //{
        //    Figure figure = new Figure(new PointF(x, y), new PointF(curX, curY), data.Color, data.Width, data.Type);
        //    paint.StrokeWidth = figure.StrokeWidth;
        //    paint.Color = figure.Color;
        //    canvas.DrawPath(figure.Path, paint);
        //}
        public override bool OnTouchEvent(MotionEvent e)
        {
            switch (e.Action)
            {
                case MotionEventActions.Down:
                    x = e.GetX();
                    y = e.GetY();
                    break;
                case MotionEventActions.Move:
                //    AddFigure(e.GetX(), e.GetY());
                //    x = e.GetX();
                //    y = e.GetY();
                    Invalidate();
                    break;
                case MotionEventActions.Up:
                    AddFigure(e.GetX(), e.GetY());
                    Invalidate();
                    break;
                default:
                    return false;
            }
           
            return true;

        }
    }
}