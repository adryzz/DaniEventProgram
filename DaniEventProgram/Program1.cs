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
                if (input.Equals("exit"))
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
            int[] digits = GetDigits(number);

            int result = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                result += digits[i] * digits[i] * digits[i];//Math.Pow is slow as fuck
            }
            return number == result;
        }

        /// <summary>
        /// Returns all the decimal digits that a number is composed of
        /// </summary>
        /// <param name="num">The input number</param>
        /// <returns>The digits the input number is </returns>
        static int[] GetDigits(int num)
        {
            if (num == 0)//if the number is 0, return an array with only 0
            {
                return new int[] { 0 };
            }
            List<int> listOfInts = new List<int>();
            while (num > 0)//if the number has more digits remaining
            {
                listOfInts.Add(num % 10);//divide by 10 and get the remainder
                num = num / 10;
            }
            listOfInts.Reverse();//reverse the list
            return listOfInts.ToArray();
        }
    }
}
