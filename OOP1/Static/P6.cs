using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6
{
    class P6
    {
        public const double Planck = 6.62606896e-34;
        public const double Pi = 3.14159;

        static void Main(string[] args)
        {

            //{Planck constant} / (2 * {Pi constant})
            Console.WriteLine(Planck / (2 * Pi));
        }
    }
}
