using System.Numerics;

namespace RainForestComplexity;

public static class Complexity
{
    public static ulong OuterLoop(uint r, uint d)
        => BellNumbers.Get(r) * BellNumbers.Get(d);
    
    public static ulong InnerLoop(uint r, uint d, uint m)
    {
        ulong result = 0;
        for (uint k = 0; k <= Math.Min(r, d); k++)
        {
            result += SizeK(r, d, k, m);
        }

        return result;
    }

    private static ulong SizeK(uint r, uint d, uint k, uint m)
        => StirlingNumbers.SecondKindWithCaching(r, k) * StirlingNumbers.SecondKindWithCaching(d, k) * Factorial(k) * m;
    
    private static ulong Factorial(uint n)
    {
        ulong result = 1;
        for (uint i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
    
    public static BigInteger OuterLoopBigInteger(uint r, uint d)
        => Functions.Bell(r) * Functions.Bell(d);
    
    public static BigInteger InnerLoopBigInteger(uint r, uint d, uint m)
    {
        BigInteger result = 0;
        for (uint k = 0; k <= Math.Min(r, d); k++)
        {
            result += SizeKBigInteger(r, d, k, m);
        }

        return result;
    }
    
    private static BigInteger SizeKBigInteger(uint r, uint d, uint k, uint m)
        => Functions.StirlingSecondKind(r, k) * Functions.StirlingSecondKind(d, k) * FactorialBigInteger(k) * m;
    
    private static BigInteger FactorialBigInteger(BigInteger n)
    {
        BigInteger result = 1;
        for (uint i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}
