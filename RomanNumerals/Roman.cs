using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public static class Roman
    {
        public static string ConvertToRoman(this int number)
        {
            var roman = new StringBuilder();

            while (number > 0)
            {
                var converter = RomanConverterFactory.CreateConverter(number);
                roman.Append(converter.CalculateRoman(ref number));
            }

            return roman.ToString();
        }
    }
}
