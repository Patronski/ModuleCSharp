using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsCount
{
    public class WordsCount
    {
        public static void Main()
        {
            string myOutputPath = @"C:\Users\DonchoP\Desktop\FilesAndDirectoriesTests\04_WordCount\MyOutput.txt";
            string wordsPath = @"C:\Users\DonchoP\Desktop\FilesAndDirectoriesTests\04_WordCount\words3.txt";
            string textPath = @"C:\Users\DonchoP\Desktop\FilesAndDirectoriesTests\04_WordCount\text3.txt";
            string expectedOutputPath = @"C:\Users\DonchoP\Desktop\FilesAndDirectoriesTests\02_OddLines\01_OddLinesOut.txt";

            var readerWords = File.ReadAllText(wordsPath);
            string[] arrWords  = readerWords.Split();
            Dictionary<string, int> dictWords = new Dictionary<string, int>();
            for (int i = 0; i < arrWords.Length; i++)
            {
                dictWords.Add(arrWords[i], 0);
            }

            var readerText = File.ReadAllText(textPath);

            foreach (string word in arrWords)
            {
                int counter = 0;
                int index = 0;

                while (index < readerText.Length)
                {
                    int pastIndex = index;

                    index = readerText.IndexOf(word, index, StringComparison.CurrentCultureIgnoreCase) + word.Length;

                    if (index < pastIndex || index >= readerText.Length)
                    {
                        break;
                    }
                    if ((index - 1 - word.Length) >= 0 && char.IsLetter(readerText[index - 1 - word.Length])
                        ||
                        index < readerText.Length && char.IsLetter(readerText[index]))
                    {
                        continue;
                    }
                    
                    counter++;
                }
                //Console.WriteLine($"{word} - {counter}");
                dictWords[word] = counter;
            }

            // sort dict
            Console.WriteLine();
            var sortedDic = dictWords.OrderByDescending(kv => kv.Value);
            foreach (var kv in sortedDic)
            {
                Console.WriteLine($"{kv.Key} - {kv.Value}");
            }

            //write in file
            using (File.Create(myOutputPath)) { }
            var writer = File.AppendText(myOutputPath);

            using (writer)
            {
                foreach (var kv in sortedDic)
                {
                    writer.WriteLine($"{kv.Key} - {kv.Value}");
                }
            }
        }
    }
}
