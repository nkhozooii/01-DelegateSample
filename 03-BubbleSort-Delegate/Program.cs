using System;
using System.Collections.Generic;

namespace _03_BubbleSort_Delegate
{

    public class Product
    {
        public int Price { get; set; }

        public static bool Compare(Product product1, Product product2)
        {
            return product1.Price > product2.Price;
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Credit { get; set; }


        public static bool Compare(User user1, User user2)
        {
            return user1.Credit > user2.Credit;
            //if (user1.Credit > user2.Credit)
            //{
            //    return true;
            //}
            //else
            //    return false;
        }
    }

    class Program
    {

        static void Sort<T>(List<T> lists, Func<T, T, bool> compare)
        {
            bool change = true;
            do
            {
                change = false;

                for (int i = 0; i < lists.Count - 1; i++)
                {
                    if (compare(lists[i], lists[i + 1]))
                    {
                        T temp = lists[i];
                        lists[i] = lists[i + 1];
                        lists[i + 1] = temp;
                        change = true;
                    }

                }

            } while (change == true);
        }

        static void Main(string[] args)
        {

            List<User> users = new List<User>();
            users.Add(new User { Id = 1, Name = "Ehsan", Credit = 10000 });
            users.Add(new User { Id = 2, Name = "Rashin", Credit = 70000 });
            users.Add(new User { Id = 3, Name = "Zaynab", Credit = 43000 });
            users.Add(new User { Id = 4, Name = "Saeed", Credit = 8900 });
            users.Add(new User { Id = 5, Name = "Sadegh", Credit = 50 });

            Sort<User>(users, User.Compare);



            foreach (var item in users)
            {
                Console.WriteLine($"Credit:{item.Credit}   Name:{item.Name}");
            }



            List<Product> products = new List<Product>()
            {
                 new Product { Price=50000},
                 new Product { Price=178000},
                 new Product { Price=150},
                 new Product { Price=2500},
            };

            Sort<Product>(products, Product.Compare);

            foreach (var item in products)
            {
                Console.WriteLine($"Price : {item.Price}");
            }

            //int[] MyArray = { 8, 6, 4, 2, 9, 3, 5, 1, 7 };

            //bool change = true;
            //do
            //{
            //    change = false;

            //    for (int i = 0; i < MyArray.Length - 1; i++)
            //    {
            //        if (MyArray[i] > MyArray[i + 1])
            //        {
            //            int temp = MyArray[i];
            //            MyArray[i] = MyArray[i + 1];
            //            MyArray[i + 1] = temp;
            //            change = true;
            //        }

            //    }

            //} while (change == true);


            Console.WriteLine("Hello World!");
        }
    }
}
