using System;
using System.Linq;
using Xunit;

namespace BDSA2021.Assignment03.Tests
{
    public class DelegatesTests
    {
        [Fact]
        public void ReverseString_GivenString_ReturnsReversedString()
        {
            //Action<string> reverse = rs => Console.WriteLine(string.Join("", rs.Reverse()));
            // reverse("Reverse this string");
            Converter<string, string> reverse = rs => string.Join("", rs.Reverse());
            string reverseThis = "Reverse this string";
            Assert.Equal("gnirts siht esreveR", reverse(reverseThis));
        }

        [Fact]
        public void Multiply_GivenTwoDoubles_ReturnsProduct()
        {
            Func<double, double, double> multiply = (d1, d2) => d1 * d2;
            Assert.Equal(38.25, multiply(2.5, 15.3));
        }

        [Fact]
        public void NumericallyEqual_GivenNumericallyEqualIntegerAndString_ReturnsTrue()
        {
            Func<int, string, bool> numEqual = (int num, string str) => num == int.Parse(str);
            Assert.True(numEqual(69, " 0000069"));
        }
        [Fact]
        public void NumericallyEqual_GivenNotNumericallyEqualIntegerAndString_ReturnsFalse()
        {
            Func<int, string, bool> numEqual = (int num, string str) => num == int.Parse(str);
            Assert.False(numEqual(69, "00000690"));
        }
    }
}
