﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delenie_bez_ostatuk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int d2 = 0;
            int d3 = 0;
            int d5 = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    d2++;
                    if (number % 3 == 0)
                    {
                        d3++;
                    }
                    if (number % 5 == 0)
                    {
                        d5++;
                    }

                }
                else if (number % 3 == 0)
                {
                    d3++;
                    if (number % 2 == 0)
                    {
                        d2++;
                    }
                    if (number % 5 == 0)
                    {
                        d5++;
                    }
                }
                else if (number % 5 == 0)
                {
                    d5++;
                    if (number % 3 == 0)
                    {
                        d3++;
                    }
                    if (number % 2 == 0)
                    {
                        d2++;
                    }
                }
            }
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d5);
            Console.ReadKey();
        }
    }
}
