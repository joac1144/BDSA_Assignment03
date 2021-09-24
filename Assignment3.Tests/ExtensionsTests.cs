using System;
using Xunit;
using System.Collections.Generic;

namespace BDSA2021.Assignment03.Tests
{
    public class ExtensionsTests
    {
        [Fact]
        public void Flatten_flattens()
        {
            IEnumerable<int>[] xs = new  IEnumerable<int>[]{
                new int[] { 0, 1, 2, 3, 4 },
                new int[] { 5, 6, 7, 8 },
                new int[] { 9, 10, 11, 12 }

            };
            var expected = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            Assert.Equal(expected, xs.Flatten());
        
        }

        [Fact]
        public void Filter_filters_even()
        {
            Predicate<int> even = Extensions.Even;

            int[] ys = new int[]{ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            var expected = new int[] { 0, 2, 4, 6, 8, 10, 12, 14 };
            Assert.Equal(expected, ys.Filter(even));
        }
        [Fact]
        public void Filter_filters_divisibl7_greater42()
        {
            Predicate<int> seven = Extensions.Ext2;

            int[] ys = new int[]{ 0, 1, 2, 3, 4, 5, 6, 7, 49, 70, 100, 200 };

            var expected = new int[] {49, 70};
            Assert.Equal(expected, ys.Filter(seven));
        }
        [Fact]
        public void Filter_filters_leapYear()
        {
            Predicate<int> leap = Extensions.isLeapYear;

            int[] ys = new int[]{ 0, 1, 2, 3, 4, 100, 400, 1600, 1800, 1500, 99, 16, 300, 13, 14, 15 };

            var expected = new int[] { 4, 400, 1600, 16};
            Assert.Equal(expected, ys.Filter(leap));
        }

        [Fact]
        public void isSecure_true()
        {
            var uri = new Uri("https://google.dk");
            Assert.True(uri.isSecure());
        }

        [Fact]
        public void isSecure_false()
        {
            var uri = new Uri("http://google.dk");
            Assert.False(uri.isSecure());
        }
    }
}
