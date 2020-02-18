using System;
using MathFormulas;

namespace MathFormulas
{
    using System;

    public class Program
    {
        public static void Main(string[] args) //Entry point, Writelines into the console how to use this application.
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
                var userSelection = UserInputClass.InitialInputValue(); //user input validation

                if (userSelection == 1) 
                {
                    Console.WriteLine("You chose to calculate the circumference and area of the circle.");
                    Console.WriteLine("We now need a number from you for the radius");
                    int circleInput = UserInputClass.ValidateUserInput();                    
                    Console.WriteLine($"The Area of the circle is: {Calculations.AreaOfCircle(circleInput)}");
                    Console.WriteLine($"The circumference of the circle is {Calculations.CircleCircumference(circleInput)}");
                }
                if (userSelection == 2)
                {
                    int hemisphereInput = UserInputClass.ValidateUserInput();
                    Console.WriteLine($"The volume of the hemisphere is: {Calculations.Hemisphere(hemisphereInput)}");
                }
                if (userSelection == 3)
                {
                    Console.WriteLine("\nPlease enter the first side!");
                    int triangleInputOne = UserInputClass.ValidateUserInput();
                    Console.WriteLine("Please enter the second side!");
                    int triangleInputTwo = UserInputClass.ValidateUserInput();
                    Console.WriteLine("Please enter the third side!");
                    int triangleInputThree = UserInputClass.ValidateUserInput();

                    Console.WriteLine($"The area of the triangle is {Calculations.AreaOfTriangle(triangleInputOne, triangleInputTwo, triangleInputThree)}");
                }
                if (userSelection == 4)
                {
                    Console.WriteLine("Please enter a value for a");
                    int valueA = UserInputClass.ValidateUserInput();
                    Console.WriteLine("Please enter a value for b");
                    int valueB = UserInputClass.ValidateUserInput();
                    Console.WriteLine("Please enter a value for c");
                    int valueC = UserInputClass.ValidateUserInput();
                    Calculations.QuadraticFormula(valueA, valueB, valueC);
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
       
    }
}
    
