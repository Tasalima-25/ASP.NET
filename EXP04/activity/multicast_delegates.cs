using System;

namespace Multicast_Delegate
{
    class Program
    {
        // Declare delegate
        public delegate void MyDelegate();

        // Methods
        public static void Method1()
        {
            Console.WriteLine("Method 1 Called");
        }

        public static void Method2()
        {
            Console.WriteLine("Method 2 Called");
        }

        public static void Method3()
        {
            Console.WriteLine("Method 3 Called");
        }

        static void Main(string[] args)
        {
            // Create delegate instance
            MyDelegate del = Method1;

            // Add more methods (Multicast)
            del += Method2;
            del += Method3;

            Console.WriteLine("Calling Multicast Delegate :");
            del();   // Calls all methods

            // Remove one method
            del -= Method2;

            Console.WriteLine("\nAfter Removing Method2 :");
            del();   // Calls remaining methods
        }
    }
}