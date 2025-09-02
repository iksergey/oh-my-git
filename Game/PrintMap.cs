using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _named_
{
    public static class PrintMap
    {
        public static void Print_Map(string[,] map)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (map[i, j] == "X")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("X" + " ");
                        Console.ResetColor();
                    }
                    else if (map[i, j] == "O")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("0" + " ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(map[i, j] + " ");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
