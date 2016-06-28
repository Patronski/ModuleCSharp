using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace P9PizzaTime
{
    public class Pizza
    {
        public string name;
        public int group;
        public Pizza(string name, int group)
        {
            this.name = name;
            this.group = group;
        }
    }


    public class P9PizzaTime
    {
        public static SortedDictionary<int, List<string>> groupPizzas(string[] names)
        {
            SortedDictionary<int, List<string>> dict = new SortedDictionary<int, List<string>>();

            for (int i = 0; i < names.Length; i++)
            {
                int group = int.Parse(names[i][0].ToString());
                if (!dict.ContainsKey(group))
                {
                    dict.Add(group, new List<string>());
                }
                dict[group].Add(names[i].Substring(1));
            }

            return dict;
        }

        static void Main()
        {
            string[] input = Console.ReadLine().Trim().Split();

            var d = groupPizzas(input);

            foreach (var p in d)
            {
                Console.WriteLine($"{p.Key} - {string.Join(", ", p.Value)}");
            }

            //MethodInfo[] methods = typeof(Pizza).GetMethods();
            //bool containsMethod = methods.Any(m => m.ReturnType.Name.Equals("SortedDictionary"));
            //if (!containsMethod)
            //{
            //    throw new Exception();
            //}

        }
    }
}
