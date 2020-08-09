using NUnit.Framework;
using System;
using TextFilteringTool.Filters;

namespace TextFilteringTool.Tests
{
    [TestFixture]
    public class FilterOutWordWithMidVowelTests
    {
        [Test]
        public void Filter_WhenCalledWithNullInput_ReturnsNull()
        {

            string input = null;

            var filter = new FilterOutWordWithMidVowel();

            var result = filter.Filter(input);

            Assert.That(result, Is.EqualTo(null));
        }

        [Test]
        public void Filter_WhenCalledWithTextAndSpaces_ThrowsInvalidOperationException()
        {
            string input = "Cats and Dogs";
            var result = "";
            var filter = new FilterOutWordWithMidVowel();

            Assert.Throws<InvalidOperationException>(() => result = filter.Filter(input));

        }

        [Test]
        public void Filter_OddLengthWithMidVowel_ReturnsNull()
        {
            string input = "Clean";
            string expectedResult = null;

            var filter = new FilterOutWordWithMidVowel();

            var result = filter.Filter(input);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Filter_OddLengthWithNoMidVowel_ReturnsTheInput()
        {
            string input = "rather";
            string expectedResult = input;

            var filter = new FilterOutWordWithMidVowel();

            var result = filter.Filter(input);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Filter_EvenLengthWithMidVowel_ReturnsNull()
        {
            string input = "what";
            string expectedResult = null;

            var filter = new FilterOutWordWithMidVowel();

            var result = filter.Filter(input);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Filter_EvenLengthWithNoMidVowel_ReturnsTheInput()
        {
            string input = "the";
            string expectedResult = input;

            var filter = new FilterOutWordWithMidVowel();

            var result = filter.Filter(input);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Filter_OddLengthUpperCaseWithMidVowel_ReturnsNull()
        {
            string input = "CLEAN";
            string expectedResult = null;

            var filter = new FilterOutWordWithMidVowel();

            var result = filter.Filter(input);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Filter_OddLengthUpperCaseWithNoMidVowel_ReturnsTheInput()
        {
            string input = "RATHER";
            string expectedResult = input;

            var filter = new FilterOutWordWithMidVowel();

            var result = filter.Filter(input);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Filter_EvenLengthUpperCaseWithMidVowel_ReturnsNull()
        {
            string input = "WHAT";
            string expectedResult = null;

            var filter = new FilterOutWordWithMidVowel();

            var result = filter.Filter(input);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Filter_EvenLengthUpperCaseWithNoMidVowel_ReturnsTheInput()
        {
            string input = "THE";
            string expectedResult = input;

            var filter = new FilterOutWordWithMidVowel();

            var result = filter.Filter(input);
            Assert.That(result, Is.EqualTo(expectedResult));
        }



    }
}
