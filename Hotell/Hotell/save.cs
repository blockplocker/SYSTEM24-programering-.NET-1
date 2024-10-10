using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotell
{
    internal class save
    {

        public static void saveToFile(string[,] occupants)
        {
            string[] floors = new string[occupants.GetLength(0)];

            for (int floor = 0; floor < occupants.GetLength(0); floor++)
            {
                string roomsOnFloor = "";
                for (int roomOnFloor = 0; roomOnFloor < occupants.GetLength(1); roomOnFloor++)
                {
                    roomsOnFloor += "|" + occupants[floor, roomOnFloor];
                }
                floors[floor] = roomsOnFloor;
            }

            File.WriteAllLines("hotellData.txt", floors);
        }


        public static string[,] getData()
        {
            string[] floors = File.ReadAllLines("hotellData.txt");

           
            int numFloors = floors.Length;
            int numRooms = floors[0].Split('|').Length -1; 

            string[,] occupants = new string[numFloors, numRooms];

            
            for (int floor = 0; floor < numFloors; floor++)
            {
                
                string[] rooms = floors[floor].Split('|');

                for (int room = 1; room < rooms.Length; room++)
                {
                    occupants[floor, room - 1] = rooms[room]; 
                }
            }

            return occupants;
        }


    }
}
