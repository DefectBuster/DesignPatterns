using System;

namespace Wpf.OrdersDemoAfterEA
{
    public class OrderEventArgs : EventArgs
    {
        public Order Order { get; set; }
    }
}
