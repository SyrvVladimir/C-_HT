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
            char user;
            int spaces = 0;
            WriteLine("Введите символы ");
            do
            {
                user = ReadKey().KeyChar;
                if(user==' ')
                {
                    spaces++;
                }

            } while (user != '.');
            WriteLine(" ");
            WriteLine($"Количество пробелов = {spaces}");
            ReadKey();
        }
    }
}