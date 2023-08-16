using System.Windows;
using System.Windows.Controls;

namespace Paris.Support.UI.Units
{
    public class SeineWindow : Control
    {
        static SeineWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SeineWindow), new FrameworkPropertyMetadata(typeof(SeineWindow)));
        }
    }
}
