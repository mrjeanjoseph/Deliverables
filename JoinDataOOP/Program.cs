using System;
using System.Collections.Generic;
using System.Linq;

namespace JoinDataOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>
            {
                new Order("Acme Hardware", "Mouse", 25, 3),
                new Order("Acme Hardware", "Keyboard", 45, 2),
                new Order("Falls Realty", "Macbook", 800, 2),
                new Order("Julie’s Morning Diner", "iPad", 525, 1),
                new Order("Julie’s Morning Diner", "Credit Card Reader", 45, 1),
            };

            foreach (Order name in orders)
            {
                Console.WriteLine(name.CustomerName);
                Console.WriteLine(string.Format("\t{0, -20} {1, -20} {2, 0}", "Item", "Price", "Quantity"));

                for (int i = 0; i < orders.Count; i++)
                {
                    if (name.CustomerName == orders[i].CustomerName)
                    {

                        Console.WriteLine(orders[i].ToString());
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();



            //foreach (Order names in orders)
            //{
            //    for (int i = 0; i < orders.Count; i++)
            //    {
            //        bool status = false;
            //        for (int j = 0; j < i; j++)
            //        {
            //            if (orders[j].CustomerName == orders[i].CustomerName)
            //            {
            //                status = true;
            //                break;
            //            }
            //        }
            //        if (!status)
            //        {
            //            //Console.WriteLine(orders[i].CustomerName);
            //            if (names.CustomerName == orders[i].CustomerName)
            //            {
            //                Console.WriteLine(orders[i].ToString());
            //            }
            //            Console.WriteLine();
            //        }
            //    } 
            //}
            //Console.ReadLine();
        }
    }
}
