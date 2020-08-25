``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Core i7-6700HQ CPU 2.60GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.100-preview.7.20366.6
  [Host]     : .NET Core 5.0.0 (CoreCLR 42.42.42.42424, CoreFX 5.0.20.36411), X64 RyuJIT
  Job-BLNDKK : .NET Core 5.0.0 (CoreCLR 42.42.42.42424, CoreFX 5.0.20.36411), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|                               Method |     Mean |   Error |  StdDev |
|------------------------------------- |---------:|--------:|--------:|
|                 IntersectWithHashSet | 150.0 ms | 3.00 ms | 4.11 ms |
| IntersectWithDictionaryKeyCollection | 299.4 ms | 5.81 ms | 6.92 ms |
|                    IntersectWithList | 297.7 ms | 5.64 ms | 6.04 ms |
