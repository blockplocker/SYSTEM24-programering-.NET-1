namespace Dark_and_darker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Base attributes
            double base_str = 12;
            double base_agi = 12;
            double base_resc = 18;

            // Display base attributes and base damage calculations
            Console.WriteLine("--- Base Attributes ---");
            Console.WriteLine("Base Strength: " + base_str);
            Console.WriteLine("Base Agility: " + base_agi);
            Console.WriteLine("Base Resourcefulness: " + base_resc);

            Console.WriteLine("\n--- Base Damage ---");
            Console.WriteLine("Bear Form Primary Attack Damage: " + Druid.CalcBearPrimaryAttack(base_str));
            Console.WriteLine("Bear Form Secondary Attack Damage: " + Druid.CalcBearSecondaryAttack(base_str));
            Console.WriteLine("Panther Form Primary Attack Damage: " + Druid.CalcPantherPrimaryAttack(base_agi));
            Console.WriteLine("Panther Form Secondary Attack Damage: " + Druid.CalcPantherSecondaryAttack(base_agi));
            Console.WriteLine("Chicken Form Primary Attack Damage: " + Druid.CalcChickenPrimaryAttack(base_resc));

            while (true)
            {

                // Input for updated attributes
                Console.WriteLine("\nEnter your updated Strength (STR): ");
                double updated_str = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter your updated Agility (AGI): ");
                double updated_agi = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter your updated Resourcefulness (RESC): ");
                double updated_resc = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n--- Updated Damage ---");
                Console.WriteLine("Bear Form Primary Attack Damage: " + Druid.CalcBearPrimaryAttack(updated_str));
                Console.WriteLine("Bear Form Secondary Attack Damage: " + Druid.CalcBearSecondaryAttack(updated_str));
                Console.WriteLine("Panther Form Primary Attack Damage: " + Druid.CalcPantherPrimaryAttack(updated_agi));
                Console.WriteLine("Panther Form Secondary Attack Damage: " + Druid.CalcPantherSecondaryAttack(updated_agi));
                Console.WriteLine("Chicken Form Primary Attack Damage: " + Druid.CalcChickenPrimaryAttack(updated_resc));
            }

        }
    }

}
