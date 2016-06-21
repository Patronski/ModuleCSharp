using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Employee
{
    public string name;
    public decimal salary;
    public string position;
    public string department;
    public string email;
    public int age;

    public Employee(string n, decimal sal, string pos, string dep)
    {
        name = n;
        salary = sal;
        position = pos;
        department = dep;
        email = "n/a";
        age = -1;
    }
    public Employee(string n, decimal sal, string pos, string dep, string em)
        : this(n, sal, pos, dep)
    {
        email = em;
        age = -1;
    }
    public Employee(string n, decimal sal, string pos, string dep, int a)
        : this(n, sal, pos, dep)
    {
        email = "n/a";
        age = a;
    }
    public Employee(string n, decimal sal, string pos, string dep, string em, int a)
        : this(n, sal, pos, dep)
    {
        email = em;
        age = a;
    }
    public Employee(string n, decimal sal, string pos, string dep, int a, string em)
        : this(n, sal, pos, dep)
    {
        email = em;
        age = a;
    }
}

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        List<Employee> list = new List<Employee>();

        for (int i = 0; i < N; i++)
        {
            string[] info = Console.ReadLine().Split();
            Employee tereza = null;

            if (info.Length == 4)
            {
                tereza = new Employee(info[0], decimal.Parse(info[1]), info[2], info[3]);

            }
            else if (info.Length == 5)
            {
                int age;
                if (int.TryParse(info[4], out age))
                {
                    tereza = new Employee(info[0], decimal.Parse(info[1]), info[2], info[3], age);
                }
                else
                {
                    tereza = new Employee(info[0], decimal.Parse(info[1]), info[2], info[3], info[4]);
                }
            }
            else if (info.Length == 6)
            {
                int age;
                if (int.TryParse(info[5], out age))
                {
                    tereza = new Employee(info[0], decimal.Parse(info[1]), info[2], info[3], info[4], age);
                }
                else
                {
                    int.TryParse(info[4], out age);
                    tereza = new Employee(info[0], decimal.Parse(info[1]), info[2], info[3], age, info[5]);
                }
            }

            list.Add(tereza);
        }

        //order
        var result = list.GroupBy(x => x.department)
                    .OrderByDescending(e => e.Average( emp => emp.salary))
                    .Select(e => new
                    {
                        Department = e.Key,
                        Employees = e.OrderByDescending(emp => emp.salary),
                    })
                    .FirstOrDefault();

        Console.WriteLine($"Highest Average Salary: {result.Department}");


        foreach (var e in result.Employees)
        {
            Console.WriteLine($"{e.name} {e.salary} {e.email:F2} {e.age}");
        }
    }
}

