using System.Globalization;
using RainForestComplexity;

const int r = 8;
const int d = 8;
const int m = 1;
var complexity = Complexity.InnerCalls(r, d, m);
var numberString = complexity.ToString("N0", CultureInfo.InvariantCulture);
var exponentString = complexity.ToString("E2", CultureInfo.InvariantCulture);

Console.WriteLine($"r = {r}, d = {d}, m = {m}");
Console.WriteLine($"InnerCalls = {numberString} = {exponentString}");
