namespace TestProjectKataRoman
{
    internal class NumericToRomanConverter
    {
        private const char ROMAN_NUMBER_ONE = 'I';
        private const string ROMAN_NUMBER_FIVE = "V";
        private const string ROMAN_NUMBER_TEN = "X";
        private const string ROMAN_NUMBER_FIFTY = "L";

        public NumericToRomanConverter()
        { }

        internal string NumericToRoman(int normalNumber)
        {
            int threshold = 40;
            string roman_threshold = ROMAN_NUMBER_TEN + ROMAN_NUMBER_FIFTY;

            if (normalNumber >= threshold)
                return roman_threshold + NumericToRoman(normalNumber - threshold);

            threshold = 10;
            roman_threshold = ROMAN_NUMBER_TEN;

            if (normalNumber >= threshold)
                return roman_threshold + NumericToRoman(normalNumber - threshold);

            if (normalNumber >= 9)
                return ROMAN_NUMBER_ONE + ROMAN_NUMBER_TEN + NumericToRoman(normalNumber - 9);
            if (normalNumber >= 5)
                return ROMAN_NUMBER_FIVE + NumericToRoman(normalNumber - 5);
            if (normalNumber >= 4)
                return ROMAN_NUMBER_ONE + ROMAN_NUMBER_FIVE + NumericToRoman(normalNumber - 4);

            return new String(ROMAN_NUMBER_ONE, normalNumber);
        }
    }
}