using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6PrimeChecker
{
    public class Number
    {
        private int num;
        private bool isPrime; 
        public Number(int n)
        {
            num = n;
            isPrime = true;
        }
        public bool checkPrime()
        {
            isPrime = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
        public int findNextPrime()
        {
            for (int cheking = num + 1; ; cheking++)
            {
                isPrime = true;
                for (int j = 2; j <= Math.Sqrt(cheking); j++)
                {
                    if (cheking % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                    return cheking;
            }
        }
    }

    class P6PrimeChecker
    {
        static void Main(string[] args)
        {
            int numberToCheck = int.Parse(Console.ReadLine());
            Number number = new Number(numberToCheck);

            Console.WriteLine($"{number.findNextPrime()}, {number.checkPrime().ToString().ToLower()}");
        }
    }
}
