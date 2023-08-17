using Paris.Support.UI.Units;
using System.Windows;

namespace Paris.Forms.UI.Views
{
    public class ParisWindow : SeineWindow
    {
        static ParisWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ParisWindow), new FrameworkPropertyMetadata(typeof(ParisWindow)));
        }
    }
}
