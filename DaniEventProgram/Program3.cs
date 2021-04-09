using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading;

namespace DaniEventProgram
{
    static class Program3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ready");
            Thread.CurrentThread.Priority = ThreadPriority.Highest;
            while (true)
            {
                string input = Console.ReadLine();
                if (!char.IsDigit(input[0]))
                {
                    break;
                }
                Console.WriteLine(IsPrime(int.Parse(input)));
            }
        }

        /// <summary>
        /// Checks if a number is prime
        /// </summary>
        /// <param name="number">The input number</param>
        /// <returns>Wheter or not the input number is prime</returns>
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i*i <= number; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
