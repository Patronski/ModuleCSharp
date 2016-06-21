using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    class RepositorySorters
    {
        public static void OrderAndTake(Dictionary<string, List<int>> wantedData, string comparison, int studentsToTake)
        {
            comparison = comparison.ToLower();
            if (comparison == "ascending")
            {
                PrintStudents(wantedData.OrderBy(x => x.Value.Sum())
                                        .Take(studentsToTake)
                                        .ToDictionary(pair => pair.Key, pair => pair.Value));
            }
            else if(comparison == "descending")
            {
                PrintStudents(wantedData.OrderByDescending(x => x.Value.Sum())
                                        .Take(studentsToTake)
                                        .ToDictionary(pair => pair.Key, pair => pair.Value));
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InvalidComparisonQuery);
            }
        }

        private static void PrintStudents(Dictionary<string, List<int>> studentsSorted)
        {
            foreach (var student in studentsSorted)
            {
                OutputWriter.PrintStudent(student);
            }
        }

        //private static void OrderAndTake(Dictionary<string, List<int>> wantedData, int studentsToTake,
        //    Func<KeyValuePair<string, List<int>>, KeyValuePair<string, List<int>>, int> comparisonFunc)
        //{
        //    Dictionary<string, List<int>> studentsSorted = GetSortedStudents(wantedData, studentsToTake, comparisonFunc);

        //    PrintStudents(studentsSorted);
        //}

        //private static int CompareInOrder(KeyValuePair<string, List<int>> firstValue,
        //    KeyValuePair<string, List<int>> secondValue)
        //{
        //    int totalOfFirstMarks = 0;
        //    foreach (var i in firstValue.Value)
        //    {
        //        totalOfFirstMarks += i;
        //    }

        //    int totalofSecondMarks = 0;
        //    foreach (var i in secondValue.Value)
        //    {
        //        totalofSecondMarks += i;
        //    }

        //    return totalofSecondMarks.CompareTo(totalOfFirstMarks);
        //}
        //private static int CompareDescendingOrder(KeyValuePair<string, List<int>> firstValue,
        //    KeyValuePair<string, List<int>> secondValue)
        //{
        //    int totalOfFirstMarks = 0;
        //    foreach (var i in firstValue.Value)
        //    {
        //        totalOfFirstMarks += i;
        //    }

        //    int totalofSecondMarks = 0;
        //    foreach (var i in secondValue.Value)
        //    {
        //        totalofSecondMarks += i;
        //    }

        //    return totalOfFirstMarks.CompareTo(totalofSecondMarks);
        //}

        //private static Dictionary<string, List<int>> GetSortedStudents(Dictionary<string, List<int>> studentsWanted,
        //    int takeCount,
        //    Func<KeyValuePair<string, List<int>>, KeyValuePair<string, List<int>>, int> Comparison)
        //{
        //    int valuesTaken = 0;
        //    Dictionary<string, List<int>> studentsSorted = new Dictionary<string, List<int>>();
        //    KeyValuePair<string, List<int>> nextInOrder = new KeyValuePair<string, List<int>>();
        //    bool isSorted = false;

        //    while (!isSorted)
        //    {
        //        isSorted = true;
        //        foreach (var studentsWithScore in studentsWanted)
        //        {
        //            if (!string.IsNullOrEmpty(nextInOrder.Key))
        //            {
        //                int comparisonResult = Comparison(studentsWithScore, nextInOrder);
        //                if (comparisonResult >= 0 && !studentsSorted.ContainsKey(studentsWithScore.Key))
        //                {
        //                    nextInOrder = studentsWithScore;
        //                    isSorted = false;
        //                }
        //            }
        //            else
        //            {
        //                if (!studentsSorted.ContainsKey(studentsWithScore.Key))
        //                {
        //                    nextInOrder = studentsWithScore;
        //                    isSorted = false;
        //                }
        //            }
        //        }
        //        if (!isSorted)
        //        {
        //            studentsSorted.Add(nextInOrder.Key, nextInOrder.Value);
        //            valuesTaken++;
        //            if (takeCount <= valuesTaken)
        //            {
        //                break;
        //            }
        //            nextInOrder = new KeyValuePair<string, List<int>>();
        //        }
        //    }

        //    return studentsSorted;
        //}

    }
}
