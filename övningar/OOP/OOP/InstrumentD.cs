using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPD
{

    class Demo
    {

        public static void Run()
        {
            //Instrument myinstrument = new Instrument();
            IInstrument mytrumpet = new Trumpet();
            IInstrument mypiano = new Piano();

            //myinstrument.sound();
            //Console.WriteLine("Vikt: " + myinstrument.Weight);

            mytrumpet.sound();
            Console.WriteLine("Vikt: " + mytrumpet.Weight);
            mytrumpet.RegularMethod();

            mypiano.sound();
            Console.WriteLine("Vikt: " + mypiano.Weight);
            mypiano.RegularMethod();

        }
    }
    interface IInstrument
    {
        public int Weight { get; set; }
        public void sound();
        public void RegularMethod()
        {
            Console.WriteLine("Något allmänt händer");
        }
    }
    class Trumpet : IInstrument
    {
        public int Weight { get; set; } = 2;
        public void sound()
        {
            Console.WriteLine("Trumpeten låter: Tuut tuut!");
        }
    }
    class Piano : IInstrument
    {
        public int Weight { get; set; } = 250;
        public void sound()
        {
            Console.WriteLine("Pianot låter: Plink plonk!");
        }
    }
}
