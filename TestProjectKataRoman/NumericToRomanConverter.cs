namespace TestProjectKataRoman
{
    internal class NumericToRomanConverter
    {
        public NumericToRomanConverter()
        {
        }

        internal string NumericToRoman(int normalNumber)
        {
            if (normalNumber == 4)
                return "IV";

            return new String('I', normalNumber);
        }
    }
}