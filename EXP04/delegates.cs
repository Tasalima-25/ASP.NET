using System;
using System.Diagnostics;
using System.Net.Sockets;

namespace EXP04
{
    internal class Program
    {
        public delegate void MyDelegate(String message);

        public static void DisplayMessage(String msg)
        {
            Console.WriteLine("Message : " + msg);
        }

        public delegate int Operation(int x, int y);

        // FIX: replaced => with normal method
        public static int Add(int a, int b)
        {
            return a + b;
        }

        // FIX: replaced => with normal method
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            MyDelegate del = DisplayMessage;
            del("Hello from delegates");

            Operation op = Add;
            Console.WriteLine("Addition : " + op(8, 19));

            op = Multiply;
            Console.WriteLine("Multiplication : " + op(8, 19));
        }
    }
}