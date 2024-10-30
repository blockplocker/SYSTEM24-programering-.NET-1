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
            result += $"Här bor familjen {Family.Name} med {Family.NumberOfPeople} personer ";
            result += Garden ? "med en fin trädgård." : "utan en trägård";
            Console.WriteLine(result);
        }
    }
    public class Apartment : Building
    {
        public bool LandryRoom { get; set; }
        public List<Family> Families { get; set; }
        public Apartment(string address, int floors, bool landryRoom, List<Family> families) : base(address, floors)
        {
            LandryRoom = landryRoom;
            Families = families;
        }
        public override void WriteDescription()
        {
            string result = $"Ett lägenhetshus på {Address} med {Floors} våningar.";
            result += $"Här bor {Families.Count} familjer. ";
            result += "Familjerna är: ";
            foreach (Family family in Families)
            {
                result += $"{family.Name} med {family.NumberOfPeople} personer. ";
            }
            result += LandryRoom ? "Det finns en tvättstuga." : "De saknas tvättstuga.";
            Console.WriteLine(result);
        }
    }
}
