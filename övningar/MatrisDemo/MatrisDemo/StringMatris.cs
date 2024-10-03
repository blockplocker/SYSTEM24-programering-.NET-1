using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrisDemo
{
    internal class StringMatris
    {
        public static void ShowDemo()
        {
            string[,] animals =
            {
                {"Cat", "Dog", "Horse", "Elephant" },
                { "Chicken", "Human", "Kangaro", "Eagle" },
                { "Snake", "Shark", "Snail", "Dolphine" }
            };

            int[] legs = new int[] { 4, 2, 0 };

            for (int row = 0; row < animals.GetLength(0); row++)
            {
                Console.Write(legs[row] + " ben\t");

                for (int column = 0; column < animals.GetLength(1); column++)
                {
                    Console.Write(animals[row, column] + "\t");
                }


                Console.WriteLine();
            }
        }
    }
}
