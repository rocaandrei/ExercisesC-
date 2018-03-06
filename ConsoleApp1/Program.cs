using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConditionalLoop;
using CodeWarsExercises;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Concat(HighAndLow("1 2 -3 4 5"))); // return "5 -3
        }
        public static string HighAndLow(string numbers)
        {
          
            string[] str;
            str = numbers.Split(' ');
            int[] intArr = new int[5];
            

            for (int i = 0; i < str.Length - 1; i++)
            {
                intArr[i] = int.Parse(str[i]);
            }
            for (int i = 0; i < intArr.Length-1; i++)
            {
                for (int j = 0; i < intArr.Length-i; j++)
                {
                    if (intArr[j] > intArr[j + 1])
                    {
                        intArr[j] = intArr[j] + intArr[j + 1];
                        intArr[j + 1] = intArr[j] - intArr[j + 1];
                        intArr[j] = intArr[i] - intArr[j + 1];
                    }
                }
            }
            string MaxMin = Convert.ToString(intArr[0] + " " + intArr[intArr.Length - 1]);
            
            // Code here or
            return MaxMin;
        }
       /* In this little assignment you are given a string of space separated numbers, and have to return 
        * the highest and lowest number.

Example:

Kata.HighAndLow("1 2 3 4 5"); // return "5 1"
        Kata.HighAndLow("1 2 -3 4 5"); // return "5 -3"
        Kata.HighAndLow("1 9 3 4 -5"); // return "9 -5"
        Notes:

All numbers are valid Int32, no need to validate them.
There will always be at least one number in the input string.
Output string must be two numbers separated by a single space, and highest number is first.*/




    }
}
