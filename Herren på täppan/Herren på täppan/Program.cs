namespace Herren_på_täppan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person("Kalle"));
            people.Add(new Person("Lisa"));
            people.Add(new Person("Olle"));
            people.Add(new Person("Anna"));
            people.Add(new Person("Johan"));
            people.Add(new Person("Eva"));

            Mountain mountain = new Mountain(people[new Random().Next(0, people.Count)]);
            while (true)
            {
                foreach (Person person in people)
                {
                    //Console.WriteLine(person.Name + " has a strenght of " + person.Strenght);
                    if(!mountain.Climb(person))
                    {
                        Person.IncreaseStrenght(person);
                    }
                }
                

            }
        }
    }
}
