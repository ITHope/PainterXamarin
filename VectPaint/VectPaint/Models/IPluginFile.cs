using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectPaint.Models
{
    interface IPluginFile
    {
        string Serialize(MTab mTab);
        MTab Deserialize(string str);
    }
}
