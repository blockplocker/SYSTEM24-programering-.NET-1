using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPB
{

    class Demo
    {

        public static void Run()
        {
            Instrument myinstrument = new Instrument();
            Instrument mytrumpet = new Trumpet();
            Instrument piano = new Piano();

            myinstrument.sound();
            Console.WriteLine("Vikt: " + myinstrument.Weight);

            mytrumpet.sound();
            Console.WriteLine("Vikt: " + mytrumpet.Weight);

            piano.sound();
            Console.WriteLine("Vikt: " + piano.Weight);

        }
    }
    internal class Instrument
    {
        public virtual int Weight { get; set; } = 123;
        public virtual void sound()
        {
            Console.WriteLine("Instrumentet låter: ?");
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
