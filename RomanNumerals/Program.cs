/*
 * create a function that returns the Roman numeral for an integer between 1 and 2022.
 * i.e.  Roman(2022)= "MMXXII"
 * I=1, V=5, X=10, L=50, C=100, D=500,M=1000
 */

using RomanNumerals;
using System.Text;

var number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number.ConvertToRoman());


