using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrisDemo
{
    internal class IntMatris
    {
        public static void ShowDemo()
        {
            int[,] myTable = new int[3, 4];
            myTable[0, 0] = 1;
            myTable[0, 1] = 2;
            myTable[0, 2] = 3;
            myTable[0, 3] = 4;

            myTable[1, 0] = 5;
            myTable[1, 1] = 6;
            myTable[1, 2] = 7;
            myTable[1, 3] = 8;

            myTable[2, 0] = 9;
            myTable[2, 1] = 10;
            myTable[2, 2] = 11;
            myTable[2, 3] = 12;

            int[] sum = new int[myTable.GetLength(1)];

            for (int row = 0; row < myTable.GetLength(0); row++)
            {
                for (int column = 0; column < myTable.GetLength(1); column++)
                {
                    Console.Write(myTable[row, column] + "\t");
                    sum[column] += myTable[row, column];
                }
                Console.WriteLine();
            }

            for (int column = 0; column < myTable.GetLength(1);column++)
            {
                Console.Write(sum[column] + "\t");
            }
        }
    }
}
