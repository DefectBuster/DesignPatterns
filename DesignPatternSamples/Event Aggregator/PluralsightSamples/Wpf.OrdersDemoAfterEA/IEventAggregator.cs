using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf.OrdersDemoAfterEA
{
    public interface IEventAggregator
    {
        void Subscribe(object subscriber);
        void Publish<TEvent>(TEvent eventToPublish);
    }

    public class OrderCreated
    {
        public Order Order { get; set; }
    }

    public class OrderSelected
    {
        public Order Order { get; set; }
    }

    public class OrderSaved
    {
        public Order Order { get; set; }
    }
}
