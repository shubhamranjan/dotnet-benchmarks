using System;
using System.Linq;

namespace dotnet_benchmarks
{
    internal static class Util
    {
        private static readonly Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string RandomStringRandomLength()
        {
            return RandomString(random.Next(5, 10000)) + "\n";
        }
    }
}
