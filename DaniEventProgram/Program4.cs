﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading;

namespace DaniEventProgram
{
    static class Program4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ready");
            Thread.CurrentThread.Priority = ThreadPriority.Highest;
            while (true)
            {
                string input1 = Console.ReadLine();
                if (input1.Equals("exit"))
                {
                    break;
                }
                string input2 = Console.ReadLine();
                Console.WriteLine(Pow(int.Parse(input1), int.Parse(input2)));
            }
        }

        /// <summary>
        /// Elevates a number to a power
        /// </summary>
        /// <param name="num">The input number</param>
        /// <param name="exp">The power</param>
        /// <returns>The output duh</returns>
        public static int Pow(int num, int exp)
        {
            int result = 1;
            while (exp > 0)
            {
                if ((exp & 1) != 0)
                {
                    result *= num;
                }
                exp >>= 1;
                num *= num;
            }
            return result;
        }
    }
}