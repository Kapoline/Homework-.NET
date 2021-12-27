``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1415 (20H2/October2020Update)
AMD Ryzen 5 3500U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.404
  [Host]     : .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
  DefaultJob : .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT


```
|  Method |      Mean |    Error |    StdDev |    Median |      Min |       Max |
|-------- |----------:|---------:|----------:|----------:|---------:|----------:|
|  PlusCs |  76.02 μs | 1.652 μs |  4.439 μs |  75.30 μs | 66.80 μs |  90.07 μs |
|  PlusFs |  92.32 μs | 8.377 μs | 24.570 μs |  79.88 μs | 67.73 μs | 149.07 μs |
| MinusCs |  75.78 μs | 1.701 μs |  4.853 μs |  75.18 μs | 66.59 μs |  89.29 μs |
| MinusFs | 103.62 μs | 7.130 μs | 20.912 μs | 106.34 μs | 66.81 μs | 153.09 μs |
