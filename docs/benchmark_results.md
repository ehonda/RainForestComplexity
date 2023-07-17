# Benchmark results

## Overview

These are some results of benchmarking the calculation of stirling numbers of the second kind with and without
caching.

## Results

### Low values of n

For low values of n, the naive approach is faster, because of the caching overhead.

| Method                               | n | k |      Mean |     Error |    StdDev |
|--------------------------------------|---|---|----------:|----------:|----------:|
| StirlingNumbersSecondKindNaive       | 3 | 1 | 10.631 ns | 0.1065 ns | 0.0944 ns |
| StirlingNumbersSecondKindWithCaching | 3 | 1 | 46.408 ns | 0.2288 ns | 0.2028 ns |
| StirlingNumbersSecondKindNaive       | 3 | 2 |  9.784 ns | 0.0530 ns | 0.0414 ns |
| StirlingNumbersSecondKindWithCaching | 3 | 2 | 44.654 ns | 0.1821 ns | 0.1614 ns |

### High values of n

As expected we see that the caching is far superior to the naive approach for higher values of n, except at the
"trivial" values (`n == k`) if we straight forwardly implement the caching and cache the trivial values as well.

| Method                               | n  | k  |          Mean |      Error |     StdDev | Ratio | RatioSD |
|--------------------------------------|----|----|--------------:|-----------:|-----------:|------:|--------:|
| StirlingNumbersSecondKindNaive       | 10 | 5  | 1,163.7973 ns | 11.5909 ns | 10.8422 ns | 26.10 |    0.32 |
| StirlingNumbersSecondKindWithCaching | 10 | 5  |    44.6248 ns |  0.3225 ns |  0.2859 ns |  1.00 |    0.00 |
|                                      |    |    |               |            |            |       |         |
| StirlingNumbersSecondKindNaive       | 10 | 8  |   196.4778 ns |  0.7773 ns |  0.7271 ns |  4.41 |    0.02 |
| StirlingNumbersSecondKindWithCaching | 10 | 8  |    44.4956 ns |  0.1518 ns |  0.1346 ns |  1.00 |    0.00 |
|                                      |    |    |               |            |            |       |         |
| StirlingNumbersSecondKindNaive       | 10 | 10 |     0.6780 ns |  0.0136 ns |  0.0127 ns |  0.02 |    0.00 |
| StirlingNumbersSecondKindWithCaching | 10 | 10 |    44.3897 ns |  0.2715 ns |  0.2407 ns |  1.00 |    0.00 |

### Worst case for k

The worst case for k seems to be somewhere around `n / 2`, which makes sense because then the n in the term
`k * S(n - 1, k)` "takes longer to catch up" so we have more recursive calls there. This also means that k in the term
`S(n - 1, k - 1)` takes some time to reach 0, which yields some additional recursive calls.

