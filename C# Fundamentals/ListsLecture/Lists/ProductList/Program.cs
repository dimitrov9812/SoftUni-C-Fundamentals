﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductList
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            for (int i = 0; i < n; i++)
            {
                products.Add(Console.ReadLine());
            }
            products.Sort();
            for (int i =0; i < products.Count; i++)
            {
                Console.WriteLine($"{i+1}.{products[i]}");
            }

        }
    }
}
