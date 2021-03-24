using System.Reflection;

namespace CSharpLib.FactoryPattern.Pluralsight_FactorySample.Factory4
{
    public static class CreateFactory
    {
        public static Factory.IAutoFactory LoadFactory(string CarFactoryName)
        {
            string factoryName = CarFactoryName;
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as Factory.IAutoFactory;
        }
    }
}
