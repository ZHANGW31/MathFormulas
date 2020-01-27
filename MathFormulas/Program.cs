using System;

namespace MathFormulas
{
    using System;



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Wei's math formula calculator! ");
            Console.WriteLine("\nPlease select from the following.");
            Console.WriteLine("\nI want to...");
            Console.WriteLine("\n(1)Calculate the circumference and Area of the circle given the radius");
            Console.WriteLine("(2)Calculate the volume of the hemisphere given the radius");
            Console.WriteLine("(3)Calculate the Area of the triangle given the length of the sides");
            Console.WriteLine("(4)Solve a quadratic equation");
            Console.WriteLine("\nPlease press type the corresponding letter and press enter!");
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

            } catch (Exception)
            {
                Console.WriteLine("An unexpected error has occured!");
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
                if (!int.TryParse(fromUser, out output))
                {
                    Console.WriteLine("{0} is not a valid input", fromUser);
                    Console.WriteLine("Please enter a valid value");
                    fromUser = Console.ReadLine();
                    continue;
                }

                if(output > 4)
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
                if(output < 0)
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
                double area = Math.PI * (Math.Pow(radius, 2));
                return area;
            }
        }
        // Part 2 Volume of Hemisphere implementation here.
        static double Hemisphere(int radius)
        {
            checked
            {
                int intradius = radius;
                // Formulas for r cubed, and the volume.
                double rCubed = (intradius * intradius * intradius);
                double volume = (4.0 / 3.0) * Math.PI * rCubed / 2;
                return volume;
            }
        }

        // Part 3 Area of Triangle implementation here.
        static double AreaOfTriangle(int sideOne, int sideTwo, int sideThree)
        {
            checked
            {
                var a = sideOne;
                var b = sideTwo;
                var c = sideThree;
                double p = (a + b + c) / 2;
                double triangleArea = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return triangleArea;
            }
        }

        // Part 4 Solving a quadratic equation.
        static double QuadraticFormula(int a, int b, int c)
        {
            checked
            {
                double positive_num = ((double)b * -1.0) + Math.Sqrt(Math.Pow((double)b, 2) - 4.0 * (double)a * (double)c);
                double negative_num = ((double)b * -1.0) - Math.Sqrt(Math.Pow((double)b, 2) - 4.0 * (double)a * (double)c);
                double denominator = 2.0 * (double)a;
                Console.WriteLine($"\nThe positive solution is {positive_num / denominator}");
                Console.WriteLine($"\nThe negative solution is {negative_num / denominator}");
                return positive_num;
            }
        }


    }
}
    
