using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Tire
{
    public double pressure;
    public int age;
    public Tire(double p, int a)
    {
        pressure = p;
        age = a;
    }
}

public class Cargo
{
    public int weight;
    public string type;
    public Cargo(int w, string t)
    {
        weight = w;
        type = t;
    }
}

public class Engine
{
    public int speed;
    public int power;
    public Engine(int s, int p)
    {
        speed = s;
        power = p;
    }
}

public class Car
{
    public string model;
    public Engine engine;
    public Cargo cargo;
    public Tire[] tires;
    public Car(string model, int speed, int power, int weight, string type,
                double pressure1, int age1, double pressure2, int age2,
                double pressure3, int age3, double pressure4, int age4)
    {
        this.model = model;
        engine = new Engine(speed, power);
        cargo = new Cargo(weight, type);
        tires = new Tire[4];
        tires[0] = new Tire(pressure1, age1);
        tires[1] = new Tire(pressure2, age2);
        tires[2] = new Tire(pressure3, age3);
        tires[3] = new Tire(pressure4, age4);
    }
    public override string ToString()
    {
        return string.Format("{0}", model);
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

            Car qna = new Car(info[0], int.Parse(info[1]), int.Parse(info[2]), int.Parse(info[3]), info[4],
                            double.Parse(info[5]), int.Parse(info[6]), double.Parse(info[7]), int.Parse(info[8]),
                            double.Parse(info[9]), int.Parse(info[10]), double.Parse(info[11]), int.Parse(info[12]));
            listCars.Add(qna);
        }

        string command = Console.ReadLine();

        if (command == "fragile")
        {
            listCars.Where(x => x.cargo.type == "fragile" && x.tires.Any(y => y.pressure < 1))
                    .Select(x => x.model)
                    .ToList()
                    .ForEach(qna => Console.WriteLine(qna));
        }
        else if (command == "flamable")
        {
            listCars.Where(x => x.cargo.type == "flamable" && x.engine.power > 250)
                    .Select(x => x.model)
                    .ToList()
                    .ForEach(qna => Console.WriteLine(qna));
        }
    }
}

