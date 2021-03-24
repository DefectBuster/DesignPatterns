using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLib.FactoryPattern.Pluralsight_FactorySample.Factory4.Autos.BMW
{
    public class BMW328i : BMWBase
    {
        public override string Name
        {
            get { return "BMW 328i"; }
        }
    }
}
