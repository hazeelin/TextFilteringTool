using NUnit.Framework;
using TextFilteringTool.ExtensionMethods;


namespace TextFilteringTool.Tests
{
    [TestFixture]
    public class StringExtensionMethodTests
    {
        [Test]
        public void VowelFound_NullInput_ReturnsFalse()
        {
            string input = null;

            var result = input.VowelFound();

            Assert.IsFalse(result);
        }

        [Test]
        public void VowelFound_EmptyStringInput_ReturnsFalse()
        {
            string input = "";

            var result = input.VowelFound();

            Assert.IsFalse(result);
        }

        [Test]
        public void VowelFound_NumericStringInput_ReturnsFalse()
        {

            string input = "123456789343434343";

            var result = input.VowelFound();

            Assert.IsFalse(result);
        }

        [Test]
        public void VowelFound_StringWithVowels_ReturnsTrue()
        {

            string input = "Hello123";

            var result = input.VowelFound();

            Assert.IsTrue(result);
        }

        [Test]
        public void VowelFound_UpperCaseWithVowels_ReturnsTrue()
        {

            string input = "ABCD";

            var result = input.VowelFound();

            Assert.IsTrue(result);
        }

        [Test]
        public void StripPunctuationsAndSymbols_WhenRun_StripsPuncAndSymbols()
        {

            string input = "AB-C#D^123's = $4.50?/ @yahoo.com, ****Stars**** (amp&) {Curly} <less + greater>";
            string expected = "ABCD123s  450 yahoocom Stars amp Curly less  greater";

            var result = input.StripPunctuationsAndSymbols();

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void StripPunctuationsAndSymbols_WhenRunOnNull_ReturnsEmptyString()
        {
            string input = null;

            var result = input.StripPunctuationsAndSymbols();

            Assert.That(result, Is.EqualTo(""));
        }
    }
}