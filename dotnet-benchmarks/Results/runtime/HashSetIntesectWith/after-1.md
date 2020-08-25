``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Core i7-6700HQ CPU 2.60GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.100-preview.7.20366.6
  [Host]     : .NET Core 5.0.0 (CoreCLR 42.42.42.42424, CoreFX 5.0.20.36411), X64 RyuJIT
  Job-PNETTD : .NET Core 5.0.0 (CoreCLR 42.42.42.42424, CoreFX 5.0.20.36411), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|                               Method |     Mean |   Error |  StdDev |
|------------------------------------- |---------:|--------:|--------:|
|                 IntersectWithHashSet | 151.3 ms | 2.98 ms | 4.07 ms |
| IntersectWithDictionaryKeyCollection | 150.0 ms | 2.88 ms | 2.55 ms |
|                    IntersectWithList | 299.8 ms | 4.82 ms | 4.03 ms |
