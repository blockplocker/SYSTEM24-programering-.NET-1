using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRoad
{
    internal class Car
    {
        public string Make { get; set; }
        public int Fuel { get; set; }
        public bool Damaged { get; set; }
        public int TravelDistance { get; set; }

        public Car(string make, int fuel,bool damaged, int travelDistance)
        {
            Make = make;
            Fuel = fuel;
            Damaged = damaged;
            TravelDistance = travelDistance;

        }
        public void Drive()
        {
            TravelDistance++;
            Fuel--;
            if (Random.Shared.Next(0, 100) <= 10)
            {
                Damaged = true;
            }
        }
    }
}
