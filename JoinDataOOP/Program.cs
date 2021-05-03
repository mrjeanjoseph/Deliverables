using System;
using System.Collections.Generic;
using System.Linq;

namespace JoiningDataOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercies4();
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
        } // Done

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
        } // Done

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

            var ordersGrouped = orders.GroupBy(o => o.CustomerName).Select(o => o.First());

            Console.WriteLine(string.Format("{0, -25}{1, -20}{2, -20}{3, -20}{4, 0}", "Customer", "Item", "Price", "Quantity", "Total"));
            foreach (Order groupByName in ordersGrouped)
            {
                Console.Write(string.Format("{0, -25}", groupByName.CustomerName));
                for (int i = 0; i < orders.Count; i++)
                {
                    if (groupByName.CustomerName == orders[i].CustomerName)
                    {
                        if (i == 1 || i == 4) // This will check for empty spaces when the duplicate is taking care of.
                        {
                            string addSpace = string.Format("{0, -25}", "");
                            Console.WriteLine(string.Format("{0, 0}{1, -20}{2, -20}{3, -20}{4, 0}", addSpace, orders[i].Item, orders[i].Price, orders[i].Quantity, orders[i].Price * orders[i].Quantity));
                        }
                        else
                        {
                            Console.WriteLine(string.Format("{0, 0}{1, -20}{2, -20}{3, -20}{4, 0}", "", orders[i].Item, orders[i].Price, orders[i].Quantity, orders[i].Price * orders[i].Quantity));
                        }
                    }
                }
            }
        }

        static void Exercies4()
        {
            List<Order> orders = new List<Order>
            {
                new Order("Acme Hardware", "Mouse", 25, 3),
                new Order("Acme Hardware", "Keyboard", 45, 2),
                new Order("Falls Realty", "Macbook", 800, 2),
                new Order("Joe’s Chicago Pizza", "", 0, 0),
                new Order("Julie’s Morning Diner", "iPad", 525, 1),
                new Order("Julie’s Morning Diner", "Credit Card Reader", 45, 1),
            };

            var distinctOrders = orders.GroupBy(o => o.CustomerName).Select(o => o.First());


            foreach (Order name in distinctOrders)
            {
                Console.WriteLine(name.CustomerName);

                if (name.Item == "")
                {
                    Console.WriteLine(string.Format("\t{0, -20} {1, -20} {2, -20} {3, 0}", "**No Orders**", "", "", ""));
                    
                }
                else
                {
                    Console.WriteLine(string.Format("\t{0, -20} {1, -20} {2, -20} {3, 0}", "Item", "Price", "Quantity", "Total"));
                    
                }
                for (int i = 0; i < orders.Count; i++)
                {
                    if (name.CustomerName == orders[i].CustomerName)
                    {
                        if (name.Item == "")
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine(orders[i].ToString());
                        }
                    }
                }
            }
        }

        static void TableHeader()
        {
            const int tableWidth = 90;
            Console.WriteLine(new string('_', tableWidth));
        }
    }
}
