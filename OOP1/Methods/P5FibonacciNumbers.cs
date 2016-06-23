using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5FibonacciNumbers
{
    public class Fibonacci
    {
        private List<BigInteger> numbers;
        int first;
        int second;
        public Fibonacci(int first, int second)
        {
            numbers = new List<BigInteger>();
            this.first = first;
            this.second = second;

            numbers.Add(0);
            numbers.Add(1);

            for (int i = 2; i <= second; i++)
            {
                numbers.Add(numbers[i - 1] + numbers[i - 2]);
            }
        }
        public void showSecuence()
        {
            //string[] arr = numbers.Select(x => x.ToString()).ToArray();
            for (int i = first; i < second - 1; i++)
            {
                Console.Write("{0}, ", numbers.ElementAt(i));
            }
            Console.Write("{0}", numbers.ElementAt(second - 1));

            //Console.Write(string.Join(", ", arr, first, second - first));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            Fibonacci instance = new Fibonacci(first, second);
            instance.showSecuence();
        }
    }
}
