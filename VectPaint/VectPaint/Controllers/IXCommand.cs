using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectPaint.Models;
using VectPaint.Views;

namespace VectPaint.Controllers
{
    interface IXCommand
    {
        PFigure ActiveFigure { get; set; }
        IPluginFigure ActiveFigurePlugin { get; set; }
        List<IPluginFigure> FigurePlugins { get; }
        List<IPluginFile> FilePlugins { get; }
        

        event Action OnFigurePluginChanged;

        void InitializePluginManager();
        PFigure PluginProcess(PFigure figure);
        void New();
        void FileOpen();
        void FileSave();
        void FileSaveAs();
        void CloseTab();
        void RenameTab();
        void OpenFromCloud();
        void SaveInCloud();
        void Exit();
        void ShowAbout();
        void EmptyFigure();
        void RussianLanguage();
        void EnglishLanguage();
        void LightSkin();
        void DarkSkin();
        void SetType(XData.FigureType type);
        void SetColor(byte r, byte g, byte b);
        void SetLineWidth(int width);
        void TogglePlugin(IPluginFigure plugin);

        // ToDo Add in Android/iOS

        //TabControl TabControl { get; set; }
        //void ToggleVisible(Control control);
    }
}
