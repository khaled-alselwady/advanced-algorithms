using System;

namespace Binary_Search
{
    internal class Program
    {
        static int BinarySearch(int[] SortedNumbers, int NumberToSearch)
        {
            if (SortedNumbers == null || SortedNumbers.Length == 0)
                return -1;

            int Start = 0;
            int End = SortedNumbers.Length - 1;
            int Middle = 0;
            int Trials = 0; 

            while (Start <= End)
            {
                Middle = Start + (End - Start) / 2;

                Trials++;

                Console.WriteLine($"Trials = {Trials}");

                if (NumberToSearch == SortedNumbers[Middle])
                    return Middle;

                if (NumberToSearch > SortedNumbers[Middle])
                    Start = Middle + 1;
                else
                    End = Middle - 1;
            }

            return -1;
        }

        private static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
                Console.Write(item + " ");
        }

        static void Main(string[] args)
        {
            int[] arr = { 22, 25, 37, 41, 45, 46, 49, 51, 55, 58, 70, 80, 82, 90, 95 }; // Sorted array

            int x = 51; // Element to be searched

            Console.WriteLine("Sorted Array:");
            PrintArray(arr);
            Console.WriteLine();

            int result = BinarySearch(arr, x);

            if (result == -1)
                Console.WriteLine("Element not found in the array.");
            else
                Console.WriteLine("Element found at index: " + result);

            Console.ReadKey();
        }
    }
}
