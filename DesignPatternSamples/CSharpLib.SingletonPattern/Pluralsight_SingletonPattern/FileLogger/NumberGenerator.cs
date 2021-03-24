using System.Collections.Generic;

namespace CSharpLib.SingletonPattern.Pluralsight_SingletonPattern.FileLogger
{
    public class NumberGenerator
    {
        public IEnumerable<long> Integers()
        {
            long currentValue = 1;
            while (true)
            {
                yield return currentValue++;
            }
        }
    }
}
