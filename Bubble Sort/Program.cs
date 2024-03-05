using System;

namespace Bubble_Sort
{
    internal class Program
    {
        static void Swap(ref int Number1, ref int Number2)
        {
            int Temp = Number1;
            Number1 = Number2;
            Number2 = Temp;
        }

        static void BubbleSort(int[] Numbers)
        {
            if (Numbers == null || Numbers.Length == 0)
                return;

            for (int i = 0; i < Numbers.Length; i++)
            {

                for (int j = 0; j < Numbers.Length - i - 1; j++)
                {
                    //if (((j + 1) < Numbers.Length) && (Numbers[j] > Numbers[j + 1]))
                    //    Swap(ref Numbers[j], ref Numbers[j + 1]);

                    if (Numbers[j] > Numbers[j + 1])
                    {
                        // Swap using tuple deconstruction 
                        (Numbers[j], Numbers[j + 1]) = (Numbers[j + 1], Numbers[j]);
                    }
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
            int[] Numbers = { 1, 4, 5, 3, 2 };

            Console.WriteLine("Original array:");
            PrintArray(Numbers);

            BubbleSort(Numbers);

            Console.WriteLine("\n\nSorted array:");
            PrintArray(Numbers);

            Console.ReadKey();
        }
    }
}
