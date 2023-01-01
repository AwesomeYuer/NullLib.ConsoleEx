using System;
using System.Linq;
using System.Text;
using System.Text.Unicode;
using System.Threading;
using System.Threading.Tasks;
using NullLib.ConsoleEx;

namespace TestConsole
{
    class Program
    {
        static Program()
        {
            ConsoleSc.Prompt = ">>> ";
        }
        static int GetCharLen(char c)
        {
            UnicodeRange combiningHalfMarks = UnicodeRanges.CombiningHalfMarks;
            if (combiningHalfMarks.FirstCodePoint <= c && combiningHalfMarks.Length < c - combiningHalfMarks.FirstCodePoint)
                return 1;
            return 2;
        }
        static int GetStrLen(string str)
        {
            int rst = 0;
            foreach (var c in str)
                rst += GetCharLen(c);
            return rst;
            
        }
        static Task Main(string[] args)
        {



            var s = "🌍💩♂AwesomeYuer 于斯人也 한국어 ことに доступны ㊚㊛囍♀☿♁⚢⚣⚤⚥⚦⚧⚨ ";
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
            Console.WriteLine($@"""{s}"".UnicodeLength = {length}");


            s = "🌍💩";
            Console.WriteLine(s);
            Console.WriteLine($@"""{s}"".{nameof(s.Length)} = {s.Length}");
            Console.WriteLine($@"""{s}"".CalcStringLength = {ConsoleText.CalcStringLength(s)}");







            StringBuilder sb = new StringBuilder();
            while(true)
            {
                ConsoleSc.ReadLine();

                //string instr = Console.ReadLine();
                //Console.WriteLine(ConsoleText.CalcStringLength(instr));
            }

        }
    }
}
