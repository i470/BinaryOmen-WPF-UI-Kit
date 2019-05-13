using System.Windows;
using ControlzEx;

namespace BinaryOmen.Vrika.Wpf
{
    /// <summary>
    /// Icon from the Material Design Icons project,
    /// <see cref="https://wpficons.com/"/>.
    /// </summary>
    public class PackIcon : PackIconBase<PackIconKind>
    {        
        static PackIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PackIcon), new FrameworkPropertyMetadata(typeof(PackIcon)));
        }

        public PackIcon() : base(PackIconDataFactory.Create) { }
    }
}
