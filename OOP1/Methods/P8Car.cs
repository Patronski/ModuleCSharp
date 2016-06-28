using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8Car
{
    public class Car
    {
        public double speed;
        public double fuelLeft;
        public double fuelPer100;
        public Car(double a, double b, double c)
        {
            speed = a;
            fuelLeft = b;
            fuelPer100 = c;
        }
    }

    class P8Car
    {
        static void Main()
        {
            double[] carInfo = Console.ReadLine().Trim().Split().Select(double.Parse).ToArray();
            Car car = new Car(carInfo[0], carInfo[1], carInfo[2]);
            double totalDistance = 0;
            long minutes = 0;

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] commands = input.Trim().Split();
                switch (commands[0])
                {
                    case "Travel":
                        double distance = double.Parse(commands[1]);
                        if(car.fuelLeft * car.speed > distance)
                        {

                        }
                        break;
                    case "Refuel":
                        break;
                    case "Distance":
                        Console.WriteLine($"Total distance: {totalDistance:F1} kilometers");
                        break;
                    case "Time":
                        Console.WriteLine($"Total time: {minutes / 60} hours and {minutes % 60} minutes");
                        break;
                    case "Fuel":
                        Console.WriteLine($"Fuel left: {car.fuelLeft:F1} liters");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
