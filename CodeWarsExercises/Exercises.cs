using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsExercises
{
    public class Exercises
    {
        public static bool XO(string input)// verifica daca stringul contine caracterul 'x' si 'o'
        {
            string str = input.ToLower();
            int xCounter = 0;
            int oCounter = 0;
            foreach (Char c in str)
            {
                if (Char.ToLower(c) == 'x') xCounter++;
                else if (Char.ToLower(c) == 'o') oCounter++;
            }
            if (xCounter > 0 && oCounter > 0)
                return true;
            else
                return false;
        }
    }
}
