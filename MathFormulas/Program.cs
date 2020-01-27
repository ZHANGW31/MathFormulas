using System;

namespace MathFormulas
{
    using System;



    class Program
    {
        static void Main(string[] args)
        {


        }

        static double CircleCircumference(double radius)
        {
            Console.WriteLine("\nPart 1, circumference and area of a circle.");
            Console.Write("Enter an integer for the radius to find the circumference of the circle: ");
            //This line allows for user input in the console.
            string strradius = Console.ReadLine();
            //int.Parse takes the user input and converts it into a integar which then allows for the code to assign it as an int
            int intradius = int.Parse(strradius);
            double circumference = 2 * Math.PI * intradius;
            Console.WriteLine($"The circumference is {circumference}");

            return circumference;
        }

        //Part 1 Area of Circle implementation here.
        static double AreaOfCircle(double radius)
        {
            Console.Write("Enter an integer for the radius to find the area of the circle: ");
            var strradius = Console.ReadLine();
            int intradius = int.Parse(strradius);
            double area = Math.PI * (intradius * intradius);
            Console.WriteLine($"The area is {area}");

            return area;
        }

        // Part 2 Volume of Hemisphere implementation here.
        static double Hemisphere(double radius)
        {
            Console.WriteLine("\nPart 2, volume of a hemisphere.");
            Console.Write("Enter an integer for the radius to find the volume of the hemisphere: ");
            var strradius = Console.ReadLine();
            int intradius = int.Parse(strradius);

            // Formulas for r cubed, and the volume.
            double rCubed = (intradius * intradius * intradius);
            double volume = (4.0 / 3.0) * Math.PI * rCubed / 2;
            Console.WriteLine($"The volume is {volume}");

            return volume;
        }

        // Part 3 Area of Triangle implementation here.
        static double AreaOfTriangle(double sides)
        {


            Console.WriteLine("\nPart 3, Area of a triangle given the length of the sides");
            Console.Write("Enter an integer for the lenth of the first side:");
            string strtriangleSideOne = Console.ReadLine();
            Console.Write("Enter an integer for the length of the second side:");
            string strtriangleSideTwo = Console.ReadLine();
            Console.Write("Enter an integer for the length of the third side:");
            string strtriangleSideThree = Console.ReadLine();

            // Takes user input for each side of the triangle and parses the string and converts it into an integer.

            double inttriangleSideOne = int.Parse(strtriangleSideOne);
            double inttriangleSideTwo = int.Parse(strtriangleSideTwo);
            double inttriangleSideThree = int.Parse(strtriangleSideThree);

            double a = inttriangleSideOne;
            double b = inttriangleSideTwo;
            double c = inttriangleSideThree;

            // Formulas to identify the half of the circumference and the area of the triangle.

            double p = (a + b + c) / 2;

            double triangleArea = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine($"The area of the triangle is {triangleArea}");

            return triangleArea;

        }

        // Part 4 Solving a quadratic equation.

        // Implementation here

        static double QuadraticFormula(double values)
        {
            Console.WriteLine("\nPart 4, solving a quadratic equation.");
            Console.WriteLine("Please enter an integer for a:");
            string astr = Console.ReadLine();
            Console.WriteLine("Please enter the integer for b:");
            string bstr = Console.ReadLine();
            Console.WriteLine("Please enter the integer for c:");
            string cstr = Console.ReadLine();

            double anum = int.Parse(astr);
            double bnum = int.Parse(bstr);
            double cnum = int.Parse(cstr);

            double positive_num = (bnum * -1.0) + Math.Sqrt(Math.Pow(bnum, 2) - 4.0 * anum * cnum);
            double negative_num = (bnum * -1.0) - Math.Sqrt(Math.Pow(bnum, 2) - 4.0 * anum * cnum);
            double denominator = 2.0 * anum;


            Console.WriteLine($"The positive solution is {positive_num / denominator}");
            Console.WriteLine($"The negative solution is {negative_num / denominator}");

            return positive_num;
        }


    }
}
    
