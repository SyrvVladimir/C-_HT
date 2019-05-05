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
            WriteLine("Введите  1 число  ");
            string word1 = ReadLine();
            int w1 = 0;
            w1 = Int32.Parse(word1);
            WriteLine("Введите  2 число  ");
            string word2 = ReadLine();
            int w2 = 0;
            w2 = Int32.Parse(word2);
            if(w1 > w2)
            {
               for (int i=w2; i<=w1; i++)
               {
                    for(int j=0; j<w2; j++)
                    {
                        Write(w2 + " ");
                    }
                    WriteLine("\n");
                    w2++;
                };
            }
            WriteLine();
            ReadKey();
        }
    }
}