﻿using System.Windows;

namespace BinaryOmen.Vrika.Wpf
{
    /// <summary>
    /// Internal use only.
    /// </summary>
    public class ScaleHost : FrameworkElement
    {
        public static readonly DependencyProperty ScaleProperty = DependencyProperty.Register(
            "Scale", typeof(double), typeof(ScaleHost), new PropertyMetadata(0.0));

        public double Scale
        {
            get { return (double) GetValue(ScaleProperty); }
            set { SetValue(ScaleProperty, value); }
        }
    }
}