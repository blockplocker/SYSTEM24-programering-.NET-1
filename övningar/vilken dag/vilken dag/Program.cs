namespace vilken_dag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            string[] months = { "januari", "february", "mars", "april", "maj", "juni", "juli", "augusti", "september", "oktober", "november", "december" };

            Console.WriteLine("Skriv ett nummber för att få månaden");
            int.TryParse(Console.ReadLine(), out int value);

            Console.WriteLine(months[value]);


            string[] weekdays = { "måndag","tisdag","onsdag","torsdag","fredag","lördag","söndag" };

            Console.WriteLine($"Idag är det {weekdays[(int)DateTime.Now.DayOfWeek - 1]} den {DateTime.Now.Day} {months[(int)DateTime.Now.Month - 1]} {DateTime.Now.Year} ");





        }
    }
}
