using System.Runtime.Intrinsics.Arm;
using System.Xml.Linq;

namespace Hotell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] occupants;
            if (File.Exists("hotellData.txt"))
            {
                occupants = save.getData();
            }
            else
            {
                occupants = new string[3, 4];
            }


            while (true)
            {
                Console.Clear();

                Display.DisplayHotell(occupants);

                occupants = Booking.Book(occupants);

                save.saveToFile(occupants);
            }

           
        }
    }
}
