using System.Text.RegularExpressions;

namespace RomanNumerals.Converters
{
    public class ThenthsRomanConverter : RomanConverter
    {
        public ThenthsRomanConverter() : base('X', 10)
        {
        }

        protected override string ReplaceInvalidChars(string roman)
        {
            roman = new Regex("X{9}").Replace(roman, "XC");
            roman = new Regex("X{5}").Replace(roman, "L");
            roman = new Regex("X{4}").Replace(roman, "XL");
            return roman;
        }
    }
}
