using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLib.FactoryPattern.Pluralsight_FactorySample.Factory4.Autos.BMW
{
    public class BMWM3 : BMWBase
    {
        public override string Name
        {
            get { return "BMW M3"; }
        }
    }
}
