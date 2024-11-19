using RomanNumberConverterApp.Ui.Models;

namespace RomanNumberConverterApp.Ui.Tests.Models
{
    public class RomanNumberConverterTests
    {
        private RomanNumberConverter _sut;

        [SetUp]
        public void BeforeEachTest()
        {
            _sut = new RomanNumberConverter();
        }

        [TestCase(0)]
        [TestCase(4000)]
        public void Convert_ValueIsNotBetweenOneAnd3999_ShouldThrowArgumentException(int number)
        {
            Assert.That(() => _sut.Convert(number), Throws.TypeOf<ArgumentException>().With.Message.EqualTo("Out of Roman range (1-3999)"));

        }

        [TestCase(1986, "MCMLXXXVI")]
        [TestCase(52, "LII")]
        [TestCase(174, "CLXXIV")]
        [TestCase(11, "XI")]
        [TestCase(3874, "MMMDCCCLXXIV")]
        public void Convert_ValidValue_ShouldReturnRomanNumberEquivalent(int number, string expectedResult)
        {
            string result = _sut.Convert(number);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}