using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFromSpecifiedLine
{
    class ReadFromSpecifiedLine
    {
        static void Main(string[] args)
        {
            string textFile = @"C:\Users\DonchoP\Desktop\FilesAndDirectoriesTests\05_MergingFiles\01_FileTwo.txt";

            var reader = File.ReadLines(textFile);

            int lineNumber = int.Parse(Console.ReadLine()) - 1; // print form this index
            for (int i = lineNumber; i < reader.LongCount(); i++)
            {
                Console.WriteLine(reader.ElementAt(i));
            }
        }
    }
}
