﻿using System;

namespace CracklePop
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(CracklePopHelper.GetNumberOrReplacement(i));
            }

            Console.ReadKey();
        }
    }
}