using System;

namespace Delegate_Calculator
{
    class Program
    {
        // Declare delegate
        public delegate double Calculate(double a, double b);

        // Methods for operations
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero");

            return a / b;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter First Number :");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Second Number :");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Choose Operation : +  -  *  /");
                char choice = Convert.ToChar(Console.ReadLine());

                Calculate calc = null;

                // Assign method to delegate
                switch (choice)
                {
                    case '+':
                        calc = Add;
                        break;

                    case '-':
                        calc = Subtract;
                        break;

                    case '*':
                        calc = Multiply;
                        break;

                    case '/':
                        calc = Divide;
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        return;
                }

                double result = calc(num1, num2);
                Console.WriteLine("Result : " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }
    }
}