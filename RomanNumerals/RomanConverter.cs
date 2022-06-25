namespace RomanNumerals
{
    public abstract class RomanConverter
    {
        public char RomanChar { get; set; }
        public int DecimalValue { get; set; }

        protected RomanConverter(char romanChar, int decimalValue)
        {
            RomanChar = romanChar;
            DecimalValue = decimalValue;
        }

        protected abstract string ReplaceInvalidChars(string roman);

        public string CalculateRoman(ref int number)
        {
            var roman = CalculateRepetition(ref number);
            roman = ReplaceInvalidChars(roman);
            return roman;
        }

        protected string CalculateRepetition(ref int originalNumber)
        {
            var count = originalNumber / DecimalValue;
            var romanString = new string(RomanChar, originalNumber / DecimalValue);
            originalNumber -= count * DecimalValue;
            return romanString;
        }
    }
}
