using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLib.FactoryPattern.Pluralsight_FactorySample.Factory3
{
    class MiniCooperFactory : IAutoFactory
    {
        public IAuto CreateAutomobile()
        {
            var mini = new MiniCooper();
            mini.SetName("Mini Cooper S");

            return mini;
        }
    }
}
