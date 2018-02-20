using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConditionalLoop;

namespace ExercitiiW3source
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(  Fibonacci.FibonacciRec(i));
            }
        }

    }

}
