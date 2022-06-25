namespace RomanNumerals.Converters
{
    public class ThousandsRomanConverter : RomanConverter
    {
        public ThousandsRomanConverter() : base('M', 1000)
        {
        }

        protected override string ReplaceInvalidChars(string roman)
        {
            return roman;
        }
    }
}
