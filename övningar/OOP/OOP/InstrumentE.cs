using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPE
{

    class Demo
    {

        public static void Run()
        {
            IInstrument mytrumpet = new Trumpet();
            IInstrument mypiano = new Piano();

            
            mytrumpet.sound();
            Console.WriteLine("Ljudvolym: " + mytrumpet.Volume);
            //Console.WriteLine("Vikt: " + mytrumpet2.Weight); // Går ej att anropa Weight eftersom den inte finns i IInstrument
            mytrumpet.RegularMethod();

            mypiano.sound();
            Console.WriteLine("Ljudvolym: " + mypiano.Volume);
            mypiano.RegularMethod();


            // tillägg till alla properties och metoder 
            Trumpet mytrumpet2 = new Trumpet();
            Piano mypiano2 = new Piano();

            mytrumpet2.sound();
            Console.WriteLine("Ljudvolym: " + mytrumpet2.Volume);
            mytrumpet2.Price();
            Console.WriteLine("Vikt: " + mytrumpet2.Weight + " kg");
            //mytrumpet2.RegularMethod();  // Går ej att anropa RegularMethod() eftersom den inte finns i Trumpet

            mypiano2.sound();
            Console.WriteLine("Ljudvolym: " + mypiano2.Volume);
            mypiano2.Price();
            Console.WriteLine("Vikt: " + mypiano2.Weight + " kg");

        }
    }
    interface IInstrument
    {
        //public int Weight { get; set; }  Flyttad till IProduct
        public int Volume { get; set; }
        public void sound();
        public void RegularMethod()
        {
            Console.WriteLine("Något allmänt händer");
        }
    }
    interface IProduct
    {
        public int Weight { get; set; }
        public void Price();
    }
    class Trumpet : IInstrument , IProduct 
    {
        public int Volume { get; set; } = 110;
        public int Weight { get; set; } = 2;
        public void sound()
        {
            Console.WriteLine("Trumpeten låter: Tuut tuut!");
        }
        public void Price()
        {
            Console.WriteLine("Priset: " + Random.Shared.Next(500,2000) + " kr");
        }
    }
    class Piano : IInstrument , IProduct
    {
        public int Volume { get; set; } = 90;
        public int Weight { get; set; } = 250;
        public void sound()
        {
            Console.WriteLine("Pianot låter: Plink plonk!");
        }
        public void Price()
        {
            Console.WriteLine("Priset: " + Random.Shared.Next(5000, 20000) + " kr");
        }

    }
}
