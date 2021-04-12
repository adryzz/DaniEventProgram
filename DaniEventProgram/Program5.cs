using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading;

namespace DaniEventProgram
{
    static class Program5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ready");
            //Thread.CurrentThread.Priority = ThreadPriority.Highest;
            while (true)
            {
                string input1 = Console.ReadLine();
                if (!char.IsDigit(input1[0]))
                {
                    break;
                }
                string input2 = Console.ReadLine();
                Console.WriteLine(SingleThreadedPow.Pow(long.Parse(input1), long.Parse(input2)));
            }
        }
    }
}