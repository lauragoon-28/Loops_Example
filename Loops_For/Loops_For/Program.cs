﻿using System;

namespace Loops_For
{
    class Program
    {
        static void Main(string[] args)
        {
            //Count all the way up to 100
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine($"{i}");
            }

            for (int i = 3; i < 1001; i +=3)
            {
                //if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            for (int i = 10; i >= 0; i--)
            {
                if (i == 0)
                {
                    Console.WriteLine("Blast off");
                }
                else
                {
                 Console.WriteLine(i);
                }
            }


        }
    }
}
