using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsExercises
{
    public class Exercises
    {
        public static bool XO(string input)// verifies if the string contains 'o' and 'x'
        {
            string str = input.ToLower();
            int xCounter = 0;
            int oCounter = 0;
            int sum = 0;
            foreach (Char c in str)
            {
                if (Char.ToLower(c) == 'x') xCounter++;
                else if (Char.ToLower(c) == 'o') oCounter++;
                sum = xCounter + oCounter;
            }
            if (xCounter > 0 && oCounter > 0 && sum == 4)
            { return true; }
            else if (xCounter == 0 && oCounter == 0)
            {
                return true;
            }
            else
                return false;
        }
        public static string HighAndLow3(string numbers)
        {
            var parsed = numbers.Split(' ').Select(int.Parse);
            return parsed.Max() + " " + parsed.Min();
        }
        public static string HighAndLow(string numbers)
        {
            string[] str;
            str = numbers.Split(' ');
            int[] intArr = new int[5];
            for (int i = 0; i <= str.Length - 1; i++)
            {
                intArr[i] = int.Parse(str[i]);
            }
            for (int i = 1; i <= intArr.Length - 1; i++)
            {
                for (int j = 0; j < intArr.Length - i; j++)
                {
                    if (intArr[j] > intArr[j + 1])
                    {
                        Swap(intArr, j, j + 1);
                    }
                }
            }
            string MaxMin = Convert.ToString(intArr[0] + " " + intArr[intArr.Length - 1]);
            return MaxMin;
        }
        public static int[] BubbleSort(int[] sir)
        {
            for (int i = 1; i <= sir.Length - 1; i++)
            {
                for (int j = 0; j < sir.Length - i; j++)
                {
                    if (sir[j] > sir[j + 1])
                    {
                        Swap(sir, j, j + 1);
                    }
                }
            }
            return sir;
        }
        private static void Swap(int[] array, int a, int b)
        {
            int aux = array[a];
            array[a] = array[b];
            array[b] = aux;
        }
    }
}
