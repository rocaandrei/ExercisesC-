using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercitiiW3source
{
    public class Basic//exercises 
    {
        public static void LongestWord()//the longest word in a string
        {
            string myString = "This is a paralelipiped.";
            string[] words = myString.Split(new[] { " ", "." }, StringSplitOptions.None);// here we used the split method to create an array of strings from our initial string
            string word = "";
            int no = 0;
            foreach (string item in words)
            {
                if (item.Length > no)
                {
                    no = item.Length;
                    word = item;
                }
            }
            Console.WriteLine("The longest word is: " + word + " in this string (" + myString + ").");
        }
        public static void OddNumbers()//print the odd numbers from 1 to 99
        {
            Console.WriteLine("Odd numbers from 1 to 99 are: ");
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void PrimeNo(int no)//print the sum of first n prime numbers
        {
            Console.WriteLine("\nSum of the first " + no + " prime numbers: ");

            long sum = 0;
            int ctr = 0;
            int n = 2;
            while (ctr < no)
            {
                if (IsPrime(n))
                {
                    sum += n;
                    ctr++;
                }
                n++;
            }
            Console.WriteLine(sum);
        }

        public static bool IsPrime(int n)//defines if a number is prime or not
        {
            int x = (int)Math.Floor(Math.Sqrt(n));//It finds the square root of a number and then rounds it down to an integer. The Sqrt of 63 is 7.937....... so Math.Floor will assign "7" 
            for (int i = 2; i <= x; ++i)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        public static void SumOfDigits(int no)// compute the sum of the digits of an integer
        {
            string digits = no.ToString();//first I created a string of the number inputted 
            char[] arrayOfDigits = digits.ToCharArray();// transform the string in an array of Char
            int x = 0;
            int sum = 0;
            string holder = "";// the holder of the Char, the future digit

            foreach (char item in arrayOfDigits)
            {
                holder = item.ToString();
                x = int.Parse(holder);
                sum += x;
            }
            Console.WriteLine("The sum of the digits from " + no + " is: " + sum);
        }
        public static void ReverseSentence(string sentence)//reverse the words of a sentence
        {
            string[] revString = sentence.Split(new[] { " " }, StringSplitOptions.None);

            for (int i = revString.Length - 1; i > 0; i--)
            {
                Console.Write(revString[i] + " ");
            }
            Console.Write(revString[0]);
        }
       public static void HextoDec()
        {

        }

    }
}
