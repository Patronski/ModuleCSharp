using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Car
{
    public string model;
    public decimal fuelAmount;
    public decimal fuelCostPerKM;
    public int distanceTraveled;
    public Car(string model, decimal fuelAmount, decimal fuelCostPerKM)
    {
        this.model = model;
        this.fuelAmount = fuelAmount;
        this.fuelCostPerKM = fuelCostPerKM;
        distanceTraveled = 0;
    }
    public bool tryDriveDistance(int km)
    {
        if (fuelCostPerKM * km <= fuelAmount)
        {
            this.fuelAmount -= fuelCostPerKM * km;
            this.distanceTraveled += km;
            return true;
        }
        else
        {
            return false;
        }
    }
}

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        List<Car> listCars = new List<Car>();

        for (int i = 0; i < N; i++)
        {
            string[] info = Console.ReadLine().Trim().Split();

            Car ivan = new Car(info[0], decimal.Parse(info[1]), decimal.Parse(info[2]));

            listCars.Add(ivan);
        }

        string drive = Console.ReadLine();

        while (drive != "End")
        {
            string[] driveInfo = drive.Trim().Split();
            string model = driveInfo[1];
            int distance = int.Parse(driveInfo[2]);

            var ivan = listCars.Find(c => c.model == model);
            if (!ivan.tryDriveDistance(distance))
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }

            drive = Console.ReadLine();
        }

        //print
        foreach (var ivan in listCars)
        {
            Console.WriteLine($"{ivan.model} {ivan.fuelAmount:F2} {ivan.distanceTraveled}");
        }

    }
}

