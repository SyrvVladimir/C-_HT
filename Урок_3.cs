using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Point
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введите число из 6 цифр ");
            string word = ReadLine();
            foreach (char w in word)
            {
                if(w==Char.ToLower(w))
                {
                    Write(char.ToUpper(w));
                }
                else
                {
                    Write(char.ToLower(w));
                }
            }
            WriteLine();
            ReadKey();
        }
    }
}