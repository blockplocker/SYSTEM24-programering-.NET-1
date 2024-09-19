using System.Collections.Generic;
using System;

namespace Bish_Bosh
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  skriv ett console - app som heter ‘Bish - Bosh’. 
            //◦ Bish - Bosh listar alla tal mellan 1 och valfritt tal, som ska matas in av användaren.
            //◦ Det ska gå att välja två ytterligare tal, sk Bish och Bosh - tal, även de matas in av användaren.
            //◦ Sedan loopas talen från 1 till det valfria talet igenom.

            //◦ Om talet är jämnt delbart med Bish - talet visas ‘Bish’ istället för talet.
            //◦ Om talet är jämnt delbart med Bosh - talet visas ‘Bosh’ istället för talet.
            //◦ Om talet är jämt delbart med både Bish och Bosh-talet visas ’Bish - Bosh’ istället för talet.
            //◦ I exemplet är Bish-talet 4 och Bosh - talet är 6

            int getNumber(string text)
            {
                int result;

                while (true)
                {

                    Console.WriteLine(text);
                    string input = Console.ReadLine();

                    if (Int32.TryParse(input, out result) && result > 0)
                    {
                        return result;
                    }
                    else
                    {
                        Console.WriteLine("invalid pls try again");
                    }
                }
            }

            int maxNumber = getNumber("How high should Bish Bosh go to:");

            int bish = getNumber("What number is bish:");

            int bosh = getNumber("What number is bosh:");

            string toPrint = "";

            for (int i = 0; i < maxNumber; i++)
            {
                //toPrint = (i % bish == 0 && i % bosh == 0) ? "bish - bosh" : (i % bish == 0) ? "bish" : (i % bosh == 0) ? "bosh" : i.ToString();

                if (i % bish == 0 && i % bosh == 0)
                {
                    toPrint = "bish - bosh";
                }
                else if (i % bish == 0)
                {
                    toPrint = "bish";
                }
                else if (i % bosh == 0)
                {
                    toPrint = "bosh";
                }
                else
                {
                    toPrint = i.ToString();
                }

                Console.Write($"{toPrint} ");

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Sucsess!!");
            string end = Console.ReadLine();

        }
    }
}
