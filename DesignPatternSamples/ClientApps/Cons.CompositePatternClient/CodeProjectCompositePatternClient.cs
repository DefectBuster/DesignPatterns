using CSharpLib.CompositePattern.CodeProject_CompositeSample.EmployeeHappinessRating;

namespace Cons.CompositePatternClient
{
    public class CodeProjectCompositePatternClient
    {
        public static void TestEmployeeHappiness()
        {
            Worker wTom = new Worker("Worker Tom",5);
            Supervisor sMary = new Supervisor("Supervisor Mary", 6);
            Supervisor sJerry = new Supervisor("Supervisor Jerry", 7);
            Supervisor sBob = new Supervisor("Supervisor Bob", 9);
            Worker wJimmy = new Worker("Worker Jimmy", 8);

            //Setup the relationship b/w worker and supervisor
            sMary.AddSubordinate(wTom); // Worker Tom works for Mary
            sJerry.AddSubordinate(sMary); // Supervisor Mary works for Jerry
            sJerry.AddSubordinate(sBob); // Supervisor Bob works for Jerrry
            sBob.AddSubordinate(wJimmy); // Worker Jimmy works for Bob

            // Jerry shows his happiness and asked everyone else to do the same
            sJerry.ShowHappiness();
        }
    }
}
