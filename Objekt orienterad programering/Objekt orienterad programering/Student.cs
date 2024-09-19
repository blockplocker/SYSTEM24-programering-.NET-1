using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objekt_orienterad_programering
{
    public class Student : person
    {
        public Student()
        {
            Name = "musten";
            Age = 21;
        }
        public static void print(Student student)
        {
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Age);
        }
    }
}
