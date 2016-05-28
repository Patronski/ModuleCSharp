using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetFolderSize
{
    class GetFolderSize
    {
        static void Main(string[] args)
        {
            string myFolder = @"C:\Users\DonchoP\Desktop\FilesAndDirectoriesTests\05_MergingFiles";

            if (Directory.Exists(myFolder))
            {
                string[] fileNames = Directory.GetFiles(myFolder);
                DirectoryInfo di = new DirectoryInfo(myFolder);
                FileInfo[] fi = di.GetFiles();
                Console.WriteLine("DIRECTORY {0} conteins following files:", di.Name);

                double inMB = 0;

                foreach (FileInfo f in fi)
                {
                    inMB += f.Length ;
                    Console.WriteLine("the size of {0} is {1} bytes", f.Name, f.Length);

                }
                Console.WriteLine( "total {0:0.##} Megabytes", inMB / (1024 * 1024));
            }
        }
    }
}
