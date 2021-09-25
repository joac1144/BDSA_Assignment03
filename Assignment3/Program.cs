using System;
using System.Text.RegularExpressions;

namespace BDSA2021.Assignment03
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = @"This is a test 123 string for £$€€[&¤&&(¤ testing my WordCount method.";
            var list = Regex.Split(str, @"\P{L}+");
            foreach(var s in list) {
                Console.WriteLine(s);
            }
            Console.WriteLine(str.WordCount());

            var str2 = "69 420 !\"#¤%& 1144 11943 =)(/&% 123 ^^^^ ^~~~>>\\`` @£$€€@[&\"/¤/\"&&(/¤\"";
            var list2 = Regex.Split(str2, @"\P{L}+");
            foreach(var s in list2) {
                Console.WriteLine(s);
            }
            Console.WriteLine(str2.WordCount());
        }
    }
}
