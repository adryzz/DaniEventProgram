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
                if (input.Equals("exit"))
                {
                    break;
                }
                Console.WriteLine(GetString(GetPrimes(int.Parse(input))));
            }
        }

        /// <summary>
        /// Formats an int array to be printed
        /// </summary>
        /// <param name="nums">The int array</param>
        /// <returns></returns>
        public static string GetString(int[] nums)
        {
            string result = "";
            for(int i = 0; i < nums.Length; i++)
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
        public static int[] GetPrimes(int v)
        {
            List<int> primes = new List<int>();
            int number = v;
            for(int div = 2; div <= Math.Sqrt(v); div++)//since the square root of the number is always bigger than any prime factor of it, we can stop counting there
            {
                //if the remainder of the division of the number and our divider is 0, it's divisible by it.
                //and so, since the div number starts at 0 and goes up, we can ensure that it is prime
                while (number % div == 0)
                {
                    primes.Add(div);
                    number = number / div;//this is here since we want to know how many times a prime number divides the input number
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
