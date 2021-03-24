using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLib.CompositePattern.CodeProject_CompositeSample.EmployeeHappinessRating
{
    public class Worker : IEmployee
    {
        private string Name;
        private int Happiness;

        public Worker(string name, int happiness)
        {
            Name = name;
            Happiness = happiness;
        }

        public void ShowHappiness()
        {
            Console.WriteLine(Name + " showed happiness level of " + Happiness);
        }
    }
}
