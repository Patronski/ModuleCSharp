using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8
{
    public class VolumeCalculator
    {
        public static double triangularPrism(double baseSide, double height, double length)
        {
            double res = (baseSide * height) / 2;
            return res * length;
        }
        public static double cube(double sideLength)
        {
            return sideLength * sideLength * sideLength;
        }
        public static double cylinder(double radius, double height)
        {
            return radius * radius * Math.PI * height;
        }
    }

    class P8
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] info = input.Split();
                switch (info[0])
                {
                    case "Cube":
                        Console.WriteLine("{0:f3}", VolumeCalculator.cube(double.Parse(info[1])));
                        break;
                    case "Cylinder":
                        Console.WriteLine("{0:f3}", VolumeCalculator.cylinder(double.Parse(info[1]), double.Parse(info[2])));
                        break;
                    case "TrianglePrism":
                        Console.WriteLine("{0:f3}", VolumeCalculator.triangularPrism(double.Parse(info[1]), double.Parse(info[2]), double.Parse(info[3])));
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine();
            }
        }
    }
}
