using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercitiiW3source
{
    public class ForLoops
    {

        public static void MultiplicationTable()
        {
            Console.WriteLine("Display the multiplication table form 1 to 10");

            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (j <= 10)
                        Console.Write(j + "x" + i + "= " + (j * i)+ " ");
                    else
                        Console.Write(j + "x" + i + "= " + (j * i) + " ");
                }
                Console.Write(Environment.NewLine);
            }
        }
        public static void OddNo()
        {
            Console.WriteLine("The sum of the first 10 odd numbers.");
            int sum = 0;
            for (int i = 1; i < 20; i++)
            {
                if(i%2 != 0 )
                {
                    sum += i;
                }
            }
            Console.WriteLine("The sum of the first 10 odd no is: "+ sum);
        }
        public static void PatternLikeTriangle(int n)
        {
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
        public static void PatternLikeTriangleNo(int no)
        {
            int k = 1;
            for (int i = 1; i < no; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(k++);
                }
                Console.WriteLine();
            }
        }
    }
}
