﻿using Jamesnet.Wpf.Controls;
using System.Windows;
using System.Windows.Controls;

namespace Paris.Main.Views
{
    public class MainContent : JamesContent
    {
        static MainContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MainContent), new FrameworkPropertyMetadata(typeof(MainContent)));
        }
    }
}
