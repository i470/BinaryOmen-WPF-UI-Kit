using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace BinaryOmen.Vrika.Wpf
{
    public interface IMetroThumb : IInputElement
    {
        event DragStartedEventHandler DragStarted;

        event DragDeltaEventHandler DragDelta;

        event DragCompletedEventHandler DragCompleted;

        event MouseButtonEventHandler MouseDoubleClick;
    }
}