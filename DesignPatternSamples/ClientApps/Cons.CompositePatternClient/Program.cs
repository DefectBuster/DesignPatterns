using System;
using System.Collections.Generic;
using System.Linq;

namespace Cons.CompositePatternClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestPluralsightCompositePattern();

            TestCodeProjectCompositePattern();

            Console.ReadLine();
        }
        
        private static void TestPluralsightCompositePattern()
        {
            Console.WriteLine("Testing Before Composition Code \n");
            PluralsightCompositePatternClient.TestBefore_CompositeCode();

            Console.WriteLine("\n\nTesting After Composition Code \n");
            PluralsightCompositePatternClient.TestAfter_CompositeCode();
        }

        private static void TestCodeProjectCompositePattern()
        {
            Console.WriteLine("Testing Employee Heppiness Composition Code \n");
            CodeProjectCompositePatternClient.TestEmployeeHappiness();
        }
    }
}
