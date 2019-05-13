using System;

namespace BinaryOmen.Vrika.Wpf
{
    public class ClosingWindowEventHandlerArgs : EventArgs
    {
        public bool Cancelled { get; set; }
    }
}