﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedINtegers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers.Count == 0)
                {
                    
                    break;
                }
                else if(numbers[i] < 0)
                {
                    numbers.RemoveAt(i);
                    i -= 1;
                }
            }
            
            numbers.Reverse();
            if(numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            
        }
            
            
    }
}
