using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace P1ClassBox
{
    public class Box
    {
        private decimal length;
        private decimal width;
        private decimal height;

        public decimal Length
        {
            get
            {
                return length;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");
                }
                length = value;
            }
        }
        public decimal Width
        {
            get
            {
                return width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
                }
                width = value;
            }
        }
        public decimal Height
        {
            get
            {
                return height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");
                }
                height = value;
            }
        }


        public Box(decimal l, decimal w, decimal h)
        {
            Length = l;
            Width = w;
            Height = h;
        }

        public decimal SurfaceArea()
        {
            //2lw + 2lh + 2wh
            return 2 * length * width + 2 * length * height + 2 * width * height;
        }
        public decimal LateralSurfaceArea()
        {
            // 2lh + 2wh
            return 2 * length * height + 2 * width * height;
        }
        public decimal Volume()
        {
            return length * width * height;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());


            decimal l = decimal.Parse(Console.ReadLine());
            decimal w = decimal.Parse(Console.ReadLine());
            decimal h = decimal.Parse(Console.ReadLine());

            Box box = new Box(l, w, h);
            //Console.WriteLine("Surface Area - {0:f2}", box.SurfaceArea());
            //Console.WriteLine("Lateral Surface Area - {0:f2}", box.LateralSurfaceArea());
            //Console.WriteLine("Volume - {0:f2}", box.Volume());
        }
    }
}
