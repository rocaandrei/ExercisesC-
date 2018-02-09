using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercitiiW3source
{
    class Program
    {
        static void Main(string[] args)
        {
            //my first GitHub project

            Console.WriteLine("Hello world!");
            CalculateAB(5, 3);
            Console.ReadKey();

        }
        public static void CalculateAB(int a, int b)
        {
            Console.WriteLine("Mathematical opperation: "+ Environment.NewLine + a + ", " + b);
            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("a X b = " + a * b);
            Console.WriteLine("a - b = " + (a - b));
            Console.WriteLine("a : b = " + (a / b));



        }

    }
}
