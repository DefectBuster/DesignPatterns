using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLib.FactoryPattern.Wrox_FactorySample
{
    /// <summary>
    /// Determine which courier should be used based on the value and weight of the order.
    /// </summary>
    public static class UKShippingCourierFactory
    {
        /// <summary>
        /// Factory Method, which determine which courier to return based on
        /// total cost and weight of an order.
        /// </summary>
        /// <param name="order"></param>
        /// <returns>ShippingCourier implementing IShippingCourier Interface.</returns>
        public static IShippingCourier CreateShippingCourier(Order order)
        {
            if (order.TotalCost > 100
                ||
                order.WeightInKG > 5)
            {
                return new DHL();
            }
            else
            {
                return new RoyalMail();
            }
        }
    }
}
