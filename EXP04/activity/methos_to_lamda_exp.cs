 

using System;
using System.Runtime.Remoting.Messaging;

namespace Lambda_Delegate
{
    class Program
    {
        public delegate void MethodMessage();

        public static void Greet()
        {
            Console.WriteLine("Good Morning!");
        }

        public static void Welcome()
        {
            Console.WriteLine("Welcome to C#");
        }

        public delegate void LambdaMessage();

        static void Main()
        {
            Console.WriteLine("Methods in delegate : ");
            MethodMessage mtdmsg = Greet;
            mtdmsg += Welcome;

            mtdmsg();

            Console.WriteLine("\nReplace methods with lambda expressions : ");
            // Lambda expressions instead of separate methods
            LambdaMessage lbdmsg = () => Console.WriteLine("Good Morning!");

            lbdmsg += () => Console.WriteLine("Welcome to C#");

            lbdmsg();   // Multicast delegate using lambdas
        }
    }
}