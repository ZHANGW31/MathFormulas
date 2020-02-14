using System;
using System.Collections.Generic;
using System.Text;

namespace MathFormulas
{
    public class UserInputClass
    {
        public static int InitialInputValue()
        {
            Console.Write("\nPlease enter your choice: ");
            bool isValid = false;
            string fromUser = Console.ReadLine();
            int output = 0;
            while (isValid == false)
            {
                checked
                {
                    if (!int.TryParse(fromUser, out output))
                    {
                        Console.WriteLine("{0} is not a valid input", fromUser);
                        Console.WriteLine("Please enter a valid value");
                        fromUser = Console.ReadLine();
                        continue;
                    }
                    if (output > 4)
                    {
                        Console.WriteLine("{0} is not a right choice", fromUser);
                        Console.WriteLine("Please enter a valid value");
                        fromUser = Console.ReadLine();
                        continue;
                    }
                    if (output == 0)
                    {
                        Console.WriteLine("{0} is not a right choice", fromUser);
                        Console.WriteLine("Please enter a valid value");
                        fromUser = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        isValid = true;
                    }
                }
            }
            return output;
        }
        //This method tests to user input and validates that it is an integer
        public static int ValidateUserInput()
        {
            Console.Write("\nYour Value: ");
            bool isValid = false;
            string fromUser = Console.ReadLine();
            int output = 0;
            while (isValid == false)
            {
                if (!int.TryParse(fromUser, out output))
                {
                    Console.WriteLine("{0} is not a valid integer", fromUser);
                    Console.WriteLine("Please enter a valid value!");
                    fromUser = Console.ReadLine();
                    continue;
                }
                if (output <= 0)
                {
                    Console.WriteLine("{0} is not a valid integer", fromUser);
                    Console.WriteLine("Please enter a valid value!");
                    fromUser = Console.ReadLine();
                    continue;
                }
                else
                {
                    isValid = true;
                }
            }
            return output;
        }
    }
}
