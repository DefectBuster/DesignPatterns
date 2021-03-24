using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLib.FactoryPattern.Pluralsight_FactorySample.Factory4.Autos
{
    public class NullAutomobile : IAutomobile
    {
        public string Name
        {
            get { return string.Empty; }
        }

        public void TurnOn()
        {

        }

        public void TurnOff()
        {

        }
    }
}
