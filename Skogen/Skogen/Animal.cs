using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skogen
{
    internal class Animal
    {
        public string Name { get; set; }
        public bool Nocturnal { get; set; }
        public string  Movement { get; set; }

        public Animal(string name, bool nocturnal, string movement)
        {
            Name = name;
            Nocturnal = nocturnal;
            Movement = movement;
        }
        


    }
}
