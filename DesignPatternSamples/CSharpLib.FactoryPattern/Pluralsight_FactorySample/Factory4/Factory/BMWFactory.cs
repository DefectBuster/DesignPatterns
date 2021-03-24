using CSharpLib.FactoryPattern.Pluralsight_FactorySample.Factory4.Autos;
using CSharpLib.FactoryPattern.Pluralsight_FactorySample.Factory4.Autos.BMW;

namespace CSharpLib.FactoryPattern.Pluralsight_FactorySample.Factory4.Factory
{
    public class BMWFactory : IAutoFactory
    {
        public IAutomobile CreateSportsCar()
        {
            return new BMWM3();
        }

        public IAutomobile CreateLuxuryCar()
        {
            return new BMW740i();
        }

        public IAutomobile CreateEconomyCar()
        {
            return new BMW328i();
        }
    }
}
