using System;
namespace DelegateSample
{
    public static class myCalss
    {
        public static string GetString()
        {
            return "myCalss.GetString()";
        }
    }

    class Program
    {

        delegate string MyDelegate();
        delegate double CalcNumber(int a, int b);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(GetMyString);
            string value = myDelegate.Invoke();
            Console.WriteLine($"Result:{value}");
            myDelegate = myCalss.GetString;
            Console.WriteLine($"Result From myClass:  {myDelegate.Invoke()}");

            CalcNumber calcNumber;
            calcNumber = Div;
            double result2 = calcNumber(8, 2);
            Console.WriteLine($"Result2:{result2}");

        }

        static string GetMyString()
        {
            return "my string....";
        }

        static double Div(int number1, int number2)
        {
            return number1 / number2;
        }
    }
}
