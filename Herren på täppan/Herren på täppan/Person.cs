using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herren_på_täppan
{
    internal class Person
    {
        public string Name { get; set; }
        public int Strenght { get; set; }

        public Person(string name)
        {
            Name = name;
            Strenght = new Random().Next(0, 50);
        }

        public static void IncreaseStrenght(Person person)
        {
            int gainedStrenght = new Random().Next(1, 10);
            person.Strenght += gainedStrenght;
            Console.WriteLine(person.Name + " tränade och fick " + gainedStrenght + " styrka.");
        }
    }
}
