using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC5
{
    internal class ArraysAndLoops
    {
        static void Main(string[] args)
        {

            var numbers = new int[9] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            foreach (int i in numbers)
                Console.WriteLine(i);
        }
    }
}
