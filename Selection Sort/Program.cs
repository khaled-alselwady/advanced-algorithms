using System;
using System.Collections.Generic;
using System.Linq;

namespace Selection_Sort
{
    internal class Program
    {
        static int FindIndexOfMinimumElement(IEnumerable<int> Numbers)
        {
            int Min = int.MaxValue;
            int MinIndex = -1;
            int CurrentIndex = 0;

            foreach (int number in Numbers)
            {
                if (number < Min)
                {
                    Min = number;
                    MinIndex = CurrentIndex;
                }
                CurrentIndex++;
            }

            return MinIndex;
        }

        static void SelectionSort(int[] Numbers)
        {
            if (Numbers == null || Numbers.Length == 0)
                return;

            int IndexOfMinNumber = 0;

            for (int i = 0; i < Numbers.Length; i++)
            {
                IndexOfMinNumber = FindIndexOfMinimumElement(Numbers.Skip(i)) + i;

                if (IndexOfMinNumber != i)
                {
                    // swap
                    (Numbers[IndexOfMinNumber], Numbers[i]) = (Numbers[i], Numbers[IndexOfMinNumber]);
                }
            }

        }

        static void PrintArray(int[] Numbers)
        {
            if (Numbers == null)
                return;

            foreach (int i in Numbers)
                Console.Write(i + " ");
        }

        static void Main(string[] args)
        {
            int[] Numbers = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("Original array:");
            PrintArray(Numbers);

            SelectionSort(Numbers);

            Console.WriteLine("\n\nSorted array:");
            PrintArray(Numbers);

            Console.ReadKey();
        }
    }
}
