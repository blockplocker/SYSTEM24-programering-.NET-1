using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    public class Family
    {
        public string Name { get; set; }
        public int NumberOfPeople { get; set; }

        public Family(string name, int numberOfPeople)
        {
            Name = name;
            NumberOfPeople = numberOfPeople;
        }
    }
}
