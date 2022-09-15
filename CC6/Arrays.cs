using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC6
{
    internal class Arrays
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 1, 4, 5, 7, 20000, -511, 100, -200, 400 };
            int sum = 0;
            foreach(int value in input)
                sum+=value;
            Console.WriteLine(sum);
        }
    }
}
