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
            bool result = int.TryParse(Console.ReadLine(), out int a);
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
            bool result = int.TryParse(Console.ReadLine(), out int a);

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
            bool result = int.TryParse(Console.ReadLine(), out int a);

            if(DateTime.IsLeapYear(a))
            {
                Console.WriteLine(a + " Is a leap year.");
            }
            else if (a <1000)
                Console.WriteLine(" Unknow");
            else {
                Console.WriteLine(a + " Is not a leap year.");
            }
        }
    }

}
