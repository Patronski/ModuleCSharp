using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Engine
{
    public string model;
    public string power;
    public string displacement;
    public string efficiency;
    public Engine(string model, string power)
    {
        this.model = model;
        this.power = power;
        displacement = "n/a";
        efficiency = "n/a";
    }
}

public class Car
{
    public string model;
    public Engine engine;
    public string engineName;
    public string weight;
    public string color;
    public Car(string model, String engineName)
    {
        this.model = model;
        this.engineName = engineName;
        weight = "n/a";
        color = "n/a";
    }
}

public class Program
{
    public static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        List<Engine> listEngines = new List<Engine>();
        List<Car> listCars = new List<Car>();

        for (int i = 0; i < N; i++)
        {
            string[] info = Console.ReadLine().Trim().Split();

            Engine engine = new Engine(info[0], info[1]);

            if (info.Length > 2)
            {
                int displacement;
                if (int.TryParse(info[2], out displacement))
                {
                    engine.displacement = info[2];
                }
                else
                {
                    engine.efficiency = info[2];
                }
            }
            if (info.Length > 3)
            {
                engine.efficiency = info[3];
            }

            listEngines.Add(engine);
        }

        N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            string[] info = Console.ReadLine().Trim().Split();

            Car car = new Car(info[0], info[1]);

            if (info.Length > 2)
            {
                int weight;
                if(int.TryParse(info[2], out weight))
                {
                    car.weight = info[2];
                }
                else
                {
                    car.color = info[2];
                }
            }
            if (info.Length > 3)
            {
                car.color = info[3];
            }

            car.engine = listEngines.Find(e => e.model == car.engineName);

            listCars.Add(car);
        }

        foreach (var car in listCars)
        {
            Console.WriteLine("{0}:", car.model);
            Console.WriteLine("  {0}:", car.engine.model);
            Console.WriteLine("    Power: {0}", car.engine.power);
            Console.WriteLine("    Displacement: {0}", car.engine.displacement);
            Console.WriteLine("    Efficiency: {0}", car.engine.efficiency);
            Console.WriteLine("  Weight: {0}", car.weight);
            Console.WriteLine("  Color: {0}", car.color);
        }
    }
}

