using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class FirstChar // /Write an algorithm to find first non repeated character of a given String. 
    {
        public string str { get; set; }

/// <summary>
/// Add a string to the constructor, we will use it in our NonRepeted method
/// </summary>
/// <param name="s">string</param>
        public FirstChar(string s)
        {
            str = s;
        }
        public void NonRepeted()
        {
            string s = str.ToLower();
            char[] charsFromString = s.ToCharArray();
            int[] countCh = new int[s.Length];
            for (int i = 0; i < charsFromString.Length; i++)
            {
                for (int j = 0; j < charsFromString.Length; j++)
                {
                    if(charsFromString[i] == charsFromString[j])
                    {
                        countCh[i] += 1;
                    }
                }
            }
            for (int i = 0; i < countCh.Length; i++)
            {
                if (countCh[i] == 1)
                {
                    Console.WriteLine("The first non repeated char in this: {0} string is: '{1}'.",str,charsFromString[i]);
                    return;
                }
               
            }
            if(s.Length == 0)
            {
                Console.WriteLine("There arrent any chars in this string.");
            }
        }
    }
}
