using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    internal class Car
    {
        public int Age { get; set; }
        public int Speed { get; set; }
        public string Fuel { get; set; }
    }
    class GenericCar<TypeAge, TypeSpeed, TypeFuel>
    {
        public TypeAge Age { get; set; }
        public TypeSpeed Speed { get; set; }
        public TypeFuel Fuel { get; set; }
    }
}
