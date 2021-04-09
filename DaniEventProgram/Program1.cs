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

        static int[] GetDigits(int num)
        {
            if (num == 0)
            {
                return new int[] { 0 };
            }
            List<int> listOfInts = new List<int>();
            while (num > 0)
            {
                listOfInts.Add(num % 10);
                num = num / 10;
            }
            listOfInts.Reverse();
            return listOfInts.ToArray();
        }
    }
}
