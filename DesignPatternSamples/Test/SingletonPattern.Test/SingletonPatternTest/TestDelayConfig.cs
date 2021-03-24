using CSharpLib.SingletonPattern.Pluralsight_SingletonPattern.FileLogger.Interfaces;

namespace SingletonPattern.Test.SingletonPatternTest
{
    public class TestDelayConfig : IDelayConfig
    {
        public int DelayMilliseconds
        {
            get { return 5; }
        }
    }
}
