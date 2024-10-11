using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dark_and_darker
{
    internal class Druid
    {

        // Druid's Bear Form Primary Attack
        public static double CalcBearPrimaryAttack(double str)
        {
            return 15 + 0.75 * str;
        }

        // Druid's Bear Form Secondary Attack
        public static double CalcBearSecondaryAttack(double str)
        {
            return 35 + 0.75 * str;
        }

        // Druid's Panther Form Primary Attack
        public static double CalcPantherPrimaryAttack(double agi)
        {
            return 10 + 0.75 * agi;
        }

        // Druid's Panther Form Secondary Attack
        public static double CalcPantherSecondaryAttack(double agi)
        {
            return 13 + 0.75 * agi;
        }

        // Druid's Chicken Form Primary Attack
        public static double CalcChickenPrimaryAttack(double resc)
        {
            return 10 + 0.75 * resc;
        }

    }
}
