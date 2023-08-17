using Jamesnet.Wpf.Controls;
using Paris.Forms.UI.Views;
using System.Windows;

namespace Paris
{
    internal class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            return new ParisWindow();
        }
    }
}
