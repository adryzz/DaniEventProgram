using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading;

namespace DaniEventProgram
{
    class Program1
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
                Console.WriteLine(IsNarcisistic(int.Parse(input)));
            }
        }
        /// <summary>
        /// Returns true if a number is narcisistic
        /// </summary>
        /// <param name="number">The input number</param>
        /// <returns>Wheter or not a number is narcisistic</returns>
        public static bool IsNarcisistic(int number)
        {
            // count the number of digits
            int l = GetDigit(number);
            int dup = number;
            int sum = 0;

            // calculates the sum of
            //digits raised to power
            while (dup > 0)
            {
                sum += Pow(dup % 10, l);
                dup /= 10;
            }

            return (number == sum);
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

        /// <summary>
        /// Returns the number of digits a number is composed of.
        /// It's super fast, almost like log() but on steroids
        /// </summary>
        /// <param name="num">The input number</param>
        /// <returns></returns>
        static int GetDigit(int n)
        {
            if (n < 100000)
            {
                // 5 or less
                if (n < 100)
                {
                    // 1 or 2
                    if (n < 10)
                        return 1;
                    else
                        return 2;
                }
                else
                {
                    // 3 or 4 or 5
                    if (n < 1000)
                        return 3;
                    else
                    {
                        // 4 or 5
                        if (n < 10000)
                            return 4;
                        else
                            return 5;
                    }
                }
            }
            else
            {
                // 6 or more
                if (n < 10000000)
                {
                    // 6 or 7
                    if (n < 1000000)
                        return 6;
                    else
                        return 7;
                }
                else
                {
                    // 8 to 10
                    if (n < 100000000)
                        return 8;
                    else
                    {
                        // 9 or 10
                        if (n < 1000000000)
                            return 9;
                        else
                            return 10;
                    }
                }
            }
        }
    }
}
