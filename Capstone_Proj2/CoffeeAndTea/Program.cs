using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace CoffeeAndTea
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to our Coffee/Tea Shop!");
            Console.WriteLine();

            decimal GrandTotal = GetMenu();
            Console.WriteLine($"Grand Total: \t${GrandTotal}");
            Console.WriteLine();

            PaymentSelection(GrandTotal);
            Console.ReadLine();
        }

        static List<Drinks> CreateMenu()
        {
            
            StreamReader reader = new StreamReader("StoreList.txt");
            List<Drinks> menu = new List<Drinks>();

            while (true)
            {
                string line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }
                else
                {
                    string[] splitLine = line.Split(",");
                    string category = splitLine[0];
                    string name = splitLine[1];
                    decimal price = decimal.Parse(splitLine[2]);
                    string type = splitLine[3];

                    Drinks drinkDetails = new Drinks(category, name, price, type);
                    menu.Add(drinkDetails);
                }
            }
            reader.Close();
            return menu;
        }
        static decimal GetMenu() // Mock display to confirm the list is working
        {
            List<Drinks> menu = CreateMenu();
            //This foreach display the menu
            int counter = 0;
            Console.WriteLine(string.Format("\t{0, -15} {1, -16} {2, -16} {3, -15}", "Category", "Name", "Price", "Description"));
            Console.WriteLine();
            foreach (Drinks drinkDetails in menu)
            {
                counter++;
                Console.WriteLine($"{counter}. {drinkDetails}");
            }


            List<string> itemOrderedList = new List<string>();
            List<decimal> listOfItemPriced = new List<decimal>();
            List<int> itemQtyList = new List<int>();
            int userQty;

            Console.WriteLine();
            Console.WriteLine("Which drink would you like to purchase:? Choose a number:");
            while (true)
            {
                int userinput = ValidateUserInput.UserSelection();

                int counter2 = 0;
                //this foreach grab an item per user selection
                foreach (Drinks userChoice in menu)
                {

                    counter2++;
                    if (counter2 == userinput)
                    {
                        Console.WriteLine($"{ userChoice.Name} \t${ userChoice.Price }");
                        Console.WriteLine();
                        Console.WriteLine($"How many { userChoice.Name } would you like?");
                        userQty = int.Parse(Console.ReadLine());

                        Console.WriteLine($"{userQty} { userChoice.Name} \t${ userChoice.Price * userQty }");

                        //userChoice.Price *= userQty;
                        itemQtyList.Add(userQty);
                        itemOrderedList.Add(userChoice.Name);
                        listOfItemPriced.Add(userChoice.Price);
                    }
                }

                bool addItems = true;
                Console.WriteLine();
                Console.WriteLine("Would you like to add more drinks? y/n");
                while (true)
                {
                    string addCheck = Console.ReadLine().ToLower().Trim();
                    if (addCheck == "y")
                    {
                        Console.WriteLine("What addtional drinks do you want?");
                        break;
                    }
                    else if (addCheck == "n")
                    {
                        addItems = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That was not a valid input.");
                    }
                }

                if (addItems == false)
                {
                    break;
                }
            }

            Console.Clear();
            Console.WriteLine("Thank you for your order!");
            Console.WriteLine();
            Console.WriteLine("These are your drinks:");
            Console.WriteLine();

            List<decimal> totalPriced = new List<decimal>(); // We added another list to confirm make sure price per item is displayed
            decimal tempPrice;
            decimal totalQty = 0;
            for (int i = 0; i < itemOrderedList.Count; i++)
            {
                totalQty += itemQtyList[i];
                tempPrice = listOfItemPriced[i] * itemQtyList[i];
                totalPriced.Add(tempPrice);

                Console.WriteLine($"{itemQtyList[i]} {itemOrderedList[i] } \t${listOfItemPriced[i] * itemQtyList[i]}");
            }
            Console.WriteLine();
            Console.WriteLine($"You purchased: \t{ totalQty } drinks"); // there a bug here

            PaymentDetails salestax = new PaymentDetails();
            decimal Total = 0, grandTotal;

            foreach (decimal value in totalPriced)//add all values into averagePrice
            {
                Total += value;
            }
            //Total *= listOfItemPriced.Count;
            Console.WriteLine($"\nSubtotal: \t${Total}");
            Console.WriteLine($"Sales tax: \t{ salestax.SalesTaxTendered() * 100}%");

            grandTotal = Math.Round(Total + (Total * salestax.SalesTaxTendered()), 2);
            return grandTotal;
        }
        static void PaymentSelection(decimal totalFromReceipt)
        {
            PaymentDetails pd = new PaymentDetails();
            Console.WriteLine("How would you like to pay for your drinks?:");
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("1. Cash\n2. Credit Card\n3. Checks");
                string paymentMethodChosen = Console.ReadLine(); // This validation is working
                if (paymentMethodChosen == "1")
                {
                    Console.WriteLine();
                    Console.WriteLine("How much cash are you paying with?");
                    Console.WriteLine($"Your total is ${ totalFromReceipt }");

                    while (true)
                    {
                        string cashFromUserStr = Console.ReadLine();

                        if (ValidateUserInput.StringIsNumeric(cashFromUserStr) && cashFromUserStr != "" && decimal.Parse(cashFromUserStr) >= totalFromReceipt)
                        {
                            decimal cashFromUserDec = decimal.Parse(cashFromUserStr);
                            Console.WriteLine();
                            // I will need the the total receipt again
                            Console.WriteLine("==========================");
                            Console.WriteLine();
                            Console.WriteLine($"Cash Tender: \t${ cashFromUserDec }");
                            
                            decimal changesToGiveBack = totalFromReceipt - cashFromUserDec;
                            Console.WriteLine($"Change Due: \t${-changesToGiveBack}");
                            Console.WriteLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Invalid entry! Enter cash greater than { totalFromReceipt }");
                        }
                    }
                    break;
                }
                else if (paymentMethodChosen == "2")
                {
                    PaymentType pt = TakingCCPayments(totalFromReceipt);// the value coming into itemprice needs to come from the total price of item already purchased
                    pd.TakingPayment(pt);
                    break;
                }
                else if (paymentMethodChosen == "3")
                {
                    PaymentType pt = TakingCheckPayments(totalFromReceipt);
                    pd.TakingPayment(pt);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid entry. Choose a payment method:");
                }
            }

            Console.WriteLine("Thank you for your shopping at Coffee/Tea! \nHave a nice day!");
            Console.WriteLine();

            List<Drinks> menu = CreateMenu();
            DisplayMenu(menu);

        }
        static PaymentType TakingCCPayments(decimal itemPrice)
        {
            string usersName;
            Console.WriteLine("Name on the card:");
            usersName = ValidateUserInput.ValidateUserName();

            string creditCardNumber;
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Credit Card Number:");
                
                Console.WriteLine("16 digits, no spaces");
                creditCardNumber = Console.ReadLine();
                if (Regex.IsMatch(creditCardNumber, @"^[0-9]{16}"))
                {
                    break;
                }
                else if (creditCardNumber == "")
                {
                    Console.WriteLine("Credit Card number field cannot be empty.");
                }
                else if (ValidateUserInput.StringIsNumeric(creditCardNumber) == false)
                {
                    Console.WriteLine("Invalid entry. Please enter your credit number");
                }
                else
                {
                    Console.WriteLine("That was not a 16 digit number");
                }
            }

            string expirationDate;
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Expiration date:");
                Console.WriteLine("MM/YYYY");
                expirationDate = Console.ReadLine();
                if (expirationDate == "")
                {
                    Console.WriteLine("Expiration date field cannot be empty.");
                }
                else if (Regex.IsMatch(expirationDate, @"(0[1-9]|10|11|12)/20[0-9]{2}$"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("That was an invalid expiration date");
                }
            }

            string securityCode;
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Security Code:");
                Console.WriteLine("4 numbers");
                securityCode = Console.ReadLine();
                Console.WriteLine();
                if (securityCode == "")
                {
                    Console.WriteLine("Security code field cannot be empty.");
                }
                else if (Regex.IsMatch(securityCode, @"^[0-9]{4}"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("That was an invalid security code"); ;
                }
            }
            CreditCard userChoseCC = new CreditCard(usersName, creditCardNumber, expirationDate, securityCode, itemPrice);
            return userChoseCC;
        }
        static PaymentType TakingCheckPayments(decimal itemPrice)
        {
            string usersName;
            while (true)
            {
                Console.WriteLine("Name on the check:");
                usersName = Console.ReadLine();
                if (ValidateUserInput.StringNotEmpty(usersName) != true)
                {
                    Console.WriteLine("Name field cannot be empty.");
                }
                else if (ValidateUserInput.StringIsNumeric(usersName) == true)
                {
                    Console.WriteLine("Numbers are not allowed in the name filed. Please enter your name");
                }
                else
                {
                    break;
                }
            }

            string checkNumber;
            while (true)
            {
                Console.WriteLine("Check Number:");
                checkNumber = Console.ReadLine();
                if (Regex.IsMatch(checkNumber, @"^[0-9]{3,4}"))
                {
                    break;
                }
                if (ValidateUserInput.StringNotEmpty(checkNumber) != true)
                {
                    Console.WriteLine("Check Number field cannot be empty.");
                }
                else if (ValidateUserInput.StringIsNumeric(checkNumber) == false)
                {
                    Console.WriteLine("Invalid entry. Please enter a check number");
                }
                else
                {
                    Console.WriteLine("That was an invalid check number");
                }
            }

            Check userChoseCheck = new Check(usersName, checkNumber, itemPrice);
            return userChoseCheck;
        }
        static void DisplayMenu(List<Drinks> menu)
        {
            
            foreach (Drinks drinks in menu)
            {
                Console.WriteLine($"{ drinks.ToString() }");
            }
        }
    }
}
