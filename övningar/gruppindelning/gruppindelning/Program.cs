using System;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using static System.Net.Mime.MediaTypeNames;

namespace gruppindelning
{
    internal class Program
    {
        static void Main(string[] args)
        {



            // Skapa en application som plockar var tredje namn ur listan, och skapar grupper om tre personer, totalt 6 grupper.
            //• Namnen ska plockas ut så att grupperna inte har personen efter varandra, I samma grupp
            //• Sortera eleverna I bokstavsorning I respektive grupp
            //• Första Gruppen ska se ut såhär: 
            //• Anna, Karin, Lars
            //• Ändra koden så det går att ändra antalet personer I varje grupp, t ex 2, 3, 4, 5..personer I varje grupp



            string[] persons = { "Karin", "Anders", "Johan", "Eva", "Maria", "Mikael", "Anna", "Sara", "Erik", "Per", "Christina", "Lena", "Lars", "Emma", "Kerstin", "Karl", "Marie", "Peter" };

            while (true)
            {
                string group = "";
                Console.WriteLine("Enter the number of members per group:");
                if (int.TryParse(Console.ReadLine(), out int groupMembers))
                {
                    int numberOfGroups = persons.Length / groupMembers;

                    for (int i = 0; i < numberOfGroups; i++)
                    {

                        for (int j = i; j < persons.Length; j += numberOfGroups)
                        {
                            group += persons[j] + "\t";

                        }

                        Console.WriteLine(group);
                        group = "";
                    }
                }
                else
                {
                    Console.WriteLine("felaktig inmatning");
                }
            }



            //}while (true)
            //{
            //    Console.WriteLine("Enter the number of members per group:");
            //    if (int.TryParse(Console.ReadLine(), out int groupMembers))
            //    {
            //        int numberOfGroups = persons.Length/ groupMembers;
            //        for (int i = 0; i < numberOfGroups; i++)
            //        {
            //            string[] group = new string[numberOfGroups];
            //            int index = 0;
            //            for (int j = i; j < persons.Length; j += numberOfGroups)
            //            {
            //                group[index] = persons[j];
            //                index++;
            //            }
            //            Array.Sort(group);
            //            foreach (string person in group)
            //            {
            //                Console.Write(person);
            //            }
            //            Console.WriteLine();
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("felaktig inmatning");
            //    }
            //}

        }
    }
}
