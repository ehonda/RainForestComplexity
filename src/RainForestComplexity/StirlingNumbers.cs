namespace RainForestComplexity;

// TODO: Use BigInteger
// TODO: Use caching and benchmark
// TODO: Better naming
public static class StirlingNumbers
{
    // See: https://en.wikipedia.org/wiki/Stirling_numbers_of_the_second_kind#Recurrence_relation
    public static ulong SecondKind(uint n, uint k)
    {
        // TODO: Check initial conditions on n / k
        if (n == k) return 1;
        if (n == 0 || k == 0) return 0;
        return k * SecondKind(n - 1, k) + SecondKind(n - 1, k - 1);
    }
}
