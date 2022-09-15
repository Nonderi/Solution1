using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC2
{
    internal class Datatypes
    {
        static void Main(string[] args)
        {
            string initials = "N. J.";
            Console.WriteLine("My initials are " + initials);
            float populationFinland = 5531000F;
            Console.WriteLine("The population of Finland is: " + populationFinland / 1000000 + " million");
            float populationEarth = 7753000000F;
            Console.WriteLine("The population on earth is: " + populationEarth / 1000000000 + " billion");
            DayOfWeek wk = DateTime.Today.DayOfWeek;
            Console.WriteLine("Today is: " + wk);
            int courseDurationInWeeks = 2;
            Console.WriteLine("This course takes " + courseDurationInWeeks + " weeks");
            const double Pi = 3.14159265359D;
            Console.WriteLine("The value of Pi is: " + Pi);
        }
    }
}
