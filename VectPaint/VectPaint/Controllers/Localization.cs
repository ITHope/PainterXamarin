using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace VectPaint.Controllers
{
    class Localization
    {
        private static string currLocale = "en";
        public static string Locale { set { currLocale = value; OnLocalChange(); } }

        public delegate void OnLocalChangeDelegate();
        public static event OnLocalChangeDelegate OnLocalChange;

        public static string GetText(string id)
        {
            string locFile = "";
            if (currLocale == "en")
                locFile = "locale/locale_en.json";
            else
                locFile = "locale/locale_ru.json";

            string res = "ID NOT FOUND";


            // ToDo Add in Android/iOS

            //using (StreamReader streamReader = new StreamReader(locFile))
            //{
            //    JToken token = XObject.Parse(streamReader.ReadToEnd());
            //    res = token[id].ToString();
            //}

            return res;
        }
    }
}
