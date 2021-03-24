using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf.OrdersDemoAfterEAWithMessenger
{
    public class Order
    {
        private static int _newID = 1;
        public static int NewID { get { return _newID; } }

        public Order()
        {
            OrderID = _newID++;
        }

        public int OrderID { get; private set; }
        public string OrderNumber { get; set; }
        public string Description { get; set; }
    }
}
