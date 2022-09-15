using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC4
{
    internal class Metropolis
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Type in the name of the city: ");
            string name = Console.ReadLine();
            Console.WriteLine("Is it a capital: yes or no?");
            string yesOrNo = Console.ReadLine();
            bool isCapital = yesOrNo.Equals("yes");
            Console.WriteLine("Number of inhabitants?");
            long numInhabitants = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Tax revenue per inhabitant?");
            double taxRevenuePerInhabitant = Convert.ToDouble(Console.ReadLine());
            double taxRevenue = taxRevenuePerInhabitant * numInhabitants;

            if ((isCapital && numInhabitants > 100000) || (numInhabitants > 200000 && taxRevenue > 1000000000))
            {
                Console.WriteLine($"{name} is a metropolis");
            }
            else
            {
                Console.WriteLine($"{name} is not a metropolis");
            }
        }
    }
}
