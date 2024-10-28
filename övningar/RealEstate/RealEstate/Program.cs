namespace RealEstate
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            List<Building> buildings = new List<Building>();

            // Create some buildings
            buildings.Add(new Building("Storgatan 1", 2));


            // Create some Houses
            Family family1 = new Family("Nillsion", 4);

            buildings.Add(new House("Tvärgatan 5", 2, true, family1));


            // Create some Apartments
            List<Family> families = new List<Family>();
            families.Add(new Family("Anderson", 2));
            families.Add(new Family("Ekberg", 3));

            buildings.Add(new Apartment("Storgatan 25", 5, true, families));




            foreach (Building building in buildings)
            {
                building.WriteDescription();
            }
        }
    }
}
