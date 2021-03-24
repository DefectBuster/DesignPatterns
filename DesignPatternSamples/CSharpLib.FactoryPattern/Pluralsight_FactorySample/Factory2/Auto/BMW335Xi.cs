using System;

namespace CSharpLib.FactoryPattern.Pluralsight_FactorySample.Factory2
{
    public class BMW335Xi : IAuto
    {
        public void TurnOn()
        {
            Console.WriteLine("The BMW 335Xi is on and running.");
        }

        public void TurnOff()
        {
            Console.WriteLine("The BMW 335Xi is off.");
        }
    }
}
