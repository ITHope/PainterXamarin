using Android.Graphics;
using System;
using System.Collections.Generic;
//using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VectPaint.IFigure;

namespace VectPaint.Droid
{
    public class Figure : IFigure
    {
        public enum FigureType { Line, Ellipse, Rect, }
        public Path Path { get; set; }
        public PointF Start { get; set; }
        public PointF End { get; set; }
        public Color Color { get; set; }
        public int StrokeWidth { get; set; }
        public FigureType Type { get; set; }

        public Figure(PointF start, PointF end, Color color, int width, FigureType type)
        {
            Start = start;
            End = end;
            Color = color;
            StrokeWidth = width;
            Type = type;
            Path = CreatePath();
        }

        Path CreatePath()
        {
            Path path = new Path();
            switch (Type)
            {
                case FigureType.Line:
                    path.MoveTo(Start.X, Start.Y);
                    path.LineTo(End.X, End.Y);
                    path.Close();
                    break;
                case FigureType.Rect:
                    path.AddRect(Start.X, Start.Y, End.X, End.Y, Path.Direction.Cw);
                    path.Close();
                    break;
                case FigureType.Ellipse:
                    path.AddOval(new RectF(Start.X, Start.Y, End.X, End.Y), Path.Direction.Cw);
                    path.Close();
                    break;
            }
            return path;
        }
        
    }
}