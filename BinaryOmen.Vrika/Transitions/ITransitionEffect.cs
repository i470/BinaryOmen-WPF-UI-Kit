using System.Windows;
using System.Windows.Media.Animation;

namespace BinaryOmen.Vrika.Wpf.Transitions
{
    public interface ITransitionEffect
    {
        Timeline Build<TSubject>(TSubject effectSubject) where TSubject : FrameworkElement, ITransitionEffectSubject;
    }
}