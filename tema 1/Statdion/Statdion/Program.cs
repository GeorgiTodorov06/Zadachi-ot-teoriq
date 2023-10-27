using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statdion
{
    internal class Program
    {
        static double GetTotalProfit(int row, int col, double price) //izkarvane na metoda izvun main
        {
            return row * col * price;
        }
        static void Main(string[] args)
        {
            string sector = Console.ReadLine(); //lipsvashta tochka i zapetaq
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            double totalSum = 0; //suzdavane na totalsum

            switch (sector) //dobavqne na sektor
            {
                case "Sector A":
                    totalSum = GetTotalProfit(row, col, 11.60);
                    break; //lipsva break

                case "Sector B":
                    totalSum = GetTotalProfit(row, col, 14.50); //lipsva tochka i zapetaq
                    break;
                case "Sector C":
                    totalSum = GetTotalProfit(row, col, 16.10);
                    break;
                case "Sector D":
                    totalSum = GetTotalProfit(row, col, 8.40);
                    break;                 
            }
            Console.WriteLine($"{sector} profit is {totalSum:f2} lv."); //izkarva se izvun switch-case
            Console.ReadKey();

        }
    }
}
