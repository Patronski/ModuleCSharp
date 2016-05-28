using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    class Launcher
    {
        static void Main(string[] args)
        {
            ////IOManager.TraverseDirectory(@"D:\Torrents");
            //Data.InitializeData();
            ////Data.GetAllStudentsFromCourse("Unity");
            //Data.GetStudentScoresFromCourse("Unity", "Ivan");

            Tester.CompareContent(@"d\test1.txt", @"d\test2.txt");

            //IOManager.CreateDirectoryInCurrentFolder("pesho");
            //IOManager.TraverseDirectory(0);

            string inputPath = @"C:\Users\DonchoP\Documents\Visual Studio 2015\
                            Projects\AdvancedCSharp\BashSoft\BashSoft\bin\Debug\input";
            string myOutputPath = @"C:\Users\DonchoP\Documents\Visual Studio 2015\
                            Projects\AdvancedCSharp\BashSoft\BashSoft\bin\Debug\myOutput";
            string expectedOutputPath = @"C:\Users\DonchoP\Documents\Visual Studio 2015\
                            Projects\AdvancedCSharp\BashSoft\BashSoft\bin\Debug\expectedOutput";
        }
    }
}
