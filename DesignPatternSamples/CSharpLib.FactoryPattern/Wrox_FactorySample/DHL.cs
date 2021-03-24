using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLib.FactoryPattern.Wrox_FactorySample
{
    public class DHL : IShippingCourier
    {
        public string GenerateConsignmentLabelFor(Address address)
        {
            return "DHL-XXX-XXX-XXX";
        }
    }
}
