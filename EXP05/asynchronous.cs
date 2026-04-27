/*
Synchronous : it is synchronous programming.
where task executes one after another. 
each task wait for prevvious task to finish. 
it is sequencial behaviour.
it causes blocking event.
used to wait for task to complete doesnot block thread. 
for example : await Task.Run() => {};

Asynchronous : it is Asynchronous programming.
where task does not need to wait for previous task execution.
it is non sequencial behaviour.
it improves responsiveness.
it does not causes blcoking event. means task can run without blocking main thread.
keywords to declare asynchronous method allows use of await inside the method.
for example : public async task1(){};
*/ 


using System;
using System.Threading;          // FIX: for Thread
using System.Threading.Tasks;    // FIX: for Task

namespace Exp05
{
    internal class Program
    {
        public async static void Task1()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Hello from Task1 starting");
                Thread.Sleep(1000);
                Console.WriteLine("Hello from Task1 Ending");
            });
        }

        public async static void Task2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Hello from Task2 starting");
                Thread.Sleep(1000);
                Console.WriteLine("Hello from Task2 Ending");
            });
        }

        public async static void Task3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Hello from Task3 starting");
                Thread.Sleep(1000);
                Console.WriteLine("Hello from Task3 Ending");
            });
        }

        public async static void Task4()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Hello from Task4 starting");
                Thread.Sleep(1000);
                Console.WriteLine("Hello from Task4 Ending");
            });
        }

        public async static void Task5()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Hello from Task5 starting");
                Thread.Sleep(1000);
                Console.WriteLine("Hello from Task5 Ending");
            });
        }

        public static void Main(String[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
        }
    }
}
