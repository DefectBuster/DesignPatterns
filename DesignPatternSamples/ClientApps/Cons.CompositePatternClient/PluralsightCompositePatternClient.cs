using System;
using System.Collections.Generic;
using System.Linq;
using Before = CSharpLib.CompositePattern.Pluralsight_CompositeSample.Before;
using After = CSharpLib.CompositePattern.Pluralsight_CompositeSample.After;

namespace Cons.CompositePatternClient
{
    internal class PluralsightCompositePatternClient
    {
        public static void TestBefore_CompositeCode()
        {
            int goldForKill = 1023;
            Console.WriteLine("You have killed the Giant IE6 Monster and gained {0} gold!", goldForKill);

            var joe = new Before.Person { Name = "Joe" };
            var jake = new Before.Person { Name = "Jake" };
            var emily = new Before.Person { Name = "Emily" };
            var sophia = new Before.Person { Name = "Sophia" };
            var brian = new Before.Person { Name = "Brian" };
            var developers = new Before.Group { Name = "Developers", Members = { joe, jake, emily } };

            var individuals = new List<Before.Person> { sophia, brian };
            var groups = new List<Before.Group> { developers };

            var totalToSplitBy = individuals.Count + groups.Count;

            var amountForEach = goldForKill / totalToSplitBy;
            var leftOver = goldForKill % totalToSplitBy;

            foreach (var individual in individuals)
            {
                individual.Gold += amountForEach + leftOver;
                leftOver = 0;
                individual.Stats();
            }

            foreach (var group in groups)
            {
                var amountForEachGroupMember = amountForEach / group.Members.Count;
                var leftOverForGroup = amountForEachGroupMember % group.Members.Count;
                foreach (var member in group.Members)
                {
                    member.Gold += amountForEachGroupMember + leftOverForGroup;
                    leftOverForGroup = 0;
                    member.Stats();
                }
            }
        }

        public static void TestAfter_CompositeCode()
        {
            int goldForKill = 1023;
            Console.WriteLine("You have killed the Giant IE6 Monster and gained {0} gold!", goldForKill);

            var joe = new After.Person { Name = "Joe" };
            var jake = new After.Person { Name = "Jake" };
            var emily = new After.Person { Name = "Emily" };
            var sophia = new After.Person { Name = "Sophia" };
            var brian = new After.Person { Name = "Brian" };
            var oldBob = new After.Person { Name = "Old Bob" };
            var newBob = new After.Person { Name = "New Bob" };
            var bobs = new After.Group { Members = { oldBob, newBob } };
            var developers = new After.Group { Name = "Developers", Members = { joe, jake, emily, bobs } };

            var parties = new After.Group { Members = { developers, sophia, brian } };

            parties.Gold += goldForKill;
            parties.Stats();

        }
    }
}
