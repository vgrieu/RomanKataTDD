using System.Text;

namespace TestProjectKataRoman
{
    internal class NumericToRomanConverter
    {
        private const char ROMAN_NUMBER_ONE = 'I';
        private const string ROMAN_NUMBER_FIVE = "V";
        private const string ROMAN_NUMBER_TEN = "X";
        private const string ROMAN_NUMBER_FIFTY = "L";
        private const string ROMAN_NUMBER_HUNDRED = "C";

        private static List<(int arab, string roman)> _romanNumbersCases = new List<(int, string)>
        {
            (90, ROMAN_NUMBER_TEN + ROMAN_NUMBER_HUNDRED)
            , (50, ROMAN_NUMBER_FIFTY)
            , (40, ROMAN_NUMBER_TEN + ROMAN_NUMBER_FIFTY)
            , (10, ROMAN_NUMBER_TEN)
            , (9, ROMAN_NUMBER_ONE + ROMAN_NUMBER_TEN)
            , (5, ROMAN_NUMBER_FIVE)
            , (4, ROMAN_NUMBER_ONE + ROMAN_NUMBER_FIVE)
            , (1, ROMAN_NUMBER_ONE.ToString())
        };

        /*
        * On itere sur les cas de la numérotation romaine
        * Pour chaque cas, 
        *   tant que le résultat doit s'écrire avec la valeur du cas en nombre romain
        *     on transfère la valeur du cas du nombre à transformer vers le résultat
        */

        internal string NumericToRoman(int numberToTransform)
        {
            StringBuilder result = new StringBuilder();

            foreach (var romanNumbersCase in _romanNumbersCases)
            {
                while (ResultIsWrittenWithCurrentRomanCase(numberToTransform, romanNumbersCase))
                {
                    numberToTransform = TransferCaseValueToResult(numberToTransform, result, romanNumbersCase);
                }
            }

            return result.ToString();
        }

        private static int TransferCaseValueToResult(int numberToTransform, StringBuilder result, (int arab, string roman) romanNumbersCase)
        {
            numberToTransform -= romanNumbersCase.arab;
            result.Append(romanNumbersCase.roman);
            return numberToTransform;
        }

        private static bool ResultIsWrittenWithCurrentRomanCase(int numberToTransform, (int arab, string roman) romanNumbersCase)
        {
            return numberToTransform >= romanNumbersCase.arab;
        }
    }

    public class Solution
    {
        public string IntToRoman(int num)
        {
            List<char> list = new List<char>();

            while (num > 0)
            {
                switch (num)
                {
                    case >= 1000:
                        list.Add('M');
                        num -= 1000;
                        break;
                    case >= 900:
                        list.Add('C');
                        list.Add('M');
                        num -= 900;
                        break;
                    case >= 500:
                        list.Add('D');
                        num -= 500;
                        break;
                    case >= 400:
                        list.Add('C');
                        list.Add('D');
                        num -= 400;
                        break;
                    case >= 100:
                        list.Add('C');
                        num -= 100;
                        break;
                    case >= 90:
                        list.Add('X');
                        list.Add('C');
                        num -= 90;
                        break;
                    case >= 50:
                        list.Add('L');
                        num -= 50;
                        break;
                    case >= 40:
                        list.Add('X');
                        list.Add('L');
                        num -= 40;
                        break;
                    case >= 10:
                        list.Add('X');
                        num -= 10;
                        break;
                    case >= 9:
                        list.Add('I');
                        list.Add('X');
                        num -= 9;
                        break;
                    case >= 5:
                        list.Add('V');
                        num -= 5;
                        break;
                    case >= 4:
                        list.Add('I');
                        list.Add('V');
                        num -= 4;
                        break;
                    case >= 1:
                        list.Add('I');
                        num -= 1;
                        break;
                    default:
                        break;
                }
            }

            return string.Concat(list);
        }
    }
}