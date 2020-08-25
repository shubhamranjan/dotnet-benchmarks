using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

using BenchmarkDotNet.Attributes;

namespace dotnet_benchmarks
{
    public class HashSetBenchmarks
    {
        private HashSet<string> _source;

        private HashSet<string> _sourceClone;

        private HashSet<string> _hashsetS;

        private Dictionary<string, string>.KeyCollection _dictionaryKeyCollection;

        private List<string> _list;

        [GlobalSetup]
        public void HashSetBenchmarksSetup()
        {
            _source = new HashSet<string>();
            _hashsetS = new HashSet<string>();
            _list = new List<string>();

            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            for (int i = 0; i < 100000; i++)
            {
                string randomString = Util.RandomStringRandomLength();

                _source.Add(randomString);
                _hashsetS.Add(randomString);
                _list.Add(randomString);
                keyValuePairs.Add(randomString, randomString);
            }

            for (int i = 0; i < 100000; i++)
            {
                string randomString = Util.RandomStringRandomLength();

                _hashsetS.Add(randomString);
                _list.Add(randomString);
                keyValuePairs.Add(randomString, randomString);
            }

            _dictionaryKeyCollection = keyValuePairs.Keys;
            _sourceClone = new HashSet<string>(_source);

            FileVersionInfo coreFxAssemblyInfo = FileVersionInfo.GetVersionInfo(typeof(HashSet<string>).GetTypeInfo().Assembly.Location);
            FileVersionInfo coreClrAssemblyInfo = FileVersionInfo.GetVersionInfo(typeof(object).GetTypeInfo().Assembly.Location);

            Console.WriteLine($"// CoreFx version: {coreFxAssemblyInfo.FileVersion}, location {typeof(HashSet<string>).GetTypeInfo().Assembly.Location}, product version {coreFxAssemblyInfo.ProductVersion}");
            Console.WriteLine($"// CoreClr version {coreClrAssemblyInfo.FileVersion}, location {typeof(object).GetTypeInfo().Assembly.Location}, product version {coreClrAssemblyInfo.ProductVersion}");
        }
  
        [IterationSetup]
        public void BeforeEveryBenchmarkRun()
        {
            _sourceClone = new HashSet<string>(_source);
        }

        [Benchmark]
        public void IntersectWithHashSet()
        {
            _sourceClone.IntersectWith(_hashsetS);
        }

        [Benchmark]
        public void IntersectWithDictionaryKeyCollection()
        {
            _sourceClone.IntersectWith(_dictionaryKeyCollection);
        }

        [Benchmark]
        public void IntersectWithList()
        {
            _sourceClone.IntersectWith(_list);
        }
    }
}
