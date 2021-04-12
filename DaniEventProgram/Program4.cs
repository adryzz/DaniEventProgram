using System;
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
                if (!char.IsDigit(input1[0]))
                {
                    break;
                }
                string input2 = Console.ReadLine();
                Console.WriteLine(Pow(long.Parse(input1), long.Parse(input2)));
            }
        }

        /// <summary>
        /// Elevates a number to a power
        /// </summary>
        /// <param name="a">The input number</param>
        /// <param name="b">The power</param>
        /// <returns>The output duh</returns>
        public static long Pow(long a, long b)
        {
            long re = 1;
            while (b > 0)
            {
                if ((b & 1) == 1)
                {
                    re *= a;
                }
                b >>= 1;
                a *= a;
            }
            return re;
        }
    }
}