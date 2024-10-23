using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dark_and_darker
{
    internal class DamageCalculator
    {
        public static void MeleDamage()
        {
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Calculate Melee Damage");
                Console.WriteLine("2. Exit");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CalculateDamageOption();
                        break;
                    case "2":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private static void CalculateDamageOption()
        {
            Console.Write("Enter weapon damage: ");
            if (!double.TryParse(Console.ReadLine(), out double weaponDamage))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            Console.Write("Enter physical damage bonus percentage: ");
            if (!double.TryParse(Console.ReadLine(), out double physicalDamageBonusPercentage))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            double damage = DamageCalculator.CalculateMeleeDamage(weaponDamage, physicalDamageBonusPercentage);
            Console.WriteLine($"Total Damage: {damage}");
        }

        public static double CalculateMeleeDamage(double weaponDamage, double physicalDamageBonusPercentage)
        {
            // Calculate the total damage
            double totalDamage = weaponDamage + (weaponDamage * (physicalDamageBonusPercentage / 100));
            return totalDamage;
        }
    }
}
