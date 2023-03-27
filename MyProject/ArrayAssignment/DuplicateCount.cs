﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ArrayAssignment
{
    internal class DuplicateCount  //WAP to find and count total number of duplicate elements in an array
    {
        public static void Main()
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            var dict = new Dictionary<int, int>();
            foreach (var value in array)
            {
                if (dict.ContainsKey(value)) dict[value]++;
                else dict[value] = 1;
            }
            foreach (var pair in dict)
                Console.WriteLine("Value {0} occurred {1} times", pair.Key, pair.Value);

            Console.ReadKey();
        }
    }
}
