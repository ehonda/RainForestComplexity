namespace RainForestComplexity;

public static class BellNumbers
{
    public static ulong Get(uint n)
    {
        ulong result = 0;
        for (uint k = 0; k <= n; k++)
        {
            result += StirlingNumbers.SecondKindNaive(n, k);
        }

        return result;
    }
}
