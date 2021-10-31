using System;
using System.Collections.Generic;
using System.Text;

namespace UsedCarLot
{
    public class Validator
    {

        public static bool ValidatoryInput(int userInput, int count1)
        {
            bool flag = true;


            if (userInput <= 0 || userInput > count1 + 2)
            {
                
                    Console.WriteLine("Not less than 0 and more than the list");                   
                
                flag = false;
            }
            return flag;

        }

    }
}
