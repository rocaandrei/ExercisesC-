using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercitiiW3source
{
    public class Fibonacci
    {
        public static int FibonacciNo(int n)// fibonacci sequence
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        public static int FibonacciRec(int no)//fibonacci with recursion 
        {
            if (no == 0)
            {
                return 0;
            }
            if (no == 1)
            {
                return 1;
            }
            else
            {
                return FibonacciRec(no - 2) + FibonacciRec(no - 1);
            }
        }
    }
}
