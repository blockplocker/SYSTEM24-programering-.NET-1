using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyConstruktorDemo
{
    internal class Dog
    {

        public string Name { get; set; }

        public string Breed { get; set; }

        public Dog()
        {
            Name = "Okänt namn";
            Breed = "Okänd ras";
        }
        public Dog(string myname,string mybreed)
        {
            Name = myname;
            Breed = mybreed;
        }

        public void saywoof()
        {
            string woof = Name + " som är en " + Breed + " säger VOV!";
            Console.WriteLine(woof);
        }
    }
}
