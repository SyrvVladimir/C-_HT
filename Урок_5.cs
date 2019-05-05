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
            WriteLine("Введите число ");
            string a = ReadLine();
            char[] b = a.ToCharArray();
            Array.Reverse(b);
            WriteLine(b);
            ReadKey();
        }
    }
}