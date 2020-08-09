using NUnit.Framework;
using System;
using TextFilteringTool.Filters;

namespace TextFilteringTool.Tests
{

    [TestFixture]
    public class FilterOurMinLengthNotMetTests
    {
        [Test]
        public void Filter_WhenCalledWithNullInput_ReturnsNull()
        {

            string input = null;
            int intValueForRules = 5;

            var filter = new FilterOutMinLengthNotMet();

            var result = filter.Filter(input, intValueForRules);

            Assert.That(result, Is.EqualTo(null));
        }

        [Test]
        public void Filter_WhenCalledWithNegativeMinLength_ThrowsInvalidOperationException()
        {

            string input = "Something";
            int intValueForRules = -5;

            var filter = new FilterOutMinLengthNotMet();

            var result = "";

            Assert.Throws<InvalidOperationException>(() => result = filter.Filter(input, intValueForRules));
        }

        [Test]
        public void Filter_WhenCalledWithMinLengthOver50_ThrowsInvalidOperationException()
        {

            string input = "Something";
            int intValueForRules = 55;

            var filter = new FilterOutMinLengthNotMet();

            var result = "";

            Assert.Throws<InvalidOperationException>(() => result = filter.Filter(input, intValueForRules));
        }

        [Test]
        public void Filter_WhenCalledWhenMinLengthMet_ReturnsTheInput()
        {

            string input = "Something";
            var expectedResult = "Something";
            int intValueForRules = 5;

            var filter = new FilterOutMinLengthNotMet();

            var result = filter.Filter(input, intValueForRules);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Filter_WhenCalledWhenMinLengthNotMet_ReturnsNull()
        {

            string input = "The";
            string expectedResult = null;
            int intValueForRules = 5;

            var filter = new FilterOutMinLengthNotMet();

            var result = filter.Filter(input, intValueForRules);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Filter_WhenCalledWithTextAndSpaces_ThrowsInvalidOperationException()
        {
            string input = "Cats and Dogs";
            int intValueForRules = 5;
            var result = "";
            var filter = new FilterOutMinLengthNotMet();

            Assert.Throws<InvalidOperationException>(() => result = filter.Filter(input, intValueForRules));

        }
    }
}
