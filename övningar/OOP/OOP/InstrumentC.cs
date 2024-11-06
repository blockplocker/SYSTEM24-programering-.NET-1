using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPC
{

    class Demo
    {

        public static void Run()
        {
            //Instrument myinstrument = new Instrument();
            Instrument mytrumpet = new Trumpet();
            Instrument mypiano = new Piano();

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
    internal abstract class Instrument
    {
        public abstract int Weight { get; set; }
        public abstract void sound();
        public void RegularMethod()
        {
            Console.WriteLine("Något allmänt händer");
        }
    }

    class Trumpet : Instrument
    {
        public override int Weight { get; set; } = 2;
        public override void sound()
        {
            Console.WriteLine("Trumpeten låter: Tuut tuut!");
        }
    }

    class Piano : Instrument
    {
        public override int Weight { get; set; } = 250;
        public override void sound()
        {
            Console.WriteLine("Pianot låter: Plink plonk!");
        }
    }
}
