using System.Numerics;
using JetBrains.Annotations;

namespace RainForestComplexity;

[PublicAPI]
public static class Functions
{
    public static BigInteger Bell(BigInteger n)
    {
        if (n < 0) throw new ArgumentOutOfRangeException(nameof(n), $"{nameof(n)} must be non-negative");
        
        BigInteger result = 0;
        for (BigInteger k = 0; k <= n; k++)
        {
            result += StirlingSecondKindUnchecked(n, k);
        }
        
        return result;
    }
    
    public static BigInteger StirlingSecondKind(BigInteger n, BigInteger k)
    {
        if (n < 0) throw new ArgumentOutOfRangeException(nameof(n), $"{nameof(n)} must be non-negative");
        if (k < 0) throw new ArgumentOutOfRangeException(nameof(k), $"{nameof(k)} must be non-negative");
        if (k > n) throw new ArgumentOutOfRangeException(
            nameof(k), $"{nameof(k)} must be less than or equal to {nameof(n)}");
        
        return StirlingSecondKindUnchecked(n, k);
    }
    
    private static readonly IDictionary<(BigInteger n, BigInteger k), BigInteger> Cache
        = new Dictionary<(BigInteger n, BigInteger k), BigInteger>();

    private static BigInteger StirlingSecondKindUnchecked(BigInteger n, BigInteger k)
    {
        if (n == k) return 1;
        if (n == 0 || k == 0) return 0;
        
        if (Cache.TryGetValue((n, k), out var cachedValue))
        {
            return cachedValue;
        }
        
        var result = k * StirlingSecondKindUnchecked(n - 1, k) + StirlingSecondKindUnchecked(n - 1, k - 1);
        Cache[(n, k)] = result;
        return result;
    }
}
