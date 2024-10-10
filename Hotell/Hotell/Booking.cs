using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Hotell
{
    internal class Booking
    {
        public static string[,] Book(string[,] occupants)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Rum:");
            string room = Console.ReadLine();

            if (int.TryParse(room, out int roomNr))
            {
                int rum = 1;
                for (int floor = 0; floor < occupants.GetLength(0); floor++)
                {
                    for (int roomOnFloor = 0; roomOnFloor < occupants.GetLength(1); roomOnFloor++)
                    {
                        rum = occupants.GetLength(1) * floor + roomOnFloor + 1;
                        if (rum == roomNr)
                        {
                            occupants[floor, roomOnFloor] = name;
                        }
                    }
                }
            }


            //char[] floorAndRoom = room.ToCharArray();

            //int floor = int.Parse(floorAndRoom[0].ToString());
            //int roomNr = int.Parse(floorAndRoom[1].ToString());
            //if (name == "")
            //{
            //    name = null;
            //}
            //occupants[floor, roomNr] = name;


            return occupants;
        }

    }
}
