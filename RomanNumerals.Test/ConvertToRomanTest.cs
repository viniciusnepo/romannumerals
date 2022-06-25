namespace RomanNumerals.Test
{
    public class ConvertToRomanTest
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        [InlineData(40, "XL")]
        [InlineData(50, "L")]
        [InlineData(99, "XCIX")]
        [InlineData(100, "C")]
        [InlineData(400, "CD")]
        [InlineData(500, "D")]
        [InlineData(999, "CMXCIX")]
        [InlineData(1000, "M")]
        public void ConvertToRoman(int number, string expected)
        {
            var result = number.ConvertToRoman();
            Assert.Equal(expected, result);
        }
    }
}