using System;

namespace _04_MultiCastDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> action = M1;
            action += M2;
            //action -= M1;
            //action.Invoke(20);

            Delegate[] delegates = action.GetInvocationList();
            foreach (var item in delegates)
            {
                try
                {
                    item.DynamicInvoke(100);
                }
                catch (Exception ex)
                {

                    ;
                }
            }
        }


        public static void M1(int number)
        {
            throw new Exception("test");
            Console.WriteLine($"Result : {number}");
        }

        public static void M2(int number)
        {
            var result = number * 2;
            Console.WriteLine($"Result : {result}");
        }
    }
}
