using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //N%2==1
            int size;
            do
            {
                size = int.Parse(Console.ReadLine());
            } while (size%2==0);

            int[,] matrix = new int[size, size];
            

            fillMatrix(matrix,size);
            printMatrix(matrix);

        }
        static void printMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write(matrix[i,j]+"\t");
                }
                Console.WriteLine();
            }
        }
         
        static void fillMatrix(int[,] matrix,int size)
        {
            int positionX = size / 2; 
            int positionY = size/2;

            int direction = 2; // The initial direction is "up"
            int stepsCount = 1; // Perform 1 step in current direction
            int stepPosition = 0; 
            int stepChange = 0; // Steps count changes after 2 steps

            for (int fillingNum = 0; fillingNum < size * size; fillingNum++)
            {               
                matrix[positionY, positionX] = fillingNum;
                // Check for direction / step changes
                if (stepPosition < stepsCount)
                {
                    stepPosition++;
                }
                else
                {
                    stepPosition = 1;
                    if (stepChange == 1)
                    {
                        stepsCount++;
                    }
                    stepChange = (stepChange + 1) % 2;
                    direction = (direction + 1) % 4;
                }
                // move direction
                switch (direction)
                {
                    // right
                    case 0:
                        positionY++;
                        break;
                        //up
                    case 1:
                        positionX--;
                        break;
                        //left
                    case 2:
                        positionY--;
                        break;
                        //down
                    case 3:
                        positionX++;
                        break;
                }
            }
        }

       
    }
}
