using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRoad
{
    internal class CarService
    {
        public int Served { get; set; }

        public CarService()
        {
            Served = 0;

        }
        public void Repair(Car Car)
        {
            Served++;
            Car.Damaged = false;
            Console.WriteLine("Bilen blev lagad på verkstaden.");
        }
    }
}
