using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2UniqueStudentNames
{
    public class Student
    {
        public string name;
        public Student(string n)
        {
            name = n;
        }
    }

    public class StudentGroup
    {
        public static HashSet<string> set;
        public StudentGroup(string n)
        {
            set.Add(n);
        }

        static StudentGroup()
        {
            set = new HashSet<string>();
        }
    }
    class P2UniqueStudentNames
    {
        static void Main()
        {
            string inp = Console.ReadLine();
            while (inp != "End")
            {
                Student s = new Student(inp);
                StudentGroup sg = new StudentGroup(s.name);
                inp = Console.ReadLine();
            }

            Console.WriteLine(StudentGroup.set.Count);
        }
    }
}
