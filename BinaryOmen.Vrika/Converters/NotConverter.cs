using System;
using System.Globalization;
using System.Windows.Data;

namespace BinaryOmen.Vrika.Wpf.Converters
{
    public class NotConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !(value as bool?) ?? !bool.Parse(value.ToString());
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !(value as bool?) ?? !bool.Parse(value.ToString());
        }
    }    
}