using System;
using System.Collections.Generic;
using System.Linq;

namespace JoiningDataOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise3();
            Console.ReadLine();
        }

        static void Exercise1()
        {
            List<Order> orders = new List<Order>
            {
                new Order("Acme Hardware", "Mouse", 25, 3),
                new Order("Acme Hardware", "Keyboard", 45, 2),
                new Order("Falls Realty", "Macbook", 800, 2),
                new Order("Julie’s Morning Diner", "iPad", 525, 1),
                new Order("Julie’s Morning Diner", "Credit Card Reader", 45, 1),
            };

            var distinctOrders = orders.GroupBy(o => o.CustomerName).Select(o => o.First());

            foreach (Order name in distinctOrders)
            {
                Console.WriteLine(name.CustomerName);
                Console.WriteLine(string.Format("\t{0, -20} {1, -20} {2, -20} {3, 0}", "Item", "Price", "Quantity", "Total"));

                for (int i = 0; i < orders.Count; i++)
                {
                    if (name.CustomerName == orders[i].CustomerName)
                    {
                        Console.WriteLine(orders[i].ToString());
                    }
                }

                Console.WriteLine();
            }
        } // done

        static void Exercise2()
        {
            List<Order> orders = new List<Order>
            {
                new Order("Acme Hardware", "Mouse", 25, 3),
                new Order("Acme Hardware", "Keyboard", 45, 2),
                new Order("Falls Realty", "Macbook", 800, 2),
                new Order("Julie’s Morning Diner", "iPad", 525, 1),
                new Order("Julie’s Morning Diner", "Credit Card Reader", 45, 1)
            };

            var distinctOrders = orders.GroupBy(o => o.CustomerName).Select(o => o.First());

            foreach (Order name in distinctOrders)
            {
                Console.WriteLine(name.CustomerName);
                Console.WriteLine(string.Format("\t{0, -20} {1, -20} {2, -20} {3, 0}", "Item", "Price", "Quantity", "Total"));
                decimal total = 0;
                for (int i = 0; i < orders.Count; i++)
                {
                    if (name.CustomerName == orders[i].CustomerName)
                    {
                        Console.WriteLine(orders[i].ToString());
                        total += orders[i].Quantity * orders[i].Price;
                    }
                }
                //Console.WriteLine(string.Format("\tTotal{ 0, 50 }", total)); // need to add formatting here

                Console.WriteLine($"\tTotal \t\t\t\t\t{ total }");
                Console.WriteLine();
            }
        }

        static void Exercise3()
        {
            List<Order> orders = new List<Order>
            {
                new Order("Acme Hardware", "Mouse", 25, 3),
                new Order("Acme Hardware", "Keyboard", 45, 2),
                new Order("Falls Realty", "Macbook", 800, 2),
                new Order("Julie’s Morning Diner", "iPad", 525, 1),
                new Order("Julie’s Morning Diner", "Credit Card Reader", 45, 1),
            };

            var distinctOrders = orders.GroupBy(o => o.CustomerName).Select(o => o.First());


            Console.WriteLine(string.Format("{0, -25}{1, -20}{2, -20}{3, -20}{4, 0}", "Customer", "Item", "Price", "Quantity", "Total"));
            foreach (Order name in distinctOrders)
            {
                Console.Write(string.Format("{0, -25}", name.CustomerName));
                for (int i = 0; i < orders.Count; i++)
                {
                    if (name.CustomerName == orders[i].CustomerName)
                    {
                        if (i == 1 || i == 4)
                        {
                            string addSpace = string.Format("{0, -25}", "\t\t\t");
                            Console.WriteLine(string.Format("{0, 0}{1, -20}{2, -20}{3, -20}{4, 0}", addSpace, orders[i].Item, orders[i].Price, orders[i].Quantity, orders[i].Price * orders[i].Quantity));
                        }
                        //Console.WriteLine(string.Format("{0, 0}{1, -20}{2, -20}{3, -20}{4, 0}", $"{i}. ", orders[i].Item, orders[i].Price, orders[i].Quantity, orders[i].Price * orders[i].Quantity));
                    }
                }
            }
        }


        static void Exercise3Ext()
        {
            List<Order> orders = new List<Order>
            {
                new Order("Acme Hardware", "Mouse", 25, 3),
                new Order("Acme Hardware", "Keyboard", 45, 2),
                new Order("Falls Realty", "Macbook", 800, 2),
                new Order("Julie’s Morning Diner", "iPad", 525, 1),
                new Order("Julie’s Morning Diner", "Credit Card Reader", 45, 1),
            };

            var removeDuplicateNames = orders.GroupBy(o => o.CustomerName).Select(o => o.First());

            DataTableFormatter.PrintRow("Customer Name", "Item", "Price", "Quantity", "Total");
            foreach (Order name in removeDuplicateNames)
            {
                //DataTableFormatter.PrintRow(name.CustomerName);
                Console.Write(name.CustomerName);
                for (int i = 0; i < orders.Count; i++)
                {
                    if (name.CustomerName == orders[i].CustomerName)
                    {
                        //foreach (Order order in removeDuplicateNames)
                        //{
                        DataTableFormatter.PrintRow(name.Item, name.Price.ToString(), name.Quantity.ToString(), (name.Price * name.Quantity).ToString());

                        //}
                    }
                }
            }
            Console.ReadLine();

        }
    }
}
