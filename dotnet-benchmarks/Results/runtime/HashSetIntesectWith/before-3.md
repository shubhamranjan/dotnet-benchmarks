``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Core i7-6700HQ CPU 2.60GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.100-preview.7.20366.6
  [Host]     : .NET Core 5.0.0 (CoreCLR 42.42.42.42424, CoreFX 5.0.20.36411), X64 RyuJIT
  Job-XCMBEQ : .NET Core 5.0.0 (CoreCLR 42.42.42.42424, CoreFX 5.0.20.36411), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|                               Method |     Mean |   Error |  StdDev |
|------------------------------------- |---------:|--------:|--------:|
|                 IntersectWithHashSet | 149.7 ms | 2.82 ms | 3.24 ms |
| IntersectWithDictionaryKeyCollection | 295.9 ms | 4.96 ms | 3.87 ms |
|                    IntersectWithList | 296.0 ms | 3.02 ms | 2.52 ms |
