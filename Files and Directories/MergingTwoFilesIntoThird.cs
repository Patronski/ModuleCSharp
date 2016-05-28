using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergingTwoFilesIntoThird
{
    public class MergingTwoFilesIntoThird
    {
        public static void Main(string[] args)
        {
            string myOutputPath = @"C:\Users\DonchoP\Desktop\FilesAndDirectoriesTests\05_MergingFiles\MyOutput.txt";
            string fileOne = @"C:\Users\DonchoP\Desktop\FilesAndDirectoriesTests\05_MergingFiles\02_FileOne.txt";
            string fileTwo = @"C:\Users\DonchoP\Desktop\FilesAndDirectoriesTests\05_MergingFiles\02_FileTwo.txt";

            using (File.Create(myOutputPath)) { }


            using (var readFileOne = File.OpenText(fileOne))
            {
                using(var readFileTwo = File.OpenText(fileTwo))
                {
                    using(var writer = File.AppendText(myOutputPath))
                    {
                        string fileOneLine = readFileOne.ReadLine();
                        string fileTwoLine = readFileTwo.ReadLine();

                        while(fileOneLine != null || fileTwoLine != null)
                        {
                            if (fileOneLine != null)
                            {
                                writer.WriteLine(fileOneLine);
                            }
                            if (fileTwoLine != null)
                            {
                                writer.WriteLine(fileTwoLine);
                            }

                            fileOneLine = readFileOne.ReadLine();
                            fileTwoLine = readFileTwo.ReadLine();

                        }
                    }
                }
            }
        } //end of main
    }
}
