using System;
using BashSoft;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            string myOutputPath = @"C:\Users\DonchoP\Desktop\FilesAndDirectoriesTests\03_LineNumbers\MyOutput.txt";
            string inputPath = @"C:\Users\DonchoP\Desktop\FilesAndDirectoriesTests\03_LineNumbers\01_LinesIn.txt";
            string expectedOutputPath = @"C:\Users\DonchoP\Desktop\FilesAndDirectoriesTests\03_LineNumbers\01_LinesOut.txt";
            
            string[] input = File.ReadAllLines(inputPath);
            using (File.Create(myOutputPath)) { }
            using(var writer = File.AppendText(myOutputPath))
            {
                for (int line = 0; line < input.Length; line++)
                {
                    writer.WriteLine("{0}. {1}", line + 1, input[line]);
                }
            }

            Tester.CompareContent(myOutputPath, expectedOutputPath);
        }
    }
}
