using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Paris
{
    internal class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            return new Window();
        }
    }
}
