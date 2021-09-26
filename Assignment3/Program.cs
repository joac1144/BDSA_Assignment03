using System;
using System.Linq;
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


            // A method which takes a string and prints the content in reverse order (by character)
            Action<string> reverse = rs => Console.WriteLine(string.Join("", rs.Reverse()));
            reverse("Reverse this string");

            // A method which takes two decimals and returns the product
            Func<double, double, double> multiply = (d1, d2) => d1 * d2;
            Console.WriteLine(multiply(5.7, 19.9));

            // A method which takes a whole number and a string and returns true if they are numerically equal. Note that the string "0042" should return true if the number is 42
            Func<int, string, bool> numEqual = (int num, string str) => num == int.Parse(str);
            Console.WriteLine(numEqual(42, "0042"));

            foreach(var w in Queries.WizardsInventedByRowlingLINQ()) {
                Console.WriteLine(w);
            }

            Console.WriteLine(Queries.YearOfTheFirstSithLordLINQ());

            foreach(var w in Queries.ListOfWizardsFromHarryPotterLINQ()) {
                Console.WriteLine(w);
            }

            foreach(var w in Queries.ListOfWizardsGroupedByCreatorLINQ()) {
                Console.WriteLine(w);
            }
            foreach(var w in Queries.ListOfWizardsGroupedByCreatorExtensions()) {
                Console.WriteLine(w);
            }
        }
    }
}
