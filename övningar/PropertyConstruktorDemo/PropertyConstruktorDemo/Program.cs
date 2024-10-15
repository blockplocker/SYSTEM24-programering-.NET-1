namespace PropertyConstruktorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dog dog1 = new Dog();
            //dog1.Name = "Otto";
            //dog1.Breed = "Pudel";
            //Console.WriteLine(dog1.Name);
            //dog1.saywoof();

            //Dog dog2 = new Dog("Sessan", "Collie");
            //Console.WriteLine(dog2.Name);
            //dog2.Name = "Frasse";
            //dog2.saywoof();

            //Dog dog3 = new Dog("fido", "tax");
            //dog3.saywoof();

            //Dog dog4 = new Dog();
            //dog4.saywoof();


            Cat cat1 = new Cat();
            cat1.Name = "Tussan";
            cat1.Owner = "Anna";

            Cat cat2 = new Cat("Snuttan", "Nills");

            Cat cat3 = new Cat() { Name = "Tiger", Owner = "Eva" };

            List<Cat> catHome = new List<Cat>();
            catHome.Add(cat1);
            catHome.Add(cat2);
            catHome.Add(cat3);
            catHome.Add(new Cat("Felix","Lisa"));

            foreach (Cat cat in catHome)
            {
                cat.saymjau();
            }


        }
    }
}
