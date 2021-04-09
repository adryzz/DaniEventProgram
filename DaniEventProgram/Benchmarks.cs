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
        public void Task1()
        {
            Program1.IsNarcisistic(random.Next());
        }

        [Benchmark]
        public void Task2()
        {
            Program2.GetPrimes(random.Next());
        }

        [Benchmark]
        public void Task3()
        {
            Program3.IsPrime(random.Next());
        }

        [Benchmark]
        public void Task4()
        {
            Program4.Pow(random.Next(), random.Next(0, 10));
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