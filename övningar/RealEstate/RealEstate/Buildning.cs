using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    public class Building
    {
        public string Address { get; set; }
        public int Floors { get; set; }

        public Building(string address, int floors)
        {
            Address = address;
            Floors = floors;
        }

        public virtual void WriteDescription()
        {
            Console.WriteLine($"En byggnad på {Address} med {Floors} våningar.");
        }

    }
    public class House : Building
    {
        public bool Garden { get; set; }
        public Family Family { get; set; }
        public House(string address, int floors, bool garden, Family family) : base(address, floors)
        {
            Garden = garden;
            Family = family;
        }

        public override void WriteDescription()
        {
            string result = $"En villa på {Address} med {Floors} våningar.";
            result += $"Där bor familjen {Family.Name}, {Family.NumberOfPeople} personer";
            result += Garden ? "med en fin trädgård." : "utan en trägård";
            Console.WriteLine(result);
        }
    }
}