| Method                               | n  | k  |          Mean |      Error |      StdDev | Ratio | RatioSD |
|--------------------------------------|----|----|--------------:|-----------:|------------:|------:|--------:|
| StirlingNumbersSecondKindNaive       | 10 | 0  |     1.3463 ns |  0.0270 ns |   0.0252 ns |  0.03 |    0.00 |
| StirlingNumbersSecondKindWithCaching | 10 | 0  |    44.1404 ns |  0.2538 ns |   0.2374 ns |  1.00 |    0.00 |
|                                      |    |    |               |            |             |       |         |
| StirlingNumbersSecondKindNaive       | 10 | 1  |    44.7811 ns |  0.2599 ns |   0.2304 ns |  1.01 |    0.01 |
| StirlingNumbersSecondKindWithCaching | 10 | 1  |    44.2525 ns |  0.3679 ns |   0.3073 ns |  1.00 |    0.00 |
|                                      |    |    |               |            |             |       |         |
| StirlingNumbersSecondKindNaive       | 10 | 2  |   204.0909 ns |  1.2220 ns |   1.0833 ns |  4.53 |    0.04 |
| StirlingNumbersSecondKindWithCaching | 10 | 2  |    45.0773 ns |  0.2905 ns |   0.2575 ns |  1.00 |    0.00 |
|                                      |    |    |               |            |             |       |         |
| StirlingNumbersSecondKindNaive       | 10 | 3  |   548.8117 ns |  4.6032 ns |   4.0806 ns | 11.96 |    0.07 |
| StirlingNumbersSecondKindWithCaching | 10 | 3  |    45.9004 ns |  0.2820 ns |   0.2355 ns |  1.00 |    0.00 |
|                                      |    |    |               |            |             |       |         |
| StirlingNumbersSecondKindNaive       | 10 | 4  |   957.4000 ns |  9.9639 ns |   8.3203 ns | 21.46 |    0.24 |
| StirlingNumbersSecondKindWithCaching | 10 | 4  |    44.5863 ns |  0.3485 ns |   0.3089 ns |  1.00 |    0.00 |
|                                      |    |    |               |            |             |       |         |
| StirlingNumbersSecondKindNaive       | 10 | 5  | 1,124.2730 ns | 10.6946 ns |   9.4805 ns | 25.53 |    0.24 |
| StirlingNumbersSecondKindWithCaching | 10 | 5  |    44.0403 ns |  0.1897 ns |   0.1681 ns |  1.00 |    0.00 |
|                                      |    |    |               |            |             |       |         |
| StirlingNumbersSecondKindNaive       | 10 | 6  | 1,144.1004 ns | 37.8431 ns | 111.5812 ns | 26.91 |    3.36 |
| StirlingNumbersSecondKindWithCaching | 10 | 6  |    43.9808 ns |  0.3613 ns |   0.3203 ns |  1.00 |    0.00 |
|                                      |    |    |               |            |             |       |         |
| StirlingNumbersSecondKindNaive       | 10 | 7  |   535.8294 ns |  3.7648 ns |   3.3374 ns | 11.12 |    0.08 |
| StirlingNumbersSecondKindWithCaching | 10 | 7  |    48.1840 ns |  0.1982 ns |   0.1757 ns |  1.00 |    0.00 |
|                                      |    |    |               |            |             |       |         |
| StirlingNumbersSecondKindNaive       | 10 | 8  |   195.4669 ns |  0.9669 ns |   0.8074 ns |  4.42 |    0.03 |
| StirlingNumbersSecondKindWithCaching | 10 | 8  |    44.1948 ns |  0.2794 ns |   0.2476 ns |  1.00 |    0.00 |
|                                      |    |    |               |            |             |       |         |
| StirlingNumbersSecondKindNaive       | 10 | 9  |    40.4299 ns |  0.2226 ns |   0.2082 ns |  0.92 |    0.01 |
| StirlingNumbersSecondKindWithCaching | 10 | 9  |    44.1196 ns |  0.3765 ns |   0.3337 ns |  1.00 |    0.00 |
|                                      |    |    |               |            |             |       |         |
| StirlingNumbersSecondKindNaive       | 10 | 10 |     0.7776 ns |  0.0161 ns |   0.0151 ns |  0.02 |    0.00 |
| StirlingNumbersSecondKindWithCaching | 10 | 10 |    44.0987 ns |  0.2569 ns |   0.2403 ns |  1.00 |    0.00 |

### Improved trivial values handling

If we don't cache the trivial values but rather check for them directly, we can be as efficient as the naive version
in those cases, but still have the caching for the other cases.

| Method                               | n  | k  |          Mean |     Error |    StdDev | Ratio | RatioSD |
|--------------------------------------|----|----|--------------:|----------:|----------:|------:|--------:|
| StirlingNumbersSecondKindNaive       | 10 | 0  |     1.3364 ns | 0.0161 ns | 0.0150 ns |  1.35 |    0.02 |
| StirlingNumbersSecondKindWithCaching | 10 | 0  |     0.9920 ns | 0.0079 ns | 0.0074 ns |  1.00 |    0.00 |
|                                      |    |    |               |           |           |       |         |
| StirlingNumbersSecondKindNaive       | 10 | 5  | 1,122.7818 ns | 9.3195 ns | 8.2615 ns | 25.47 |    0.25 |
| StirlingNumbersSecondKindWithCaching | 10 | 5  |    44.0632 ns | 0.3256 ns | 0.3045 ns |  1.00 |    0.00 |
|                                      |    |    |               |           |           |       |         |
| StirlingNumbersSecondKindNaive       | 10 | 8  |   195.8369 ns | 1.3146 ns | 1.2297 ns |  4.52 |    0.05 |
| StirlingNumbersSecondKindWithCaching | 10 | 8  |    43.3580 ns | 0.4129 ns | 0.3862 ns |  1.00 |    0.00 |
|                                      |    |    |               |           |           |       |         |
| StirlingNumbersSecondKindNaive       | 10 | 10 |     0.6506 ns | 0.0213 ns | 0.0199 ns |  0.66 |    0.02 |
| StirlingNumbersSecondKindWithCaching | 10 | 10 |     0.9935 ns | 0.0140 ns | 0.0117 ns |  1.00 |    0.00 |
