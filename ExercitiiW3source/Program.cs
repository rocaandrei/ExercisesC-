using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercitiiW3source
{
    class Program
    {
        static void Main(string[] args)
        {
            Basic.ReverseSentence("Ana are mere si motanul e cuminte.");
        }

        public static void CalculateAB(int a, int b)
        {
            Console.WriteLine("Mathematical opperation: " + Environment.NewLine + a + ", " + b);
            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("a X b = " + a * b);
            Console.WriteLine("a - b = " + (a - b));
            Console.WriteLine("a : b = " + (a / b));
        }
        public static void PrintNo()
        {
            string Row1 = "  # ### ### # # ### ### ### ### ### ### ";
            string Row2 = "  #   #   # # # #   #     # # # # # # # ";
            string Row3 = "  # ### ### ### ### ###   # ### ### # # ";
            string Row4 = "  # #     #   #   # # #   # # #   # # # ";
            string Row5 = "  # ### ###   # ### ###   # ###   # ### ";
            while (true)
            {

                Console.WriteLine("Introduceti un numar: ");
                string nrString = Console.ReadLine();
                char[] nrInCifre = nrString.ToCharArray();

                for (int j = 0; j < nrInCifre.Length; j++)
                {

                    //int cifra = int.Parse(Console.ReadLine());

                    if (nrInCifre[j] == '1')
                    {
                        string unu = Row1.Substring(0, 4);
                        for (int i = 1; i < 6; i++)
                        {
                            Console.WriteLine(unu);
                        }
                    }
                    else if (nrInCifre[j] == '2')
                    {
                        string unu = Row1.Substring(3, 5);
                        string doi = Row2.Substring(3, 5);
                        string trei = Row4.Substring(3, 5);
                        for (int i = 1; i < 6; i++)
                        {
                            if (i % 2 != 0)
                            {
                                Console.WriteLine(unu);
                            }
                            else if (i == 2)
                            {
                                Console.WriteLine(doi);
                            }
                            else if (i == 4)
                            {
                                Console.WriteLine(trei);
                            }
                        }
                    }
                    else if (nrInCifre[j] == '3')
                    {
                        string unu = Row1.Substring(7, 5);
                        string doi = Row2.Substring(7, 5);
                        for (int i = 1; i < 6; i++)
                        {
                            if (i % 2 != 0)
                            {
                                Console.WriteLine(unu);
                            }
                            else if (i % 2 == 0)
                            {
                                Console.WriteLine(doi);
                            }
                        }
                    }
                    else if (nrInCifre[j] == '4')
                    {
                        string unu = Row1.Substring(11, 5);
                        string doi = Row2.Substring(11, 5);
                        string trei = Row3.Substring(11, 5);
                        string patru = Row4.Substring(11, 5);
                        string cinci = Row5.Substring(11, 5);
                        Console.WriteLine(unu);
                        Console.WriteLine(doi);
                        Console.WriteLine(trei);
                        Console.WriteLine(patru);
                        Console.WriteLine(cinci);
                    }
                    else if (nrInCifre[j] == '5')
                    {
                        string patru1 = Row1.Substring(15, 5);
                        string patru2 = Row2.Substring(15, 5);
                        string patru3 = Row3.Substring(15, 5);
                        string patru4 = Row4.Substring(15, 5);
                        string patru5 = Row5.Substring(15, 5);
                        Console.WriteLine(patru1);
                        Console.WriteLine(patru2);
                        Console.WriteLine(patru3);
                        Console.WriteLine(patru4);
                        Console.WriteLine(patru5);
                    }
                    else if (nrInCifre[j] == '6')
                    {
                        string patru1 = Row1.Substring(19, 5);
                        string patru2 = Row2.Substring(19, 5);
                        string patru3 = Row3.Substring(19, 5);
                        string patru4 = Row4.Substring(19, 5);
                        string patru5 = Row5.Substring(19, 5);
                        Console.WriteLine(patru1);
                        Console.WriteLine(patru2);
                        Console.WriteLine(patru3);
                        Console.WriteLine(patru4);
                        Console.WriteLine(patru5);
                    }
                    else if (nrInCifre[j] == '7')
                    {
                        string patru1 = Row1.Substring(23, 5);
                        string patru2 = Row2.Substring(23, 5);
                        string patru3 = Row3.Substring(23, 5);
                        string patru4 = Row4.Substring(23, 5);
                        string patru5 = Row5.Substring(23, 5);
                        Console.WriteLine(patru1);
                        Console.WriteLine(patru2);
                        Console.WriteLine(patru3);
                        Console.WriteLine(patru4);
                        Console.WriteLine(patru5);
                    }
                    else if (nrInCifre[j] == '8')
                    {
                        string patru1 = Row1.Substring(27, 5);
                        string patru2 = Row2.Substring(27, 5);
                        string patru3 = Row3.Substring(27, 5);
                        string patru4 = Row4.Substring(27, 5);
                        string patru5 = Row5.Substring(27, 5);
                        Console.WriteLine(patru1);
                        Console.WriteLine(patru2);
                        Console.WriteLine(patru3);
                        Console.WriteLine(patru4);
                        Console.WriteLine(patru5);
                    }
                    else if (nrInCifre[j] == '9')
                    {
                        string patru1 = Row1.Substring(31, 5);
                        string patru2 = Row2.Substring(31, 5);
                        string patru3 = Row3.Substring(31, 5);
                        string patru4 = Row4.Substring(31, 5);
                        string patru5 = Row5.Substring(31, 5);
                        Console.WriteLine(patru1);
                        Console.WriteLine(patru2);
                        Console.WriteLine(patru3);
                        Console.WriteLine(patru4);
                        Console.WriteLine(patru5);
                    }
                    else if (nrInCifre[j] == '0')
                    {
                        string patru1 = Row1.Substring(35, 5);
                        string patru2 = Row2.Substring(35, 5);
                        string patru3 = Row3.Substring(35, 5);
                        string patru4 = Row4.Substring(35, 5);
                        string patru5 = Row5.Substring(35, 5);
                        Console.WriteLine(patru1);
                        Console.WriteLine(patru2);
                        Console.WriteLine(patru3);
                        Console.WriteLine(patru4);
                        Console.WriteLine(patru5);
                    }
                }
            }
        }
    }
}
