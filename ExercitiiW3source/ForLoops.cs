using System;

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
        public static void IsoscelTriangleNo(int row)
        {
            int count = 1;
            int spc = row - 1;

            for (int i = 1; i <= row; i++)// for-ul ce ne face randurile
            {
                for (int k = spc; k >= 1; k--)//for pentru coloane 
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)//for pentru coloane 
                {
                    Console.Write(" "+count++);
                    if (count == 15)
                    {
                        break;//break-ul asta imi face triunchil isoscel/mai frumos... daca e compus doar din 5 randuri
                    }
                }
                Console.WriteLine();
                spc--;
            }
        }
        public static void IsoscelTriangle()
        {
            int spc = 6;
            for (int i = 0; i <= 5; i++)
            {
                for (int j = spc; j >=1; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
                spc--;
            }
        }
        public static void FactorialNo(int no) // calcul factorial, adia 5! = 5*4*3*2*1 = 120
        {
            int count = 1;
            int factorial = 1;
            while (no >= count )
            {
                factorial *= count;
                count++;
            }
            Console.WriteLine("The factorial of " + no + " is " + factorial);
        }
        public static void EvenNo(int no)
        {
            int sum = 0;
            for (int i = 1; i <= no; i++)
            {
                Console.Write( " " + (2*i));
                sum += 2 * i;
            }
            Console.WriteLine("\nThe Sum of even Natural Number upto {0} terms : {1} \n", no, sum);
        }
    }
}
