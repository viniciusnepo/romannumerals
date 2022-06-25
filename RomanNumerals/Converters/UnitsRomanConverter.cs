using System.Text.RegularExpressions;

namespace RomanNumerals.Converters
{
    public class UnitsRomanConverter : RomanConverter
    {
        public UnitsRomanConverter() : base('I', 1)
        {
        }

        protected override string ReplaceInvalidChars(string roman)
        {
            roman = new Regex("I{9}").Replace(roman, "IX");
            roman = new Regex("I{5}").Replace(roman, "V");
            roman = new Regex("I{4}").Replace(roman, "IV");
            return roman;
        }
    }
}
