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
            string numberString = ReadLine();
            int number = Int32.Parse(numberString);
            int a = 0, b = 0, i = 6;
            do
            {
                  a += number % 10;
                  number /= 10;
                  i--;
            } while (i != 3);
            do
            {
                b += number % 10;
                number /= 10;
                i--;
            } while (i != 0);
            WriteLine(a + " " + b);
            if (a == b)
            {
                WriteLine("Lucky");
            }
            else
            {
                WriteLine("not Lucky");
            }
            ReadKey();
        }
    }
}