using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLib.FactoryPattern.Wrox_FactorySample
{
    public class OrderService
    {
        public void Dispatch (Order order)
        {
            IShippingCourier shippingCourier = 
                UKShippingCourierFactory.CreateShippingCourier(order);

            order.CourierTrackingId = 
                shippingCourier.GenerateConsignmentLabelFor(order.DispatchAddress);
        }
    }
}
