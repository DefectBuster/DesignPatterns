
namespace CSharpLib.FactoryPattern.Pluralsight_FactorySample.Factory3
{
    public interface IAuto
    {
        string Name { get; }
        void SetName(string name);
        void TurnOn();
        void TurnOff();
    }
}
