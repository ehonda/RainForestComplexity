using System.Globalization;
using RainForestComplexity;

const int r = 100;
const int d = 100;
const int m = 1;

var outerLoop = Complexity.OuterLoop(r, d);
var outerLoopNumberString = outerLoop.ToString("N0", CultureInfo.InvariantCulture);
var outerLoopExponentialString = outerLoop.ToString("E2", CultureInfo.InvariantCulture);

var innerLoop = Complexity.InnerLoop(r, d, m);
var innerLoopNumberString = innerLoop.ToString("N0", CultureInfo.InvariantCulture);
var innerLoopExponentialString = innerLoop.ToString("E2", CultureInfo.InvariantCulture);

var outerLoopBigInteger = Complexity.OuterLoopBigInteger(r, d);
var outerLoopBigIntegerNumberString = outerLoopBigInteger.ToString("N0", CultureInfo.InvariantCulture);
var outerLoopBigIntegerExponentialString = outerLoopBigInteger.ToString("E2", CultureInfo.InvariantCulture);

var innerLoopBigInteger = Complexity.InnerLoopBigInteger(r, d, m);
var innerLoopBigIntegerNumberString = innerLoopBigInteger.ToString("N0", CultureInfo.InvariantCulture);
var innerLoopBigIntegerExponentialString = innerLoopBigInteger.ToString("E2", CultureInfo.InvariantCulture);

var ulongMax = ulong.MaxValue;
var ulongMaxString = ulongMax.ToString("N0", CultureInfo.InvariantCulture);
var ulongMaxExponentialString = ulongMax.ToString("E2", CultureInfo.InvariantCulture);

Console.WriteLine($"r = {r}, d = {d}, m = {m}");
Console.WriteLine($"{nameof(ulongMax)} = {ulongMaxString} = {ulongMaxExponentialString}");

Console.WriteLine();
Console.WriteLine($"{nameof(Complexity.OuterLoop)} = {outerLoopNumberString} = {outerLoopExponentialString}");
Console.WriteLine($"{nameof(Complexity.InnerLoop)} = {innerLoopNumberString} = {innerLoopExponentialString}");

Console.WriteLine();
Console.WriteLine($"{nameof(Complexity.OuterLoopBigInteger)} = {outerLoopBigIntegerNumberString} = {outerLoopBigIntegerExponentialString}");
Console.WriteLine($"{nameof(Complexity.InnerLoopBigInteger)} = {innerLoopBigIntegerNumberString} = {innerLoopBigIntegerExponentialString}");
