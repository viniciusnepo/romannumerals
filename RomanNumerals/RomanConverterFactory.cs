using RomanNumerals.Converters;

namespace RomanNumerals
{
    public static class RomanConverterFactory
    {
        public static RomanConverter CreateConverter(int number)
        {
            if (number >= 1000)
                return new ThousandsRomanConverter();
            if (number >= 100)
                return new HundredsRomanConverter();
            if (number >= 10)
                return new ThenthsRomanConverter();
            return new UnitsRomanConverter();
        }
    }
}
