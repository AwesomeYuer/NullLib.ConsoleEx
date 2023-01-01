// See https://aka.ms/new-console-template for more information
using NullLib.ConsoleEx;
var s = "🌍💩AwesomeYuer 于斯人也 한국어 ことに доступны ㊚㊛囍♀♂♀☿♁⚢⚣⚤⚥⚦⚧⚨ ";
Console.WriteLine(s);
Console.WriteLine();
Console.WriteLine($@"""{s}"".{nameof(s.Length)} = {s.Length}");

var length = s
            .Select(
                    (x) =>
                    {
                        var r = ConsoleText.CalcCharLength(x);
                        Console.WriteLine($"{x}: {r}");
                        return r;
                    })
            .Sum();
Console.WriteLine();
Console.WriteLine($@"""{s}"".SumCalcCharLength = {length}");
Console.WriteLine($@"""{s}"".{ConsoleText.CalcStringLength} = {ConsoleText.CalcStringLength(s)}");