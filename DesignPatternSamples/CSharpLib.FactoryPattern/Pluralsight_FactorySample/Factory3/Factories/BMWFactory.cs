
namespace CSharpLib.FactoryPattern.Pluralsight_FactorySample.Factory3
{
    class BMWFactory : IAutoFactory
    {
        public IAuto CreateAutomobile()
        {
            return new BMW("BMW M5 Cabriolet");
        }
    }
}
