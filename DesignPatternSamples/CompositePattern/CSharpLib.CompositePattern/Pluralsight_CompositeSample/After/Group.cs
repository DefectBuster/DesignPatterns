using System.Collections.Generic;

namespace CSharpLib.CompositePattern.Pluralsight_CompositeSample.After
{
    public class Group : IParty
    {
        public string Name { get; set; }
        public List<IParty> Members { get; set; }

        public Group()
        {
            Members = new List<IParty>();
        }

        public int Gold
        {
            get
            {
                int totalGold = 0;
                foreach (var member in Members)
                {
                    totalGold += member.Gold;
                }

                return totalGold;
            }
            set
            {
                var eachSplit = value / Members.Count;
                var leftOver = value % Members.Count;
                foreach (var member in Members)
                {
                    member.Gold += eachSplit + leftOver;
                    leftOver = 0;
                }
            }
        }

        public void Stats()
        {
            foreach (var member in Members)
            {
                member.Stats();
            }
        }
    }
}
