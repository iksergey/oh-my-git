

## DO NOT COMPILE THIS IS THE MAIN VERSION OF THE GAME TIC-TAC-TOE

```C#
using Project2.Game;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _named_
{
    public static class **named**
    {
        static void Main()
        {
            //Showing our tic tac toe field
            string[,] map = new string[3, 3]
            {
            {"1", "2", "3"},
            {"4", "5", "6"},
            {"7", "8", "9"}
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(map[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //if noone wins we have to count
            int total = 0;
            string win = HasWinner.win(map);

            //User's choice 
            Console.Write("Выберете за кого хотите играть: X или O (пиши с верхним регистром НА АНГЛ!): ");
            string choice = Console.ReadLine();

            Console.WriteLine();
            //start the game
            while (win != "Победили крестики" && win != "Победили нолики" && total < 9)
            {

                //User's number
                Console.Write("Выберете цифру: ");
                int answer = int.Parse(Console.ReadLine());
                Console.WriteLine();

                total++;

                //checking limits
                if ((answer >= 1 && answer <= 9) && (choice == "X" || choice == "O"))
                {
                    //checking if the answer is a free place on the field
                    if (IsMoveCorrect.Correct(map, answer))
                    {
                        // changing the field 
                        map = MakeMove.Make_move(map, answer, choice);

                        // showing the field with the change
                        PrintMap.Print_Map(map);

                        //checking if its over or not
                        win = HasWinner.win(map);

                        if (win != "Победили крестики" && win != "Победили нолики" && total < 9)
                        {
                            //changing the side
                            if (choice == "X")
                            {
                                Console.WriteLine("Теперь ходят \"O\"");
                                choice = "O";
                            }
                            else
                            {
                                Console.WriteLine("Теперь ходят \"X\"");
                                choice = "X";
                            }
                        }
                        else if (total == 9 && win != "Победили крестики" && win != "Победили нолики")
                        {
                            Console.WriteLine("Ничья!");
                        }
                        else
                        {
                            Console.WriteLine(win);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ячейка занята!");
                    }
                }
                else
                {
                    Console.WriteLine("Цифра от 1 до 9.");
                }

            }
        }
    }
}
```