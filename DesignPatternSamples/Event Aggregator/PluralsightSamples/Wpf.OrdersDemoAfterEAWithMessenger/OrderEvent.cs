using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf.OrdersDemoAfterEAWithMessenger
{
    public class OrderEvent
    {
        public Order Order { get; set; }
    }

    public class OrderSelected : OrderEvent { }
    public class OrderCreated : OrderEvent { }
    public class OrderSaved : OrderEvent { }
}
