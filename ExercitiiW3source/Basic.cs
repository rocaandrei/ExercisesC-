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
        public static void HextoDec()//convert a hexadecimal number to decimal number.
        {
            string hexVal = "8BB0";
            int decVal = int.Parse(hexVal, System.Globalization.NumberStyles.HexNumber);

            Console.WriteLine(decVal);
        }
        public static void MultiplyArrayElements()// multiply corresponding elements of two arrays of integers.
        {
            int[] firstArray = new[] { 1, 5, 20, -3 };
            int[] secondArray = new[] { 5, 2, 30, 4 };

            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.WriteLine(firstArray[i] * secondArray[i] + " ");
            }
        }
        public static void ReturnFourCopy()//create a new string of four copies, taking last four characters from a given string.
        {
            string pop = "Ana are mere si pere mici";
            string[] popArray = pop.Split(new[] { " " }, StringSplitOptions.None);
            if (popArray[popArray.Length - 1].Length == 4)
            {
                Console.WriteLine("{0} {0} {0} {0}", popArray[popArray.Length - 1]);
            }
            else
                Console.WriteLine(pop);
        }
        public static bool MultipleNo(int no)//check if a given positive number is a multiple of 3 or a multiple of 7
        {
            if (no % 3 == 0 || no % 7 == 0)
            { return true; }
            else { return false; }
        }
        public static bool StartsHello(string prop)//if a string starts with a specified word [Hello]
        {
            string[] myPop = prop.Split(new[] { " " }, StringSplitOptions.None);
            if (myPop[0] == "Hello")
            {
                return true;
            }
            else
                return false;
        }
        public static bool LessGreater(int a, int b)// program to check two given numbers where one is less than 100 and other is 
        {
            if (a < 100 && b > 200)
                return true;
            else
                return false;
        }
        public static bool Range(int a, int b)//check if an integer (from the two given integers) is in the range -10 to 10.
        {
            if ((a > -10 && b > -10) && (a < 10 && b < 10))
                return true;
            else
                return false;
        }
    }
}
