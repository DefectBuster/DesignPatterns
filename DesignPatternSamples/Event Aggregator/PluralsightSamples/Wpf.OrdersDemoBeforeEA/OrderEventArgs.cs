using System;

namespace Wpf.OrdersDemoBeforeEA
{
    public class OrderEventArgs : EventArgs
    {
        public Order Order { get; set; }
    }
}
