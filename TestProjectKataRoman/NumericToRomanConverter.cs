namespace TestProjectKataRoman
{
    internal class NumericToRomanConverter
    {
        private const char ROMAN_NUMBER_ONE = 'I';
        private const string ROMAN_NUMBER_FIVE = "V";
        private const string ROMAN_NUMBER_TEN = "X";
        private const string ROMAN_NUMBER_FIFTY = "L";

        private static List<(int, string)> _romanNumbersStepsList = new List<(int, string)>
            {
                (40, ROMAN_NUMBER_TEN + ROMAN_NUMBER_FIFTY)
                , (10, ROMAN_NUMBER_TEN)
                , (9, ROMAN_NUMBER_ONE + ROMAN_NUMBER_TEN)
                , (5, ROMAN_NUMBER_FIVE)
                , (4, ROMAN_NUMBER_ONE + ROMAN_NUMBER_FIVE)
                , (1, ROMAN_NUMBER_ONE.ToString())
            };

        /*
        * On prend un nombre à transformer et on le transforme en nombre romain
        */

        /*
        * On prend un nombre à transformer 
        * on gère toutes les étapes de la numérotation romaine
        * et on renvoie le résultat en romain
        */

        /*
        * On itere sur les étapes de la numérotation romaine
        * Pour chaque étape, tant que le nombre à transformer est supérieur
        * ou égal à la valeur de cette étape en nombre arabe
        * on va ajouter la valeur de l'étape en nombre romain à notre résultat
        * et soustraire la valeur de l'étape du nombre à transformer.
        * Jusqu'à la dernière étape, puis on ajoute à notre résultat
        * un nombre de 'I' egal à ce qu'il reste du nombre à transformer
        */

        /*
        * On itere sur les étapes de la numérotation romaine
        * Pour chaque étape, tant que le nombre à transformer est supérieur
        * ou égal à la valeur de cette étape en nombre arabe
        * on va ajouter la valeur de l'étape en nombre romain à notre résultat
        * et soustraire la valeur de l'étape du nombre à transformer.
        */

        internal string NumericToRoman(int numberToTransform)
        {
            string result = string.Empty;
            foreach ((int arabStepValue, string romanStepValue) in _romanNumbersStepsList)
            {
                while (numberToTransform >= arabStepValue)
                {
                    numberToTransform = numberToTransform - arabStepValue;
                    result += romanStepValue;
                }
            }

            return result;
        }
    }
}