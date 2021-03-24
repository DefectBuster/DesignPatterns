using CSharpLib.SingletonPattern.Pluralsight_SingletonPattern.FileLogger.Interfaces;

namespace CSharpLib.SingletonPattern.Pluralsight_SingletonPattern.FileLogger.Implementation
{
    public class DefaultDelayConfig : IDelayConfig
    {
        private int _delayMilliseconds = 50;
        public int DelayMilliseconds
        {
            get { return _delayMilliseconds; }
            set { _delayMilliseconds = value; }
        }
    }
}
