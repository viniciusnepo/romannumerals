using System.Text.RegularExpressions;

namespace RomanNumerals.Converters
{
    public class HundredsRomanConverter : RomanConverter
    {
        public HundredsRomanConverter() : base('C', 100)
        {
        }

        protected override string ReplaceInvalidChars(string roman)
        {
            roman = new Regex("C{9}").Replace(roman, "CM");
            roman = new Regex("C{5}").Replace(roman, "D");
            roman = new Regex("C{4}").Replace(roman, "CD");
            return roman;
        }
    }
}
