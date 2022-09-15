using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many seconds do you have available? ");
            long userInput = int.Parse(Console.ReadLine());
            long years = userInput / 365 / 24 / 60 / 60;
            long userInputLeft = userInput % (365 * 24 * 60 * 60);
            long days = userInputLeft / 24 / 60 / 60;
            userInputLeft = userInputLeft % (24 * 60 * 60);
            long hours = userInputLeft / 60 / 60;
            userInputLeft = userInputLeft % (60 * 60);
            long minutes = userInputLeft / 60;
            long seconds = userInputLeft % 60;
            Console.WriteLine(years);
            Console.WriteLine(days);
            Console.WriteLine(hours);
            Console.WriteLine(minutes);
            Console.WriteLine(seconds);
        }
    }
}
