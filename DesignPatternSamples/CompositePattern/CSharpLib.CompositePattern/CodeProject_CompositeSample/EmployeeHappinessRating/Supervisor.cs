using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLib.CompositePattern.CodeProject_CompositeSample.EmployeeHappinessRating
{
    public class Supervisor: IEmployee
    {
        private string Name;
        private int Happiness;
        private List<IEmployee> subordinates;

        /// <summary>
        /// Modified the constructor from original implementation in code project
        /// </summary>
        public Supervisor(string name, int happiness)
        {
            Name = name;
            Happiness = happiness;
            subordinates = new List<IEmployee>();
        }

        public void ShowHappiness()
        {
            Console.WriteLine(Name + " showed happiness level of " + Happiness);

            foreach (var emp in subordinates )
            {
                emp.ShowHappiness();
            }
        }

        public void AddSubordinate(IEmployee employee)
        {
            subordinates.Add(employee);
        }   
    }
}
