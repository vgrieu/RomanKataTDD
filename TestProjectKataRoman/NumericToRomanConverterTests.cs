using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectKataRoman
{
    internal class NumericToRomanConverterTests
    {
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        public void NumericToRoman_Should_Return_Roman_When_Passing_Normal_Number(int numericInput, string expectedResult)
        {
            var converter = new NumericToRomanConverter();
            string result = converter.NumericToRoman(numericInput);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
