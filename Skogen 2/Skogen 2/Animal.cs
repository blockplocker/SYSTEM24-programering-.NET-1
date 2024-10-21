using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skogen_2
{
    internal class Animal
    {
        public  int Weight { get; set; }
        public bool Nocturnal { get; set; }

        public Animal(int weight, bool nocturnal)
        {
            Weight = weight;
            Nocturnal = nocturnal;
        }

        public virtual void Move(bool day)
        {
        }
    }
    class Owl : Animal
    {
        public int Wingspan { get; set; }
        public Owl(int weight, bool nocturnal, int wingspan) : base(weight, nocturnal)
        {
            Wingspan = wingspan;
        }
        public override void Move(bool day)
        {
            if (Nocturnal && day == false)
            {
                Console.WriteLine("Ugglan flyger runt i skogen och letar efter mat");
            }
            else
            {
                Console.WriteLine("Ugglan är sover");
            }
        }
    } 
    class Horse : Animal
    {
        public int HayPerDay { get; set; }
        public Horse(int weight, bool nocturnal, int hayPerDay) : base(weight, nocturnal)
        {
            HayPerDay = hayPerDay;
        }
        public override void Move(bool day)
        {
            if (Nocturnal == false && day == true)
            {
                Console.WriteLine("Hästen travar runt i skogen och äter hö");
            }
            else
            {
                Console.WriteLine("Hästen är sover");
            }
        }
    }
    class Dolfin : Animal
    {
        public int DistancePerDay { get; set; }
        public Dolfin(int weight, bool nocturnal, int distancePerDay) : base(weight, nocturnal)
        {
            DistancePerDay = distancePerDay;
        }
        public override void Move(bool day)
        {
            if (Nocturnal == false && day == true)
            {
                Console.WriteLine("Delfinen simmar runt i sjön och letar efter fisk");
            }
            else
            {
                Console.WriteLine("Delfinen är sover");
            }
        }
    }
}
