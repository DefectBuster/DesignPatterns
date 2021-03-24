using System;
using System.Text;
using System.Collections.Generic;
using CSharpLib.FactoryPattern.Wrox_FactorySample;
using NUnit.Framework;

namespace FactoryPattern.Test
{
    /// <summary>
    /// Summary description for WroxFactoryPatternTest
    /// </summary>
    [TestFixture]
    public class WroxFactoryPatternNUnitTest
    {
        [Test]
        public void UKShippingCourierFactory_Should_Create_DHLShippingCourier_WithTotalCost_Over100()
        {
            Order order = new Order() { TotalCost = 100 };

            IShippingCourier courier = UKShippingCourierFactory.CreateShippingCourier(order);

            Assert.That(courier, Is.TypeOf(typeof(RoyalMail)));
        }
    }
}
