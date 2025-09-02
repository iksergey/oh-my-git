using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Game
{
    public static class MakeMove
    {
        public static string[,] Make_move(string[,] map, int answer, string choice)
        {
            if (choice == "X")
            {
                switch (answer)
                {
                    case 1:
                        map[0, 0] = choice;
                        break;
                    case 2:
                        map[0, 1] = choice;
                        break;
                    case 3:
                        map[0, 2] = choice;
                        break;
                    case 4:
                        map[1, 0] = choice;
                        break;
                    case 5:
                        map[1, 1] = choice;
                        break;
                    case 6:
                        map[1, 2] = choice;
                        break;
                    case 7:
                        map[2, 0] = choice;
                        break;
                    case 8:
                        map[2, 1] = choice;
                        break;
                    case 9:
                        map[2, 2] = choice;
                        break;
                }
            }

            else if (choice == "O")
            {
                switch (answer)
                {
                    case 1:
                        map[0, 0] = choice;
                        break;
                    case 2:
                        map[0, 1] = choice;
                        break;
                    case 3:
                        map[0, 2] = choice;
                        break;
                    case 4:
                        map[1, 0] = choice;
                        break;
                    case 5:
                        map[1, 1] = choice;
                        break;
                    case 6:
                        map[1, 2] = choice;
                        break;
                    case 7:
                        map[2, 0] = choice;
                        break;
                    case 8:
                        map[2, 1] = choice;
                        break;
                    case 9:
                        map[2, 2] = choice;
                        break;
                }
            }
            return map;
        }
    }
}
