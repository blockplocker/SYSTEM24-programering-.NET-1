namespace GenericDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Age = 5;
            car1.Speed = 190;
            car1.Fuel = "El";
            Console.WriteLine("Här är en bil med åldern " + car1.Age
                + ", som körs på " + car1.Fuel
                + ", med hastigheten " + car1.Speed);

            GenericCar<string, double, int> car2 = new GenericCar<string, double, int>();

            car2.Age = "Gammal";
            car2.Speed = 192.5;
            car2.Fuel = 95;
            Console.WriteLine("Här är en bil med åldern " + car2.Age
                + ", som körs på " + car2.Fuel
                + ", med hastigheten " + car2.Speed);
            
            GenericCar<int, int, string> car3 = new GenericCar<int, int, string>();

            car3.Age = 10;
            car3.Speed = 190;
            car3.Fuel = "bensin";
            Console.WriteLine("Här är en bil med åldern " + car3.Age
                + ", som körs på " + car3.Fuel
                + ", med hastigheten " + car3.Speed);

            Helpers helpers = new Helpers();
            helpers.writeLength("Hej hopp");
            helpers.writeLength(12345);
            helpers.writeLength(true);
            helpers.writeLength(car1);

            Person person1 = new Person() { Age = 35, Speed = 5, Name = "Anna"};

            helpers.ObjectInformation(car1);
            helpers.ObjectInformation(person1);
        }
    }
}
