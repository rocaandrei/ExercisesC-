using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercitiiW3source
{
    public class DataTypes
    {
        public static void DisTriangle(int a, int b)//takes a number and a width also a number, as input and then displays a triangle of that width
        {
            int inaltime = b;
            int lungime = b;
            for (int i = 0; i < inaltime; i++)
            {
                for (int j = 0; j < lungime; j++)
                {
                    Console.Write(a);
                }
                Console.WriteLine();
                lungime--;// am definit diferit pentru a nu-mi scadea din ambele si inaltime si lungime 
            }
        }
        public static void Calc()
        {
            Console.Write("Enter first no: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter operation: ");
            var sign = Console.ReadLine();
            Console.Write("Enter second no: ");
            int b = int.Parse(Console.ReadLine());

            if (sign == "-")
            {
                Console.WriteLine("Result: " + (a - b));
            }
            else if (sign == "+")
            {
                Console.WriteLine("Result: " + (a + b));
            }
            else if (sign == "*")
            {
                Console.WriteLine("Result: " + (a * b));
            }
            else if (sign == "/")
            {
                Console.WriteLine("Result: " + (a / b));
            }
        }
        
        public static void CircleArea_Per()
        {
            Console.Write("Input the radius of the circle: ");
            double radius = int.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2.0);
            double perimeter = 2 * Math.PI * radius;
            Console.WriteLine("Area of Circle: " + area);
            Console.WriteLine("Perimeter of Circle: " + perimeter);

        }
        //Sharp program to display certain values of the function x = y2 + 2y + 1 (using integer numbers for y , ranging from -5 to +5).
        public static void MoreMath()
        {
            for (int i = -5; i < 6; i++)
            {
                Console.WriteLine("Result from " + i+ " is: " + ((Math.Pow(i,2)- (2*i) + 1)));
            }
        }
    }
}
