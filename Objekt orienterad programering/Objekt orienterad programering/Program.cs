namespace Objekt_orienterad_programering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "musten";
            student.Age = 21;

            Console.WriteLine($"{student.Name} {student.Age}");
        }
    }
}
