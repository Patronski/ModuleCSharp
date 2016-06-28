using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    private string name;
    public string Name
    {
        get { return name; }
        set
        {
            if (string.Empty == name)
            {
                throw new ArgumentException("Name cannot be empty.");
            }
            name = value;
        }
    }

    private decimal money;
    public decimal Money
    {
        get { return money; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            money = value;
        }
    }

    private List<Product> bagOfProducts;
    public Person()
    {
        bagOfProducts = new List<Product>();
    }
    public string BagOfProducts()
    {
        if (bagOfProducts.Count == 0)
        {
            return Name + " - Nothing bought";
        }

        return Name + " - " + string.Join(", ", bagOfProducts.Select(p => p.name));
    }
    public void buyProduct(Product product)
    {
        if (Money < product.price)
        {
            Console.WriteLine($"{Name} can't afford {product.name}");
        }
        else
        {
            bagOfProducts.Add(product);
            Money -= product.price;
            Console.WriteLine($"{Name} bought {product.name}");
        }
    }
}

public class Product
{
    public string name;
    public string Name
    {
        get { return name; }
        set
        {
            if (string.Empty == name)
            {
                throw new ArgumentException("Name cannot be empty.");
            }
            name = value;
        }
    }

    public decimal price;
    public decimal Price
    {
        get { return price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Price can not be negative");
            }
            price = value;
        }
    }
}

class Program
{
    static void Main()
    {
        try
        {
            string[] persons = Console.ReadLine().Trim().Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);
            string[] products = Console.ReadLine().Trim().Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);

            List<Person> listPersons = new List<Person>();
            for (int i = 0; i < persons.Length; i += 2)
            {
                Person p = new Person();

                p.Name = persons[i];
                p.Money = decimal.Parse(persons[i + 1]);

                listPersons.Add(p);
            }

            List<Product> listProducts = new List<Product>();
            for (int i = 0; i < products.Length; i += 2)
            {
                Product p = new Product();

                p.name = products[i];
                p.price = decimal.Parse(products[i + 1]);

                listProducts.Add(p);
            }

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] info = input.Trim().Split();
                listPersons
                    .Find(p => p.Name == info[0])
                    .buyProduct(listProducts.Find(p => p.name == info[1]));

                input = Console.ReadLine();
            }

            foreach (var person in listPersons)
            {
                Console.WriteLine(person.BagOfProducts());
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

