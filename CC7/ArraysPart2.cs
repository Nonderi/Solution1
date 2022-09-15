using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC7
{
    internal class ArraysPart2
    {
        static void Main(string[] args)
        {
            int size = 10;
            int[,] array2D = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    array2D[i, j] = (i + 1) * (j + 1);
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    var item = array2D[i, j].ToString().PadLeft(4);
                    Console.Write(item);
                }
                Console.Write("\n");
            }
        }
    }
}
