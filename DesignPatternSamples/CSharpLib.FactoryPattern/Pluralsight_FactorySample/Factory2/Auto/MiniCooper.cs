using System;

namespace CSharpLib.FactoryPattern.Pluralsight_FactorySample.Factory2
{
    public class MiniCooper : IAuto
    {
        public void TurnOn()
        {
            Console.WriteLine("The Mini Cooper is on! 1.6 Liters of brutal force is churning.");
        }

        public void TurnOff()
        {
            Console.WriteLine("The Mini Cooper is has turned off.");
        }
    }
}
