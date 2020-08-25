
using System;
using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;

using BenchmarkDotNet.Running;

namespace dotnet_benchmarks
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            _ = BenchmarkRunner.Run<HashSetBenchmarks>();
        }
    }
}
