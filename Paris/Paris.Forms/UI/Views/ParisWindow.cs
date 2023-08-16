using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Paris.Forms.UI.Views
{
    public class ParisWindow : JamesWindow
    {
        static ParisWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ParisWindow), new FrameworkPropertyMetadata(typeof(ParisWindow)));
        }
    }
}
