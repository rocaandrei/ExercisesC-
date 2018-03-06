using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalLoop
{
    public class ConditionalStatements
    {
        public static void EqualOrNot()
        {
            Console.WriteLine("Input firs no: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second no: ");
            int b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine(a + " and " + b + " are equal.");
            }
            else
                Console.WriteLine(a + " and " + b + " are not equal.");
        }
        public static void EvenOdd()
        {
            Console.WriteLine("Enter no: ");
            int a = 0;
            bool result = int.TryParse(Console.ReadLine(), out a);
            if (a % 2 == 0)
            {
                Console.WriteLine("Number " + a + " is even.");
            }
            else
                Console.WriteLine("Number " + a + " is odd.");
        }
        public static void PositiveOrNegativeNo()
        {
            Console.WriteLine("Enter no: ");
            int a = 0;
            bool result = int.TryParse(Console.ReadLine(), out a);

            if (a > 0)
            {
                Console.WriteLine(a + " is positive.");
            }
            else
                Console.WriteLine(a + " is negative.");
        }
        public static void LeapYear()
        {
            Console.Write("Enter year: ");
            int a = 0;
            bool result = int.TryParse(Console.ReadLine(), out a);

            if (DateTime.IsLeapYear(a))
            {
                Console.WriteLine(a + " Is a leap year.");
            }
            else if (a < 1000)
                Console.WriteLine(" Unknow");
            else
            {
                Console.WriteLine(a + " Is not a leap year.");
            }
        }
        public static void ToVote()
        {
            Console.Write("Enter your age: ");
            int a = 0;
            bool result = int.TryParse(Console.ReadLine(), out  a);

            if (a >= 18)
            {
                Console.WriteLine("You can vote!");
            }
            else
                Console.WriteLine("You can't vote!");
        }
        public static void DetermineN()
        {
            Console.Write("Input m value:");
            int m = 0;
            bool result = int.TryParse(Console.ReadLine(), out  m);
            int n = 0;

            if (m == 0)
            {
                Console.WriteLine("n = " + n);
            }
            else if (m > 0)
            {
                Console.WriteLine("n = " + (n + 1));
            }
            else
                Console.WriteLine("n = " + (n - 1));
        }
        public static void YourHeight()
        {
            Console.WriteLine("Enter your height in cm: ");
            int a = 0;
            bool result = int.TryParse(Console.ReadLine(), out a);
            if (a < 135)
            {
                Console.WriteLine("Dwarf");
            }
            else if (a > 135 && a < 175)
            {
                Console.WriteLine("Normal");
            }
            else
                Console.WriteLine("Tall");
        }
        public static void TheLargestNo(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                Console.WriteLine("First no is the Largest");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("Second no is the Largest");
            }
            else
                Console.WriteLine("The third no is the Largest");
        }
        public static void Quadrant()
        {
            Console.WriteLine("Enter x:");
            int x = 0;
            bool result = int.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Enter y: ");
            int y = 0;
            result = int.TryParse(Console.ReadLine(), out  y);
            Console.WriteLine(x > 0 && y > 0 ? "The coordinate point (" + x + "," + y + ") lies in the First quadrant." : null);
            Console.WriteLine(x > 0 && y < 0 ? "The coordinate point (" + x + "," + y + ") lies in the Second quadrant." : null);
            Console.WriteLine(x < 0 && y < 0 ? "The coordinate point (" + x + "," + y + ") lies in the Third quadrant." : null);
            Console.WriteLine(x < 0 && y > 0 ? "The coordinate point (" + x + "," + y + ") lies in the Fourth quadrant." : null);
        }
        public static void EligibilityAdmission()
        {
            Console.Write("Input the marks obtained in Mathematics: ");
            int math = 0;
            bool result = int.TryParse(Console.ReadLine(), out math);
            Console.Write("Input the marks obtained in Physics: ");
            int phy = 0;
            result = int.TryParse(Console.ReadLine(), out phy);
            Console.Write("Input the marks obtained in Chemistry: ");
            int chem = 0;
            result = int.TryParse(Console.ReadLine(), out  chem);
            while (math >= 65 && phy >= 55 && chem >= 50)
            {
                if ((math + phy + chem) > 180 || (math + phy) > 140)
                {
                    Console.WriteLine("The candidate is eligible for admission.");
                }
                else
                    Console.WriteLine("The candidate is not eligible");
                break;
            }
            if (math < 65 && phy < 55 && chem < 50)
            {
                Console.WriteLine("The candidate is not eligible");
            }
        }
        public static void StudentRoll()
        {
            Console.Write("Input the Roll Number of the student: ");
            string rollNo = Console.ReadLine();
            Console.Write("Input the Name of the Student: ");
            string name = Console.ReadLine();
            Console.WriteLine("Input the marks of Physics, Chemistry and Computer Application: ");
            string phyChemCop = Console.ReadLine();
            string[] grades = phyChemCop.Split(' ');
            int sum = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                sum += int.Parse(grades[i]);
            }
            Console.WriteLine("Marks in Physics: " + grades[0]);
            Console.WriteLine("Marks in Chemistry: " + grades[1]);
            Console.WriteLine("Marks in Computer Application: " + grades[2]);
            Console.WriteLine("Total Marks = " + sum);
            Console.WriteLine("Percentage = " + sum / 3.0);

            if ((sum / 3.0) > 60.0)
            {
                Console.WriteLine("Division = First");
            }
            else if ((sum / 3.0) > 40.0 && (sum / 3.0) < 60.0)
            {
                Console.WriteLine("Division = Second");
            }
            else if ((sum / 3.0) < 40.0)
            {
                Console.WriteLine("Division = Faild");
            }
        }

        public static void Centigrade()
        {
            Console.WriteLine("Enter Centigrade: ");
            int temp = int.Parse(Console.ReadLine());

            if (temp < 0)
            { Console.WriteLine("Freezing weather"); }
            else if (temp >= 0 && temp < 10)
            {
                Console.WriteLine("Cold weather");
            }
            else if (temp > 20 && temp < 30)
            {
                Console.WriteLine("Normal in Temp");
            }
            else if (temp > 30 && temp < 40)
            {
                Console.WriteLine("Its Hot");
            }
            else if (temp >= 40)
            {
                Console.WriteLine("Its Very Hot");
            }
        }


    }


}



