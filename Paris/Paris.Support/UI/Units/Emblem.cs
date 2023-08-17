using System.Windows;
using System.Windows.Controls;

namespace Paris.Support.UI.Units
{
    public class Emblem : Control
    {
        static Emblem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Emblem), new FrameworkPropertyMetadata(typeof(Emblem)));
        }

        public Emblem()
        {
        }
    }
}
