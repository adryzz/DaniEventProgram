using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading;

namespace DaniEventProgram
{
    static class Program2
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
                Console.WriteLine(GetString(GetPrimes(long.Parse(input))));
            }
        }

        /// <summary>
        /// Formats an long array to be prlonged
        /// </summary>
        /// <param name="nums">The long array</param>
        /// <returns></returns>
        public static string GetString(long[] nums)
        {
            string result = "";
            for(long i = 0; i < nums.Length; i++)
            {
                result += nums[i] + " ";
            }
            return result;
        }

        /// <summary>
        /// Returns all the prime factors of a given input number
        /// </summary>
        /// <param name="v">The given input number</param>
        /// <returns></returns>
        public static long[] GetPrimes(long v)
        {
            List<long> primes = new List<long>();
            long number = v;
            for(long div = 2; (div*div) <= v+div; div++)
            {
                //if the remainder of the division of the number and our divider is 0, it's divisible by it.
                //and so, since the div number starts at 0 and goes up, we can ensure that it is prime
                while (number % div == 0)
                {
                    primes.Add(div);
                    number /= div;//this is here since we want to know how many times a prime number divides the input number
                }
            }
            if (primes.Count == 0)//if the primes found are 0, our input is a prime itself. i could speed this up a bit by searching before.
            {
                primes.Add(v);
            }
            return primes.ToArray();
        }
    }
}
