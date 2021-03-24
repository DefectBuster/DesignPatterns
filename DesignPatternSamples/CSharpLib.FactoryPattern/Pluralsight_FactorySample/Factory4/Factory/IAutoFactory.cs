using CSharpLib.FactoryPattern.Pluralsight_FactorySample.Factory4.Autos;

namespace CSharpLib.FactoryPattern.Pluralsight_FactorySample.Factory4.Factory
{
    public interface IAutoFactory
    {
        IAutomobile CreateSportsCar();
        IAutomobile CreateLuxuryCar();
        IAutomobile CreateEconomyCar();
    }
}
