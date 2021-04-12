using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DaniEventProgram
{
    class MultiThreadedPow
    {
        static long Value;
        static int CompletedThreads;
        public static long Pow(long a, long b)
        {
            if (b < 16)
            {
                return FallbackPow(a, b);
            }
            else if (b % 2 == 0)
            {
                return FastPow(a, b);
            }
            else
            {
                return FastPow(a, b - 1) * a;
            }
        }

        /// <summary>
        /// Elevates a number to a power
        /// </summary>
        /// <param name="a">The input number</param>
        /// <param name="b">The power</param>
        /// <returns>The output duh</returns>
        static long FallbackPow(long a, long b)
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

        static long FastPow(long a, long b)
        {
            Value = 0;
            CompletedThreads = 0;
            int numThreads = 2;
            if (b % 16 == 0)
            {
                return StartThreads(a, b, 16);
            }
            else if (b % 8 == 0)
            {
                return StartThreads(a, b, 8);
            }
            else if (b % 4 == 0)
            {
                return StartThreads(a, b, 4);
            }
            else
            {
                return StartThreads(a, b, 2);
            }
        }

        static long StartThreads(long a, long b, int num)
        {
            for(int i = 0; i < num; i++)
            {
                StartThread(a, b, i);
            }
            while (CompletedThreads != num)
            {

            }
            return Value;
        }

        static void StartThread(long a, long b, int index)
        {
            Thread t = new Thread(new ThreadStart(() => ThreadTask(a, b)));
            t.Name = "Thread " + index;
        }

        static void ThreadTask(long a, long b)
        {
            Value *= FallbackPow(a, b);
            CompletedThreads++;
        }
    }
}
