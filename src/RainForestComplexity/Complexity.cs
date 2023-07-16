namespace RainForestComplexity;

public static class Complexity
{
    public static ulong InnerCalls(uint r, uint d, uint m)
    {
        ulong result = 0;
        for (uint k = 0; k <= Math.Min(r, d); k++)
        {
            result += SizeK(r, d, k, m);
        }

        return result;
    }

    private static ulong SizeK(uint r, uint d, uint k, uint m)
        => StirlingNumbers.SecondKind(r, k) * StirlingNumbers.SecondKind(d, k) * Factorial(k) * m;
    
    private static ulong Factorial(uint n)
    {
        ulong result = 1;
        for (uint i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}
