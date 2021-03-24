using System;
using Microsoft.Practices.Composite.Presentation.Events;

namespace Wpf.OrdersDemoAfterEAWithPrism
{
    public class OrderEvent : CompositePresentationEvent<Order>
    {
    }

    public class OrderSelected : OrderEvent { }
    public class OrderCreated : OrderEvent { }
    public class OrderSaved : OrderEvent { }
}
