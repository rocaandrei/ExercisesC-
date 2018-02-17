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
                Console.WriteLine("Result from " + i + " is: " + ((Math.Pow(i, 2) - (2 * i) + 1)));
            }
        }
        public static void EnterPass()
        {
            Console.Write("Set user: ");
            string user = Console.ReadLine();
            Console.Write("Set pass: ");
            string pass = Console.ReadLine();
            string inputUser = "";
            string inputPass = "";
            int count = 1;
            do
            {
                Console.WriteLine("Please enter user: ");
                inputUser = Console.ReadLine();
                Console.WriteLine("Please enter pass: ");
                inputPass = Console.ReadLine();
                if (user == inputUser && pass == inputPass)
                {
                    Console.WriteLine("Welcome " + user + "!");
                    count = 4;
                }
                else
                    count++;

            } while (user != inputUser && pass != inputPass && count < 4);
            if (user != inputUser && pass != inputPass)
            {
                Console.WriteLine("Error try later.");
            }
        }
        public static void RadiusSphere()
        {
            Console.WriteLine("Input cercle radius: ");
            double radius = double.Parse(Console.ReadLine());
            double area = 4 * Math.PI * Math.Pow(radius, 2.0);
            double volume = 4f / 3f * Math.PI * Math.Pow(radius, 3.0);
            Console.WriteLine("The area is: " + area);
            Console.WriteLine("The volume is: " + volume);
        }
        public static void VerifyChar()
        {
            while (true)
            {
                Console.Write("Input char: ");
                char x = char.Parse(Console.ReadLine());

                if (Char.IsDigit(x))
                {
                    Console.WriteLine(x + " is a digit");
                }
                else if (x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u')
                {
                    Console.WriteLine(x + " is a vowel");
                }
                else if (Char.IsPunctuation(x))
                {
                    Console.WriteLine(x + " is a punctuation");
                }
                else
                { Console.WriteLine("Other..."); }
            }
        }
        //Program that takes two numbers as input and returns true or false when both numbers are even or odd.
        public static void OddEven()
        {
            Console.Write("Enter first no: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second no: ");
            int b = int.Parse(Console.ReadLine());

            if (a % 2 == 0 && b % 2 == 0)
            {
                Console.WriteLine("Both numbers are even.");
            }
            else if(a% 2!=0 && b%2 != 0)
            {
                Console.WriteLine("Both numbers are odd.");
            }
            else
            { Console.WriteLine("Don't know..."); }
        }
        public static void BinaryNo()
        {
            while (true)
            {
                Console.WriteLine("Input no: ");
                int a = int.Parse(Console.ReadLine());

                string binary = Convert.ToString(a, 2);//iti face singur conversia binara 
                Console.WriteLine("Binary no is: " + binary);
            }
        }
    }
}
