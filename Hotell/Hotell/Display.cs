using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Hotell
{
    internal class Display
    {
        public static void DisplayHotell(string[,] occupants)
        {
            int roomNumber = 1;
            for (int floor = 0; floor < occupants.GetLength(0); floor++)
            {
                for (int roomOnFloor = 0; roomOnFloor < occupants.GetLength(1); roomOnFloor++)
                {
                    roomNumber = occupants.GetLength(1) * floor + roomOnFloor + 1;
                    //string roomNumber = (floor + "" + roomOnFloor);

                    //Console.Write(roomNumber + ":" + (
                    //    occupants[floor, roomOnFloor] == null ? "Tomt" :
                    //    occupants[floor, roomOnFloor]) + "\t");
                    

                    Console.Write($"{roomNumber}: {(occupants[floor, roomOnFloor] == null ? "Tomt" : occupants[floor, roomOnFloor])} \t");
                }
                Console.WriteLine();
            }
        }
    }
}
