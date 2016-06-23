using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3LastDigitName
{
    static public class Number
    {
        private static int num;
        public static void setNum(int num)
        {
             Number.num = num;
        }

        public static void englishNameOfLastDigit()
        {
            var str = num.ToString();
            int digit = int.Parse(str[str.Length - 1].ToString());
            Console.WriteLine(digits[digit]);
        }

        static private string[] digits = new string[]
        {
            "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"
        };
    }

    class Program
    {
        static void Main(string[] args)
        {
            Number.setNum(int.Parse(Console.ReadLine()));
            Number.englishNameOfLastDigit();
        }
    }
}
