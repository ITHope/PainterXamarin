using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectPaint.Views;

namespace VectPaint.Models
{
    interface IPluginFigure : IPlugin
    {
        PFigure ActiveFigure { set; }
        PFigure Process(PFigure figure);
    }
}
