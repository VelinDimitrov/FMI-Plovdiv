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
            int positionY = size / 2; 
            int positionX = size/2;

            int direction = 2; 
            int stepsCount = 1; // total steps in current direction
            int stepPosition = 0; 
            int stepChange = 0;

            for (int fillingNum = 0; fillingNum < size * size; fillingNum++)
            {               
                matrix[positionX, positionY] = fillingNum;
                // Check step changes
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
                    // down
                    case 0:
                        positionX++;
                        break;
                        //left
                    case 1:
                        positionY--;
                        break;
                        //up
                    case 2:
                        positionX--;
                        break;
                        //right
                    case 3:
                        positionY++;
                        break;
                }
            }
        }

       
    }
}
