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

        public static string GetString(int[] nums)
        {
            string result = "";
            for(int i = 0; i < nums.Length; i++)
            {
                result += nums[i] + " ";
            }
            return result;
        }

        public static int[] GetPrimes(int v)
        {
            List<int> primes = new List<int>();
            int number = v;
            for(int div = 2; div <= Math.Sqrt(v); div++)
            {
                while (number % div == 0)
                {
                    primes.Add(div);
                    number = number / div;
                }
            }
            if (primes.Count == 0)
            {
                primes.Add(v);
            }
            return primes.ToArray();
        }
    }
}
