using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    class Timer
    {
        static void Main(string[] args)
        {
            string myOutputPath = @"C:\Users\DonchoP\Desktop\FilesAndDirectoriesTests\05_MergingFiles\MyOutput.txt";
            string fileOne = @"C:\Users\DonchoP\Desktop\FilesAndDirectoriesTests\05_MergingFiles\csharp_basics_reference_sheet.pdf";
            string fileTwo = @"C:\Users\DonchoP\Desktop\FilesAndDirectoriesTests\05_MergingFiles\01_FileTwo.txt";

            var sw = Stopwatch.StartNew();
            string file1 = File.ReadAllText(fileTwo);
            sw.Stop();
            long timeOne = sw.ElapsedTicks;
            Console.WriteLine(timeOne);
            sw.Restart();

            sw.Start();
            string fil2 = File.ReadAllText(fileOne);
            sw.Stop();
            long timeTwo = sw.ElapsedTicks;
            Console.WriteLine(timeTwo);
        }
    }
}
