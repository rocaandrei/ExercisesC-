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
            Numbers unu = new Numbers();
            unu.No = 1;
            unu.Type = "impar";
            Numbers doi = new Numbers(2, "par");
            CalculateAB(unu.No, doi.No);

            Console.ReadKey();
        }
        public static void CalculateAB(int a, int b)
        {
            Console.WriteLine("Mathematical opperation: " + Environment.NewLine + a + ", " + b);
            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("a X b = " + a * b);
            Console.WriteLine("a - b = " + (a - b));
            Console.WriteLine("a : b = " + (a / b));
        }
        public class Numbers
        {
            public int No;
            public string Type;

            public Numbers() { }
            public Numbers(int no, string type)
            {
                No = no;
                Type = type;
            }
        }

    }
}
