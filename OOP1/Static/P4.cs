using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4
{
    class P4
    {
        static void Main(string[] args)
        {
            long inStock = 0;
            long drinked = 0;

            string input = Console.ReadLine();
            while (input != "End")
            {
                int[] info = input.Split().Select(int.Parse).ToArray();
                inStock += info[0];
                drinked += info[1];
                input = Console.ReadLine();
            }

            Console.WriteLine($"{inStock - drinked} {drinked}");
        }
    }
}
