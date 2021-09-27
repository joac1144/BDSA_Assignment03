using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace BDSA2021.Assignment03
{
    public static class Extensions
    {
        public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> items) => items.SelectMany(itemList => itemList).ToList<T>();
        
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> items, Predicate<T> predicate) => items.Where(item => predicate(item));

        public static bool isSecure(this Uri uri) => uri.Scheme == Uri.UriSchemeHttps;

        public static int WordCount(this string x) => Regex.Matches(x, @"[\p{L}]+").Count();

        // Predicates
        public static bool isLeapYear(int x) {
            if(x == 0) return false;
            if(x % 400 == 0) return true;
            if(x % 100 == 0) return false;
            if(x % 4 == 0) return true;
            return false;
        }

        public static bool Ext2(int x) => x > 42 ? (x % 7 == 0 ? true : false) : false;
    }
}
