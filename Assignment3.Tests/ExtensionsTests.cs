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
            var expected = new List<int> {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
            Assert.Equal(expected, xs.Flatten());
        }

        [Fact]
        public void Filter_Ext2_GivenListOfNumbers_ReturnsDivisibleBy7AndGreaterThan42()
        {
            Predicate<int> predicate = Extensions.Ext2;

            int[] ys = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 49, 70, 100, 200};

            var expected = new int[] {49, 70};
            Assert.Equal(expected, ys.Filter(predicate));
        }
        [Fact]
        public void Filter_Ext2_GivenListOfNumbersWithNoAcceptedNumber_ReturnsEmptyList()
        {
            Predicate<int> predicate = Extensions.Ext2;

            int[] ys = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 48, 69, 100, 200};

            var expected = new int[] {};
            Assert.Equal(expected, ys.Filter(predicate));
        }

        [Fact]
        public void Filter_LeapYear_GivenListOfYears_ReturnsLeapYears()
        {
            Predicate<int> predicate = Extensions.isLeapYear;

            int[] ys = new int[] {0, 1, 2, 3, 4, 100, 400, 1600, 1800, 1500, 99, 16, 300, 13, 14, 15};

            var expected = new int[] { 4, 400, 1600, 16};
            Assert.Equal(expected, ys.Filter(predicate));
        }

        [Fact]
        public void isSecure_GivenHttps_ReturnsTrue()
        {
            var uri = new Uri("https://google.dk");
            Assert.True(uri.isSecure());
        }
        [Fact]
        public void isSecure_GivenHttp_ReturnsFalse()
        {
            var uri = new Uri("http://google.dk");
            Assert.False(uri.isSecure());
        }

        /* [Fact]
        public void WordCount_GivenStringOfAllTypesOfCharacters_ReturnsNumberOfWords()
        {
            var str = "This is a test 123 string for @£$€€@[&\"/¤/\"&&(/¤\" testing my WordCount method.";
            Assert.Equal(10, str.WordCount());
        } */
        /* [Fact]
        public void WordCount_GivenStringOfNoWords_ReturnsZero()
        {
            var str = "69 420 !\"#¤%& 1144 11943 =)(/&% 123 ^^^^ ^~~~>>\\`` @£$€€@[&\"/¤/\"&&(/¤\"";
            Assert.Equal(0, str.WordCount());
        } */
    }
}
