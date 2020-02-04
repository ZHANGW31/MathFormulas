﻿using System;

namespace MathFormulas
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            EntryText();

            try
            {
                var userSelection = InitialInputValue();

                if (userSelection == 1)
                {
                    Console.WriteLine("You chose to calculate the circumference and area of the circle.");
                    Console.WriteLine("We now need a number from you for the radius");
                    int circleInput = ValidateUserInput();                    
                    Console.WriteLine($"The Area of the circle is: {AreaOfCircle(circleInput)}");
                    Console.WriteLine($"The circumference of the circle is {CircleCircumference(circleInput)}");
                }
                if (userSelection == 2)
                {
                    int hemisphereInput = ValidateUserInput();
                    Console.WriteLine($"The volume of the hemisphere is: {Hemisphere(hemisphereInput)}");
                }
                if (userSelection == 3)
                {
                    Console.WriteLine("\nPlease enter the first side!");
                    int triangleInputOne = ValidateUserInput();
                    Console.WriteLine("Please enter the second side!");
                    int triangleInputTwo = ValidateUserInput();
                    Console.WriteLine("Please enter the third side!");
                    int triangleInputThree = ValidateUserInput();

                    Console.WriteLine($"The area of the triangle is {AreaOfTriangle(triangleInputOne, triangleInputTwo, triangleInputThree)}");
                }
                if (userSelection == 4)
                {
                    Console.WriteLine("Please enter a value for a");
                    int valueA = ValidateUserInput();
                    Console.WriteLine("Please enter a value for b");
                    int valueB = ValidateUserInput();
                    Console.WriteLine("Please enter a value for c");
                    int valueC = ValidateUserInput();

                    QuadraticFormula(valueA, valueB, valueC);
                }

            } catch (Exception exceptionMessage)
            {
                Console.WriteLine(exceptionMessage);
            }
            finally
            {
                Console.WriteLine("\nExiting Application");
            }
        }
        static int InitialInputValue()
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
        static int ValidateUserInput()
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
                if(output <= 0)
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
        static double CircleCircumference(int radius)
        {
            checked
            {
                double circumference = 2 * Math.PI * radius;
                return circumference;
            }
        }
        //Part 1 Area of Circle implementation here.
        static double AreaOfCircle(int radius)
        {
            checked
            {
                double area = Math.PI * (radius * radius);
                return area;
            }
        }
        // Part 2 Volume of Hemisphere implementation here.
        static double Hemisphere(int radius)
        {
            checked
            {
                double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3) / 2;
                return volume;
            }
        }
        // Part 3 Area of Triangle implementation here.
        static double AreaOfTriangle(int sideOne, int sideTwo, int sideThree)
        {
            checked
            {
                double p = (sideOne + sideTwo + sideThree) / 2.0;
                double triangleArea = Math.Sqrt(p * (p - sideOne) * (p - sideTwo) * (p - sideThree));
                return triangleArea;
            }
        }
        // Part 4 Solving a quadratic equation.
        static double QuadraticFormula(int a, int b, int c)
        {
            checked
            {
                var inTheSquareRoot = Math.Pow(b, 2.0) + (-4.0 * a * c);
                
                 if (inTheSquareRoot < 0)
                 {
                     Console.WriteLine("There are no real solutions");
                 }
                 else
                 {
                     double positive_num = -b + Math.Sqrt(inTheSquareRoot);
                     double negative_num = -b - Math.Sqrt(inTheSquareRoot);
                     double denominator = 2.0 * a;
                     Console.WriteLine($"\nThe positive solution is {positive_num / denominator}");
                     Console.WriteLine($"\nThe negative solution is {negative_num / denominator}");
                 }
                return a;
            }
        }

        static void EntryText()
        {
            Console.WriteLine("Welcome to Wei's math formula calculator! ");
            Console.WriteLine("\nPlease select from the following.");
            Console.WriteLine("\nI want to...");
            Console.WriteLine("\n(1)Calculate the circumference and Area of the circle given the radius");
            Console.WriteLine("(2)Calculate the volume of the hemisphere given the radius");
            Console.WriteLine("(3)Calculate the Area of the triangle given the length of the sides");
            Console.WriteLine("(4)Solve a quadratic equation");
            Console.WriteLine("\nPlease press type the corresponding letter and press enter!");
        }
    }
}
    
