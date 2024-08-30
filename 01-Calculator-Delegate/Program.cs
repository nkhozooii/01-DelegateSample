using System;

namespace _01_Calculator_Delegate
{
    class Program
    {
        //delegate double MyDelegate(int number1, int number2);
 
        static void Main(string[] args)
        {
            Func<int,int,double>[] operations =
            {
                Calculator.Add,
                Calculator.Subtract,
                Calculator.Multiply,
                Calculator.Divide,
                Calculator.Add
            };

            for (int i = 0; i < operations.Length; i++)
            {
                Console.WriteLine($"Run Operation {i}");
                RunMethod(operations[i], 100, 2);
                RunMethod(operations[i], 50, 10);
                RunMethod(operations[i], 108500, 200);
            }
            Console.WriteLine("Hello World!");
        }
        static void RunMethod(Func<int,int,double> action, int n1, int n2)
        {
            double result = action.Invoke(n1, n2);
            Console.WriteLine($"{n1} , {n2}     Result is {result}");
        }
    }

    public static class Calculator
    {
        public static double Add(int a, int b)
        {
            return a + b;
        }
        public static double Subtract(int a, int b)
        {
            return a - b;
        }
        public static double Multiply(int a, int b)
        {
            return a * b;
        }
        public static double Divide(int a, int b)
        {
            return a / b;
        }
    }
}
