using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddLines
{
    class OddLines
    {
        static void Main()
        {

            string myOutputPath = @"C:\Users\DonchoP\Desktop\FilesAndDirectoriesTests\02_OddLines\MyOutput.txt";
            string inputPath = @"C:\Users\DonchoP\Desktop\FilesAndDirectoriesTests\02_OddLines\01_OddLinesIn.txt";
            string expectedOutputPath = @"C:\Users\DonchoP\Desktop\FilesAndDirectoriesTests\02_OddLines\01_OddLinesOut.txt";

            //var reader = File.Open(inputPath, FileMode.Open);
            using (File.Create(myOutputPath)) { }
            var writer = File.AppendText(myOutputPath);

            using (var reader = File.OpenText(inputPath))
            {
                using (writer)
                {
                    string line = reader.ReadLine();
                    int counter = 0;
                    while (line != null)
                    {
                        if (counter % 2 != 0)
                        {
                            writer.WriteLine(line);
                        }
                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
