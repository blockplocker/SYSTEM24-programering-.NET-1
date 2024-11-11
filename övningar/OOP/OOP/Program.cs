namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OOPA.Demo.Run();
            Console.WriteLine("------------------------------------");
            OOPB.Demo.Run();
            Console.WriteLine("------------------------------------");
            OOPC.Demo.Run();
            Console.WriteLine("------------------------------------");
            OOPD.Demo.Run();
            Console.WriteLine("------------------------------------");
            OOPE.Demo.Run();


            List<int> intList = new List<int>() { 1, 2, 3, 4, 5 };
            intList.Add(6);
            int t = intList[1];

            IEnumerable<int> intList2 = new List<int>() { 1, 2, 3, 4, 5 };   //IEnumerable är ett interface som inte har Add och indexering men tar mycket mindre minne
            //intList2.Add(6);         lägga till finns inte i detta interface
            //int t2 = intList2[1];    indexering finns inte i detta interface


        }
    }
}
