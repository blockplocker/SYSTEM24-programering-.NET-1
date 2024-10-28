namespace RealEstate
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            List<Building> buildings = new List<Building>();

            buildings.Add(new Building("Storgatan 1", 2));

            Family family1 = new Family("Nillsion", 4);
            buildings.Add(new House("Tvärgatan 5", 2, true, family1));

            foreach (Building building in buildings)
            {
                building.WriteDescription();
            }
        }
    }
}
