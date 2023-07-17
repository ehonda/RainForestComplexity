using BenchmarkDotNet.Attributes;
using RainForestComplexity;

namespace Benchmarks;

public class StirlingNumbersBenchmarks
{
    private const int LowerN = 3;
    private const int CountN = 1;

    // public static IEnumerable<object[]> Parameters() => Enumerable
    //     .Range(LowerN, CountN)
    //     .SelectMany(n => Enumerable
    //         .Range(0, n)
    //         .Select(k => new object[] { n, k }));

    public static IEnumerable<object[]> Parameters() => new[]
    {
        // new object[] { 3, 1 },
        // new object[] { 3, 2 }
        new object[] { 10, 0 },
        new object[] { 10, 5 },
        new object[] { 10, 8 },
        new object[] { 10, 10 },
        // new object[] { 10, 0 },
        // new object[] { 10, 1 },
        // new object[] { 10, 2 },
        // new object[] { 10, 3 },
        // new object[] { 10, 4 },
        // new object[] { 10, 5 },
        // new object[] { 10, 6 },
        // new object[] { 10, 7 },
        // new object[] { 10, 8 },
        // new object[] { 10, 9 },
        // new object[] { 10, 10 },
    };
    
    [Benchmark]
    [ArgumentsSource(nameof(Parameters))]
    public ulong StirlingNumbersSecondKindNaive(uint n, uint k) => StirlingNumbers.SecondKindNaive(n, k);
    
    [Benchmark(Baseline = true)]
    [ArgumentsSource(nameof(Parameters))]
    public ulong StirlingNumbersSecondKindWithCaching(uint n, uint k) => StirlingNumbers.SecondKindWithCaching(n, k);
}
