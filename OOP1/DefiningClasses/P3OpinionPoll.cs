using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpinionPoll
{
    //public class Person
    //{
    //    private string name;
    //    private int age;
    //    public Person(string name, int age)
    //    {
    //        this.name = name;
    //        this.age = age;
    //    }

    //    public string Name
    //    {
    //        get { return this.name}
    //    }
    //}
    class Person
    {
        public string name;
        public int age;
        public Person()
        {
            this.name = "No name";
            this.age = 1;
        }
        public Person(int age)
        {
            this.name = "No name";
            this.age = age;
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numOfP = int.Parse(Console.ReadLine());
            List<Person> list = new List<Person>();

            for (int i = 0; i < numOfP; i++)
            {
                string[] newP = Console.ReadLine().Split();

                string name = newP[0];
                int age = int.Parse(newP[1]);

                Person tereza = new Person(name, age);
                list.Add(tereza);
            }

            list.Where(x => x.age > 30)
                .OrderBy(x => x.name)
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.name} - {x.age}"));
        }
    }
}
