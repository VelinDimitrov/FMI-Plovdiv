using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    class Program
    {
        public static void BubbleSort(int[] array) {
            for (int i = 0; i < array.Length; i++)
            {
                for (int k = 0; k < array.Length - 1; k++)
                {
                    if (array[k] < array[k + 1])
                    {
                        int tmp = array[k];
                        array[k] = array[k + 1];
                        array[k + 1] = tmp;
                    }
                }
            }
        }
        public static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int k = i; k < array.Length; k++)
                {
                    if (array[i]<array[k])
                    {
                        int tmp = array[k];
                        array[k] = array[k + 1];
                        array[k + 1] = tmp;
                    }
                }
            }
        }
        public static void QuickSort(int[] array,int left ,int right ) {
            int middleElement = array[(left + right) / 2];
            int i = left;
            int j = right;
            while (i<=j)
            {
                while (array[i]<middleElement)
                {
                    i++;
                }

                while (array[j]>middleElement)
                {
                    j--;
                }

                if (i<=j)
                {
                    int tmp = array[i];
                    array[i] = array[j];
                    array[j] = tmp;
                    i++;
                    j--;
                }

            }
            if (i<right)
            {
                QuickSort(array, i, right);
            }

            if (j>left)
            {
                QuickSort(array, left,j);
            }
        }
        static void Main(string[] args)
        {
            var watch = new Stopwatch();
            int[] testArray = new int[50000];
            var r = new Random();
            for (int i = 0; i < testArray.Length; i++)
            {
                testArray[i] = r.Next(1, 100);
            }
           
            
            watch.Start();
            QuickSort(testArray, 0, testArray.Length-1);
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            watch.Reset();
            

            watch.Start();
            BubbleSort(testArray);
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            watch.Reset();
            

            watch.Start();
            SelectionSort(testArray);
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            watch.Reset();

           
        }
    }
}
