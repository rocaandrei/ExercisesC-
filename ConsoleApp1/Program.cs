using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            FirstChar[] arrayExamples = new FirstChar[] { new FirstChar("GeeksforGeeks"), new FirstChar("Andrei"), new FirstChar(""), new FirstChar(" ") };
            foreach (var item in arrayExamples)
            {
                item.NonRepeted();
            }
            Console.ReadKey();
        }

        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            List<string> subs = new List<string>();

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i][0] >= 55 && (data[i][1] >= 7 && data[i][1] <= 26))
                {
                    subs.Add("Senior");
                }
                else
                    subs.Add("Open");
            }
            return subs;
        }  }
}


