using System;
using System.Collections.Generic;
using System.Text;

namespace MathFormulas
{
    public class Calculations
    {
        public static double CircleCircumference(int radius)
        {
            checked
            {
                double circumference = 2 * Math.PI * radius;
                return circumference;
            }
        }
        //Part 1 Area of Circle implementation here.
        public static double AreaOfCircle(int radius)
        {
            checked
            {
                double area = Math.PI * (radius * radius);
                return area;
            }
        }
        // Part 2 Volume of Hemisphere implementation here.
        public static double Hemisphere(int radius)
        {
            checked
            {
                double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3) / 2;
                return volume;
            }
        }
        // Part 3 Area of Triangle implementation here.
        public static double AreaOfTriangle(int sideOne, int sideTwo, int sideThree)
        {
            checked
            {
                double p = (sideOne + sideTwo + sideThree) / 2.0;
                double triangleArea = Math.Sqrt(p * (p - sideOne) * (p - sideTwo) * (p - sideThree));
                return triangleArea;
            }
        }
        // Part 4 Solving a quadratic equation.
        public static double QuadraticFormula(int a, int b, int c)
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
    }
}
