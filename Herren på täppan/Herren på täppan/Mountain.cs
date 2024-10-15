using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herren_på_täppan
{
    internal class Mountain
    {
        public Person OnMountain { get; set; }

        public Mountain(Person person)
        {
            OnMountain = person;
            Console.WriteLine(person.Name + " med styrka " + person.Strenght + " går upp på berget");
        }

        public bool Climb(Person person)
        {
            if (OnMountain == null)
            {
                OnMountain = person;
                Console.WriteLine(person.Name + " går upp på berget");
                return true;
            }
            else
            {
                Console.Write(person.Name + ", med styrka " + person.Strenght + " går upp på berget");

            }


            if (person.Strenght > OnMountain.Strenght)
            {
                Console.Write(" och jagarbort " + OnMountain.Name + " från berget");
                Console.WriteLine();
                OnMountain = person;
                return true;
            }
            else
            {
                Console.Write(" men blir bortjagad av " + OnMountain.Name + " som har " + OnMountain.Strenght + " styrka.");
                Console.WriteLine();
                return false;
            }
        }
    }
}
