using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyConstruktorDemo
{
    internal class Cat
    {
        public string Name { get; set; }
        public string Owner { get; set; }

        public Cat(string name, string owner )
        {
            Name = name.ToUpper();
            Owner = owner;

        }
        public Cat()
        {
            
        }

        public void saymjau()
        {
            Console.WriteLine(Name + " säger MJAU till " + Owner);
        }
    }
}
