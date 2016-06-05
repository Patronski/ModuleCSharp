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

            //Tester.CompareContent(@"D:\test1.txt", @"D:\test2.txt");

            //IOManager.CreateDirectoryInCurrentFolder("*2");
            //IOManager.TraverseDirectory(0);

            //IOManager.ChangeCurrentDirectoryAbsolute(@"C:\Windows");
            //IOManager.TraverseDirectory(20);

            InputReader.StartReadingCommands();
        }
    }
}
