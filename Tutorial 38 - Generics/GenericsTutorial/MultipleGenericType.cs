﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTutorial
{
    internal class MultipleGenericType<TFirst, TSecond>
    {
        public TFirst First { get; set; }

        public TSecond Second { get; set; }

        public MultipleGenericType(TFirst first, TSecond second)
        {
            First = first;
            Second = second;
        }

        public void Display()
        {
            Console.WriteLine($"First : {First}, Second : {Second}");
        }
    }
}
