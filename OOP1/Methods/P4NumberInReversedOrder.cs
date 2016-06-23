using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4NumberInReversedOrder
{
    static public class Number
    {
        private static decimal num;
        public static void setNum(decimal num)
        {
            Number.num = num;
        }
        
        static public void writeNum()
        {
            string str = new string(num.ToString().Reverse().ToArray());
            string str2 = str.ToString();
            Console.WriteLine(str2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Number.setNum(decimal.Parse(Console.ReadLine()));
            Number.writeNum();
        }
    }
}
