using System.Windows;
using System.Windows.Data;
using ControlzEx.Behaviors;
using BinaryOmen.Vrika.Wpf;
using ControlzEx.Windows.Shell;

namespace MahApps.Metro.Behaviors
{
    public class BorderlessWindowBehavior : WindowChromeBehavior
    {
        protected override void OnAttached()
        {
            BindingOperations.SetBinding(this, IgnoreTaskbarOnMaximizeProperty, new Binding { Path = new PropertyPath(MetroWindow.IgnoreTaskbarOnMaximizeProperty), Source = this.AssociatedObject });
            BindingOperations.SetBinding(this, ResizeBorderThicknessProperty, new Binding { Path = new PropertyPath(MetroWindow.ResizeBorderThicknessProperty), Source = this.AssociatedObject });
            BindingOperations.SetBinding(this, TryToBeFlickerFreeProperty, new Binding { Path = new PropertyPath(MetroWindow.TryToBeFlickerFreeProperty), Source = this.AssociatedObject });
            BindingOperations.SetBinding(this, KeepBorderOnMaximizeProperty, new Binding { Path = new PropertyPath(MetroWindow.KeepBorderOnMaximizeProperty), Source = this.AssociatedObject });

            base.OnAttached();
        }

        protected override void OnDetaching()
        {
            BindingOperations.ClearBinding(this, IgnoreTaskbarOnMaximizeProperty);
            BindingOperations.ClearBinding(this, ResizeBorderThicknessProperty);
            BindingOperations.ClearBinding(this, TryToBeFlickerFreeProperty);
            BindingOperations.ClearBinding(this, KeepBorderOnMaximizeProperty);

            base.OnDetaching();
        }

        public bool TryToBeFlickerFree
        {
            get { return (bool)this.GetValue(TryToBeFlickerFreeProperty); }
            set { this.SetValue(TryToBeFlickerFreeProperty, value); }
        }

        /// <summary>
        /// <see cref="DependencyProperty"/> for <see cref="TryToBeFlickerFree"/>.
        /// </summary>
        public static readonly DependencyProperty TryToBeFlickerFreeProperty = DependencyProperty.Register(nameof(TryToBeFlickerFree), typeof(bool), typeof(MetroWindow), new PropertyMetadata(false));
        protected override void AssociatedObject_Loaded(object sender, RoutedEventArgs e)
        {
            var window = sender as MetroWindow;
            if (window == null)
            {
                return;
            }

            if (window.ResizeMode != ResizeMode.NoResize)
            {
                //window.SetIsHitTestVisibleInChromeProperty<Border>("PART_Border");
                window.SetIsHitTestVisibleInChromeProperty<UIElement>("PART_Icon");
                window.SetWindowChromeResizeGripDirection("WindowResizeGrip", ResizeGripDirection.BottomRight);
            }
        }
    }
}