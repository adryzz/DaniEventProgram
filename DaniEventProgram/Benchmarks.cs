using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace DaniEventProgram.Benchmarks
{
    [MemoryDiagnoser]
    [DisassemblyDiagnoser]
    [ThreadingDiagnoser]
    public class Tasks
    {
        Random random = new Random();

        [Benchmark]
        public void Task4()
        {
            Program4.Pow(100000, 50);
        }

        [Benchmark]
        public void Task5()
        {
            SingleThreadedPow.Pow(100000, 50);
        }
    }

    public static class MyProgram
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<Tasks>();
        }
    }
}