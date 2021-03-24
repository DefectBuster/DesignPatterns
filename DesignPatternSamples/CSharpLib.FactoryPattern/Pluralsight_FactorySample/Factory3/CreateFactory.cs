using System.Reflection;

namespace CSharpLib.FactoryPattern.Pluralsight_FactorySample.Factory3
{
    public static class CreateFactory
    {
        public static Factory3.IAutoFactory LoadFactory(string CarFactoryName)
        {
            string factoryName = CarFactoryName;
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as Factory3.IAutoFactory;
        }
    }
}
