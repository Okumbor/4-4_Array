using System;
using System.Collections.Generic;

namespace _4_4ARRAY_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix1 = new int[4, 4] { { 4, 3, 5, 2 }, { 4, 3, 7, 1 }, { 7, 3, 8, 6 }, { 2, 1, 5, 3 } };
            var matrix2 = new int[4, 4] { { 2, 1, 5, 3 }, { 7, 3, 8, 6 }, { 4, 3, 5, 2 }, { 4, 3, 7, 1 } };
            var singleMatrix1 = new List<int>();
            var singleMatrix2 = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    singleMatrix1.Add((matrix1[i, k]));
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    singleMatrix2.Add((matrix2[i, k]));
                }
            }
            var counter = 0;
            var result = new int[16];
            var SingleMatrix1Array = singleMatrix1.ToArray();
            var SingleMatrix2Array = singleMatrix2.ToArray();

            while (counter < 16)
            {
                result[counter] = SingleMatrix1Array[counter] + SingleMatrix2Array[counter];
                counter++;
            }
            foreach (var item in result)
            {
                Console.Write("The Addition of Each Array: ");
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
