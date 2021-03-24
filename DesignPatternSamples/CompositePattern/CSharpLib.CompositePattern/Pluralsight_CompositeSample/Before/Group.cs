using System.Collections.Generic;

namespace CSharpLib.CompositePattern.Pluralsight_CompositeSample.Before
{
    public class Group
    {
        public string Name { get; set; }
        public List<Person> Members { get; set; }

        public Group()
        {
            Members = new List<Person>();
        }
    }
}
