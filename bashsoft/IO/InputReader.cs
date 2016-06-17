using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    public static class InputReader
    {
        private const string endCommand = "quit";

        public static void StartReadingCommands()
        {
            OutputWriter.WriteMessage($"{SesionData.currentPath}> ");
            string input = Console.ReadLine(); // Write command
            input = input.Trim();

            while (input != endCommand)
            {
                CommandInterpreter.InterpredCommand(input); //Interpred Command
                OutputWriter.WriteMessage($"{SesionData.currentPath}> ");
                input = Console.ReadLine(); // Write command
                input = input.Trim();
            }
        }

        

        
    }
}
