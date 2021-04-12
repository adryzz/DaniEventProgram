using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DaniEventProgram
{
    class SingleThreadedPow
    {
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
            if (b % 16 == 0)
            {
                long num = b / 8;
                long value = FallbackPow(a, num);
                value *= value;
                value *= value;
                value *= value;
                value *= value;
                value *= value;
                value *= value;
                value *= value;
                value *= value;
                return value;
            }
            else if (b % 8 == 0)
            {
                long num = b / 8;
                long value = FallbackPow(a, num);
                value *= value;
                value *= value;
                value *= value;
                value *= value;
                return value;
            }
            else if (b % 4 == 0)
            {
                long num = b / 4;
                long value = FallbackPow(a, num);
                value *= value;
                value *= value;
                return value;
            }
            else
            {
                long num = b / 2;
                long value = FallbackPow(a, num);
                return value * value;
            }
        }
    }
}
