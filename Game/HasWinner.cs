using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Game
{
    public static class HasWinner
    {
        public static string win(string[,] map)
        {
            for (int i = 0; i < 3; i++)
            {
                if (map[i, 0] == map[i, 1] && map[i, 1] == map[i, 2])
                {
                    if (map[i, 0] == "X")
                    {
                        return "Победили крестики";
                    }
                    else
                    {
                        return "Победили нолики";
                    }
                }
                if (map[0, i] == map[1, i] && map[1, i] == map[2, i])
                {
                    if (map[0, i] == "X")
                    {
                        return "Победили крестики";
                    }
                    else
                    {
                        return "Победили нолики";
                    }
                }
            }

            if (map[0, 0] == map[1, 1] && map[1, 1] == map[2, 2])
            {
                if (map[0, 0] == "X")
                {
                    return "Победили крестики";
                }
                else
                {
                    return "Победили нолики";
                }
            }

            if (map[0, 2] == map[1, 1] && map[1, 1] == map[2, 0])
            {
                if (map[0, 2] == "X")
                {
                    return "Победили крестики";
                }
                else
                {
                    return "Победили нолики";
                }
            }
            return "";
        }
    }
}