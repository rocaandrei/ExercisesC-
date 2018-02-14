using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercitiiW3source
{
    public class Program
    {

        public static void Main(string[] args)
        {


            Console.WriteLine(Fibonacci.FibonacciNo(0));
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(i + "= " +Fibonacci.FibonacciRec(i));
            }
            


        }

        
    }
}
