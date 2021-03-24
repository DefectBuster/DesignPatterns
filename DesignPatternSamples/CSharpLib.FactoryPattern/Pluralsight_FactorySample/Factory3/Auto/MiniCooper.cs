using System;

namespace CSharpLib.FactoryPattern.Pluralsight_FactorySample.Factory3
{
    public class MiniCooper : IAuto
    {
        public string Name
        {
            get; private set;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void TurnOn()
        {
            Console.WriteLine("The " + Name + " is up and running with a mighty roar.");
        }

        public void TurnOff()
        {
            Console.WriteLine("The " + Name + " is turned off.");
        }
    }
}
