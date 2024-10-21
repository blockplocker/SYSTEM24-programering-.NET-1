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
        public string  Action { get; set; }


        public Animal(string name, bool nocturnal, string movement, string action)
        {
            Name = name;
            Nocturnal = nocturnal;
            Movement = movement;
            Action = action;
        }

        public static void AnimalDoing(Animal animal, bool night)
        {
            if (animal.Nocturnal == night)
            {
                Console.WriteLine(animal.Name + " " + animal.Movement + " och " + animal.Action);
            }
            else
            {
            Console.WriteLine(animal.Name + " sover");
            }
        }



    }
}
