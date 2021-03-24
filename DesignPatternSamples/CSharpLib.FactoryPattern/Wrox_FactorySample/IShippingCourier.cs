using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLib.FactoryPattern.Wrox_FactorySample
{
    public interface IShippingCourier
    {
        /// <summary>
        /// Method to return consignment ID based on passed in address.
        /// </summary>
        /// <param name="address">Consignment Address.</param>
        /// <returns>Consignment ID.</returns>
        string GenerateConsignmentLabelFor(Address address);
    }
}
