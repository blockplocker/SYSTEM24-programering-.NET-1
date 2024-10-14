using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRoad
{
    internal class GasStation
    {
        public int Served { get; set; }
        public int FuelSold { get; set; }

        public GasStation()
        {
            Served = 0;
            FuelSold = 0;
        }
        public void FillUp(Car car)
        {
            int fillQuantity = 25;
            car.Fuel += fillQuantity;
            Served++;
            FuelSold += fillQuantity;
            Console.WriteLine("Bilen blev tankad på bensitnstationen.");

        }

    }
}
