using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectPaint
{
    class XData
    {
        public enum FigureType { Rectangle, Ellipse, RoundRectangle, Line };
        
        byte colorR = 0;
        byte colorG = 0;
        byte colorB = 0;
        public int lineWidth = 1;
        public FigureType type = FigureType.Rectangle;
    }
}
