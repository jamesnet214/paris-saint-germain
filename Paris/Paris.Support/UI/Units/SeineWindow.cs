using Jamesnet.Wpf.Controls;
using System.Windows;

namespace Paris.Support.UI.Units
{
    public class SeineWindow : JamesWindow
    {
        static SeineWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SeineWindow), new FrameworkPropertyMetadata(typeof(SeineWindow)));
        }

        public SeineWindow()
        {
            WindowStyle = WindowStyle.None;
            AllowsTransparency = true;
        }
    }
}
