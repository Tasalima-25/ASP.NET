
using System;
using System.Collections.Generic;

namespace Lambda_Sort
{
    class Program
    {
        // Delegate for comparison
        public delegate int CompareNumbers(int a, int b);

        static void Main()
        {
            List<int> numbers = new List<int> { 5, 2, 8, 1, 4 };

            Console.WriteLine("Original List :");
            numbers.ForEach(n => Console.Write(n + " "));

            // Assign lambda to delegate
            CompareNumbers compare = (a, b) => a.CompareTo(b);

            // Sort using delegate
            numbers.Sort((a, b) => compare(a, b));

            Console.WriteLine("\nSorted List :");
            numbers.ForEach(n => Console.Write(n + " "));
        }
    }
}