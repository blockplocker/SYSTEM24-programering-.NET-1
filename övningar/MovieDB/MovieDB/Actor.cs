using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDB
{
    internal class Actor
    {
        public string Name { get; set; }
        public int BirthYear { get; set; }

        public Actor(string name, int birthYear)
        {
            Name = name;
            BirthYear = birthYear;
        }
        
    }
}
