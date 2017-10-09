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
using static VectPaint.Droid.Figure;

namespace VectPaint.Droid
{
    public class XDataAndroid : IXData
    {
        public Android.Graphics.Color Color { get; set; }

        public int Width { get; set; }
        public FigureType Type { get; set; }

        public XDataAndroid()
        {
            Color = Android.Graphics.Color.Black;
            Width = 1;
            Type = FigureType.Rect;
        }
    }
}