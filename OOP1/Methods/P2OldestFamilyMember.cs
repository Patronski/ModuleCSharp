using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2OldestFamilyMember
{
    public class Person
    {
        private string name;
        private int age;
        public string Name => this.name;
        public int Age => this.age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", name, age);
        }
    }

    static public class Family
    {
        static private List<Person> family;

        static Family()
        {
            family = new List<Person>();
        }

        static public void AddMember(Person p)
        {
            family.Add(p);
        }

        static public Person GetOldestMember()
        {
            return family.OrderByDescending(f => f.Age).FirstOrDefault();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < N; i++)
            {
                string[] info = Console.ReadLine().Trim().Split();

                Person member = new Person(info[0], int.Parse(info[1]));


                Family.AddMember(member);
            }

            Console.WriteLine(Family.GetOldestMember());
        }
    }
}
