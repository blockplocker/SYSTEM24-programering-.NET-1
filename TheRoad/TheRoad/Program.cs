namespace TheRoad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] cars =
            {
                new Car("Volvo",13,false,29),
                new Car("Toyota",22,false,77),
                new Car("Ford",9,false,23)
            };

            GasStation gasStation = new GasStation();
            CarService carService = new CarService();

            while (true)
            {
                foreach (var car in cars)
                {
                    car.Drive();
                    Console.WriteLine(car.Make + " med " + car.Fuel + " liter i tanken, som nu kört " + car.TravelDistance + " mil på vägen.");

                    if (car.Fuel < 5)
                    {
                        Console.WriteLine("Snart tar bensinin slut!");
                    }

                    if (car.Fuel <= 0)
                    {
                        Console.WriteLine("Bilen har slut på bensin.");
                        gasStation.FillUp(car);
                    }
                    if (car.Damaged)
                    {
                        Console.WriteLine("Bilen har gått sönder.");
                        carService.Repair(car);
                    }

                    Console.WriteLine("----------------------------");

                }
                Console.WriteLine("Bensinstationen har servat " + gasStation.Served + " kunder med " + gasStation.FuelSold + " liter bensin.");
                Console.WriteLine("bilverkstaden har servat " + carService.Served + " kunder.");


            }

        }
    }
}
