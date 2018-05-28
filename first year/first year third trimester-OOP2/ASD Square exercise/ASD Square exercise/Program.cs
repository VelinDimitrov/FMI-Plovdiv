using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD_Square_exercise
{
    class Program
    {
        static List<List<Square>> groupedSquares = new List<List<Square>>();
        static void Main(string[] args)
        {
            int numberOfSquares = int.Parse(Console.ReadLine());
            List<Square> squares = new List<Square>();
            for (int i = 0; i < numberOfSquares; i++)
            {
                int[] cordinates = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                squares.Add(new Square(cordinates[0], cordinates[1], cordinates[2], cordinates[3]));
            }
            SortSquares(squares);
            findGroupedSquares(squares);
            double sum=0;
            for (int i = 0; i < groupedSquares.Count; i++)
            {
                sum += CalculateGroupArea(groupedSquares[i]);
                Console.WriteLine($"Area of group {i+1} :{CalculateGroupArea(groupedSquares[i])}");
            }
            Console.WriteLine("Sum of all groups : "+sum);
            Console.WriteLine("Number of Groups : "+groupedSquares.Count);
        }

        private static void SortSquares(List<Square> squares)
        {
            for (int i = 0; i < squares.Count; i++)
            {
                for (int j = i; j < squares.Count; j++)
                {
                    if (squares[i].x2 > squares[j].x2)
                    {
                        Square temp = squares[i];
                        squares[i] = squares[j];
                        squares[j] = temp;
                    }
                }
            }
        }
        private static void findGroupedSquares(List<Square> squares)
        {
            int currentIndex = 0;

            for (int i = 1; i < squares.Count ; i++)
            {
                if (groupedSquares.Count<=currentIndex)
                {
                    groupedSquares.Add(new List<Square>());
                }
                

                bool xCondition = squares[i-1].x2 >= squares[i].x1 + 1 && squares[i-1].y1 >= squares[i].y1 && squares[i-1].y1 <= squares[i].y2;
                bool increasingYCondition = squares[i-1].x2 == squares[i].x1 && squares[i-1].y2 >= squares[i].y1 + 1 && squares[i-1].y2 <= squares[i].y2;
                bool decreasingYCondition = squares[i-1].x2 == squares[i].x1 && squares[i].y2 <= squares[i-1].y2 && squares[i].y2 >= squares[i-1].y1+1;

                if (xCondition || increasingYCondition||decreasingYCondition)
                {                    
                    groupedSquares[currentIndex].Add(squares[i-1]);                   
                   
                }
                else
                {
                    if (i == 1)
                    {
                        groupedSquares[currentIndex].Add(squares[i - 1]);                        
                        continue;
                    }
                    currentIndex++;
                    groupedSquares.Add(new List<Square>());
                    groupedSquares[currentIndex].Add(squares[i-1]);                    
                }

                if (i==squares.Count-1&&(xCondition||decreasingYCondition||increasingYCondition))
                {
                    groupedSquares[currentIndex].Add(squares[i]);
                }               

            }
        }

        public static double CalculateGroupArea(List<Square> group) {
            double sum = 0;
            foreach (var square in group)
            {
                sum += square.CalculateArea();
            }
            return sum;
        }
    }
}
