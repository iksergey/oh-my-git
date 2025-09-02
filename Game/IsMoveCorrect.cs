using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _named_
{
    public static class IsMoveCorrect
    {
        public static bool Correct(string[,] map, int answer)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Convert.ToString(map[i, j]) == Convert.ToString(answer))
                    {
                        return true;
                    }    
                }
            }
            return false;
        }
    }
}
