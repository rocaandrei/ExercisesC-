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
    }
}
