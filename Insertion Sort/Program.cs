using System;
using System.Collections.Generic;
using System.Linq;

namespace Insertion_Sort
{
    internal class Program
    {
        private static int FindRightPosition(IEnumerable<int> Numbers, int Number)
        {
            if (Numbers == null)
                return -1;

            int Index = -1;
            foreach (int Item in Numbers)
            {
                Index++;

                if (Item >= Number)
                    return Index;
            }

            return -1;
        }

        private static void InsertionSort1(int[] Numbers)
        {
            if (Numbers == null || Numbers.Length <= 1)
                return;

            int Key = 0;
            int RightPosition = -1;

            for (int i = 1; i < Numbers.Length; i++)
            {
                Key = Numbers[i];

                if (Key < Numbers[i - 1])
                {
                    RightPosition = FindRightPosition(Numbers.Take(i), Numbers[i]);

                    if (RightPosition != -1)
                    {
                        for (int j = i - 1; j >= RightPosition; j--)
                        {
                            (Numbers[j], Numbers[j + 1]) = (Numbers[j + 1], Numbers[j]);
                        }
                    }
                }
            }
        }
        
        private static void InsertionSort2(int[] Numbers)
        {
            if (Numbers == null || Numbers.Length <= 1)
                return;

            for (int i = 1; i < Numbers.Length; i++)
            {
                int Key = Numbers[i];
                int j = i - 1;

                while (j >= 0 && Numbers[j] > Key)
                {
                    Numbers[j + 1] = Numbers[j];

                    j--;
                }

                Numbers[j + 1] = Key;
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
            int[] Numbers = { 1, 4, 3, 2 };

            Console.WriteLine("Original array:");
            PrintArray(Numbers);

            InsertionSort2(Numbers);

            Console.WriteLine("\n\nSorted array:");
            PrintArray(Numbers);

            Console.ReadKey();
        }
    }
}
