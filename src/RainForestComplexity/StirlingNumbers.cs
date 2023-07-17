namespace RainForestComplexity;

// TODO: Use BigInteger
// TODO: Better naming
public static class StirlingNumbers
{
    // See: https://en.wikipedia.org/wiki/Stirling_numbers_of_the_second_kind#Recurrence_relation
    public static ulong SecondKindNaive(uint n, uint k)
    {
        // TODO: Check initial conditions on n / k
        if (n == k) return 1;
        if (n == 0 || k == 0) return 0;
        return k * SecondKindNaive(n - 1, k) + SecondKindNaive(n - 1, k - 1);
    }
    
    private record SecondKindKey(uint N, uint K);
    
    private static readonly IDictionary<SecondKindKey, ulong> SecondKindCache = new Dictionary<SecondKindKey, ulong>();

    public static ulong SecondKindWithCaching(uint n, uint k)
    {
        if (n == k) return 1;
        if (n == 0 || k == 0) return 0;
        
        if (SecondKindCache.TryGetValue(new(n, k), out var cachedValue))
        {
            return cachedValue;
        }
        
        var result = k * SecondKindWithCaching(n - 1, k) + SecondKindWithCaching(n - 1, k - 1);
        SecondKindCache[new(n, k)] = result;
        return result;
    }
}
