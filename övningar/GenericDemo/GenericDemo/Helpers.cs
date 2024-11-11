using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    internal class Helpers
    {
        public void writeLength<T>(T anyVariable)
        {
            //int x = anyVariable.Length;

            string x = "";
            if(anyVariable is not string)
            {
                x = anyVariable.ToString();
            }
            else
            {
                x = anyVariable as string;
            }

            Console.WriteLine("Värdet på " + anyVariable + " har " + x.Length + " antal tecken.");
        }

        public void ObjectInformation<T>(T anyObject)
        {
            int age = 0;
            int speed = 0;
            string info = "";
            if(anyObject is Car)
            {
                age = (anyObject as Car).Age;
                speed = (anyObject as Car).Speed;
                info = "Drivs på " + (anyObject as Car).Fuel;
            }
            else if (anyObject is Person)
            {
                age = (anyObject as Person).Age;
                speed = (anyObject as Person).Speed;
                info = "Namnet är " + (anyObject as Person).Name;
            }

            Console.WriteLine("Objectet föddes " + (DateTime.Now.Year - age)
                + " Hastigheten på objectet är " + Math.Round(speed/3.6) + " m/s. "
                + info);
        }
    }
}
