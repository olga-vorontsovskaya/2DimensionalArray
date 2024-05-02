using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[,] arr1 =
            {
                {3, 4, 7, 9},
                {5, 7, 12, 24},
                {3, 8, 14, 18}

            };

            
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int g = 0; g < arr1.GetLength(1); g++)
                {
                    Console.Write(arr1[i, g] + "\t");
                }
                Console.WriteLine();
            }



        }
    }
}
