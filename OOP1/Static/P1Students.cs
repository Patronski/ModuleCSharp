using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Students
{
    public class Student
    {
        public string name;
        public static int instanceCounter;
        public Student(string n)
        {
            instanceCounter++;
            name = n;
        }
    }
    class P1Students
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            while (name != "End")
            {
                Student kojcho = new Student(name);

                name = Console.ReadLine();
            }
            Console.WriteLine(Student.instanceCounter);
        }
    }
}
