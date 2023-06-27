using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _06272023___Lecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter value " + (i + 1) + ": ");
                array[i] = int.Parse(Console.ReadLine());
            }

            // firstQuestion(array);
            // secondQuestion(array);
            // thirdQuestion(array);

            int[,] _samplee2Darray =
            {
                { 5, 6, 9},
                { 1, 2, 3},
                { 7, 2, 6}
            };
            // forthQuestion(_samplee2Darray);

            fifthQuestion();
        }

        static void firstQuestion(int[] _arr)
        {
            // Create a Console application which can get the scalar / linear summation of an array with 10 elements.Ask the user to enter values for the array.

            int sum = 0;
            foreach (int num in _arr)
            {
                sum += num;
            }
            int scalarSum = sum;

            sum = 0;
            for (int i = 0; i <_arr.Length; i++)
            {
                sum += _arr[i] * (i + 1);
            }
            int linearSum = sum;

            Console.WriteLine("Scalar Sum: " + scalarSum);
            Console.WriteLine("Linear Sum: " + linearSum);
        }

        static void secondQuestion(int[] _arr)
        {
            // Create a C# program that can find the minimum and maximum from a given Single Dimenional Array.

            int min = _arr[0];
            int max = 0;
            for (int i = 0; i < _arr.Length; i++)
            {
                if (min > _arr[i])
                {
                    min = _arr[i];
                }

                if (max < _arr[i])
                {
                    max = _arr[i];
                }
            }

            Console.WriteLine($"Max: {max}\nMin: {min}");
        }

        static void thirdQuestion(int[] _arr)
        {
            // Create a C# program that can sort a Single Dimentional Array according to ascending and descending order.


            Console.WriteLine("Original Array:");
            PrintArray(_arr);

            Console.WriteLine("\nArray Sorted in Ascending Order:");
            Array.Sort(_arr);
            int[] ascendingArray = _arr;
            PrintArray(ascendingArray);

            Console.WriteLine("\nArray Sorted in Descending Order:");
            Array.Sort(_arr);
            Array.Reverse(_arr);
            int[] descendingArray = _arr;
            PrintArray(descendingArray);

            void PrintArray(int[] array)
            {
                foreach (int num in array)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }

        }

        static void forthQuestion(int[,] _arr)
        {
            // Create a C# program to find the minimum and maximum values from a 2D array

            int min = _arr[0,0];
            int max = 0;
            for (int x = 0; x < _arr.GetLength(0); x++)
            {
                for (int y = 0; y < _arr.GetLength(1); y++)
                {
                    if (min > _arr[x,y])
                    {
                        min = _arr[x, y];
                    }

                    if (max < _arr[x, y])
                    {
                        max = _arr[x, y];
                    }
                }
            }
            Console.WriteLine($"Max: {max}\nMin: {min}");

        }

        static void fifthQuestion()
        {
            int[,] matrix1 = {
                { 1, 2 },
                { 3, 4 }
            };

            int[,] matrix2 = {
                { 5, 6 },
                { 7, 8 }
            };

            int[,] result = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] = 0;

                    for (int k = 0; k < 2; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            void PrintMatrix(int[,] matrix)
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Matrix 1:");
            PrintMatrix(matrix1);

            Console.WriteLine("\nMatrix 2:");
            PrintMatrix(matrix2);

            Console.WriteLine("\nMatrix Multiplication Result:");
            PrintMatrix(result);
            
        }


    }
}
