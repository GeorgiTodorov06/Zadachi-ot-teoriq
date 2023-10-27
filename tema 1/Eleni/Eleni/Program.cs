using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int kgFood = int.Parse(Console.ReadLine());
            double dailyFoodFirst = double.Parse(Console.ReadLine());
            double dailyFoodSecond = double.Parse(Console.ReadLine());
            double dailyFoodThird = double.Parse(Console.ReadLine());
            if (dailyFoodFirst < 0 && dailyFoodFirst >100 && dailyFoodSecond < 0 && dailyFoodSecond > 100 && dailyFoodThird < 0 && dailyFoodThird > 100)
            {
                Console.WriteLine("Invalid numbers");
            }
            else
            {
                double foodNeeded = days * dailyFoodFirst
                                + days * dailyFoodSecond
                                + days * dailyFoodThird;

                if (kgFood >= foodNeeded)
                {
                    Console.WriteLine($"{Math.Floor(kgFood - foodNeeded)} kilos of food left.");
                }
                else
                {
                    Console.WriteLine($"{Math.Ceiling(foodNeeded - kgFood)} more kilos of food are needed.");
                }
            }
            Console.ReadKey();
        }
            
    }
}
