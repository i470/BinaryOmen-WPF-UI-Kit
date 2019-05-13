using System.Windows;
using System.Windows.Controls;

namespace BinaryOmen.Vrika.Wpf
{
    /// <summary>
    /// Displays an icon image/path, according to the specified <see cref="Type"/> name.
    /// </summary>
    /// <remarks>
    /// All icons sourced from Material Design Icons Font - <see cref="https://wpficons.com/"/> - in accordance of 
    /// <see cref="https://github.com/Templarian/wpf/blob/master/license.txt"/>.
    /// </remarks>
    public class Icon : Control
    {
        public static readonly DependencyProperty TypeProperty = DependencyProperty.Register(
            nameof(Type), typeof (IconType), typeof (Icon), new PropertyMetadata(default(IconType)));

        /// <summary>
        /// Gets or sets the name of icon being displayed.
        /// </summary>
        public IconType Type
        {
            get { return (IconType) GetValue(TypeProperty); }
            set { SetValue(TypeProperty, value); }
        }
    }
}
