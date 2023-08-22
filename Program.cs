using System;

namespace BubbleSort
{
    internal class Program
    {
        private static void SortNums(List<string> StrOfNums)
        {
            for (int i = 0; i < StrOfNums.Count - 1; i++)
                for (int j = 0; j < StrOfNums.Count - i - 1; j++)
                    if ( int.Parse(StrOfNums[j]) > int.Parse(StrOfNums[j+1]) )
                    {
                        string Temp = StrOfNums[j];
                        StrOfNums[j] = StrOfNums[j + 1];
                        StrOfNums[j + 1] = Temp;
                    }
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Программа Bubble Sort\n\rВведите строку чисел...\n\r");
            List<string> StrOfNums = new List<string>(Console.ReadLine().Split(' '));
            SortNums(StrOfNums);

            foreach (string num in StrOfNums)
            {
                Console.Write(num + ' ');
            }
        }
    }
}