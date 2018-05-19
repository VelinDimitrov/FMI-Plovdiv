using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT
{
    class Program
    {

        static bool CanPlace(bool[,] map, int row, int col)
        {
            //top-left-corner
            for (int i = row, j = col; i >= 0 && j >= 0; i--, j--)
            {
                if (map[i, j] == true)
                {
                    return false;
                }
            }
            //bottom-left-corner
            for (int i = row, j = col; i < map.GetLength(0) && j >= 0; i++, j--)
            {
                if (map[i, j] == true)
                {
                    return false;
                }
            }
            //row
            for (int i = 0; i < col; i++)
            {
                if (map[row, i] == true)
                {
                    return false;
                }
            }

            return true;
        }

        static bool Solve(bool[,] map, int col)
        {
            if (col >= map.GetLength(0))
            {
                return true;
            }

            for (int i = 0; i < map.GetLength(0); i++)
            {
                if (CanPlace(map, i, col))
                {
                    map[i, col] = true;
                    Solve(map, col + 1);

                    map[i, col] = false;
                }
            }

            return false;
        }

        static void Print(bool[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < map.GetLength(0); j++)
                {
                    if (map[i, j])
                    {
                        Console.Write("Q\t");
                    }
                    else
                    {
                        Console.Write("O\t");
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            bool[,] map = new bool[4, 4];
            if (Solve(map, 0))
            {
                Print(map);
            }
            Console.ReadLine();
        }
    }
}