using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dark_and_darker
{
    internal class Druid
    {
        public static void calculateDamage()
        {
            while (true)
            {
                // Base attributes
                double str = 12;
                double agi = 12;
                double resc = 18;

                Console.WriteLine("\n--- Choose Your Form ---");
                Console.WriteLine("1. Bear Form");
                Console.WriteLine("2. Panther Form");
                Console.WriteLine("3. Chicken Form");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "4")
                {
                    break;
                }

                switch (choice)
                {
                    case "1":
                        str = GetUpdatedValue("Strength", str);
                        DisplayBearForm(str);
                        break;
                    case "2":
                        agi = GetUpdatedValue("Agility", agi);
                        DisplayPantherForm(agi);
                        break;
                    case "3":
                        resc = GetUpdatedValue("Resourcefulness", resc);
                        DisplayChickenForm(resc);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private static double GetUpdatedValue(string attributeName, double Value)
        {
            while (true)
            {

                Console.Write($"Enter updated value for {attributeName} (current: {Value}): ");
                if (double.TryParse(Console.ReadLine(), out double updatedValue))
                {
                    return updatedValue;
                }
                else
                {
                    Console.WriteLine("Invalid input. Using base value.");
                }
            }
        }

        private static void DisplayBearForm(double str)
        {
            Console.WriteLine("\n--- Bear Form ---");
            Console.WriteLine("Base Strength: " + str);
            Console.WriteLine("Primary Attack Damage: " + (15 + 0.75 * str));
            Console.WriteLine("Secondary Attack Damage: " + (35 + 0.75 * str));
        }

        private static void DisplayPantherForm(double agi)
        {
            Console.WriteLine("\n--- Panther Form ---");
            Console.WriteLine("Base Agility: " + agi);
            Console.WriteLine("Primary Attack Damage: " + (10 + 0.75 * agi));
            Console.WriteLine("Secondary Attack Damage: " + (13 + 0.75 * agi));
        }

        private static void DisplayChickenForm(double resc)
        {
            Console.WriteLine("\n--- Chicken Form ---");
            Console.WriteLine("Base Resourcefulness: " + resc);
            Console.WriteLine("Primary Attack Damage: " + (10 + 0.75 * resc));
        }
    }
}
