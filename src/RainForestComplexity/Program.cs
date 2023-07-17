using System.Globalization;
using RainForestComplexity;

const int r = 16;
const int d = 16;
const int m = 1;

var innerLoop = Complexity.InnerLoop(r, d, m);
var innerLoopNumberString = innerLoop.ToString("N0", CultureInfo.InvariantCulture);
var innerLoopExponentialString = innerLoop.ToString("E2", CultureInfo.InvariantCulture);

var outerLoop = Complexity.OuterLoop(r, d);
var outerLoopNumberString = outerLoop.ToString("N0", CultureInfo.InvariantCulture);
var outerLoopExponentialString = outerLoop.ToString("E2", CultureInfo.InvariantCulture);

var ulongMax = ulong.MaxValue;
var ulongMaxString = ulongMax.ToString("N0", CultureInfo.InvariantCulture);
var ulongMaxExponentialString = ulongMax.ToString("E2", CultureInfo.InvariantCulture);

Console.WriteLine($"r = {r}, d = {d}, m = {m}");
Console.WriteLine($"{nameof(ulongMax)} = {ulongMaxString} = {ulongMaxExponentialString}");
Console.WriteLine($"{nameof(Complexity.InnerLoop)} = {innerLoopNumberString} = {innerLoopExponentialString}");
Console.WriteLine($"{nameof(Complexity.OuterLoop)} = {outerLoopNumberString} = {outerLoopExponentialString}");
