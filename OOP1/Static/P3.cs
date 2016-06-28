using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3TemperatureConvertor
{
    
    class P3
    {
        public static double toFar(double cel)
        {
            return (double)cel * 1.8d + 32;
        }
        public static double toCel(double far)
        {
            return (double)(far - 32 )/ 1.8d ;
        }
        static void Main()
        {
            string input = Console.ReadLine().Trim();

            while (input != "End")
            {
                int deg = int.Parse(input.Split()[0]);
                string bsdjas = input.Split()[1];
                switch (bsdjas)
                {
                    case "Celsius":
                        Console.WriteLine($"{toFar(deg):f2} Fahrenheit");
                        break;
                    case "Fahrenheit":
                        Console.WriteLine($"{toCel(deg):f2} Celsius");
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine().Trim();
            }
        }
    }
}
