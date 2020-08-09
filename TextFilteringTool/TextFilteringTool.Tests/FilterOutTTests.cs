using NUnit.Framework;
using System;
using TextFilteringTool.Filters;

namespace TextFilteringTool.Tests
{
    [TestFixture]
    public class FilterOutTTests
    {
        [Test]
        public void ApplyFilter_WhenCalledWithNoLetterT_ReturnsTheInputValue()
        {

            string input = "School";
            string expected = "School";

            var filter = new FilterOutT();

            var result = filter.ApplyFilter(input);

            Assert.That(result, Is.EqualTo(expected));

        }

        [Test]
        public void ApplyFilter_WhenCalledWithLetterT_ReturnsNull()
        {

            string input = "Artist";
            string expected = null;

            var filter = new FilterOutT();

            var result = filter.ApplyFilter(input);

            Assert.That(result, Is.EqualTo(expected));

        }

        [Test]
        public void ApplyFilter_WhenCalledWithLetterTandSpaces_ThrowsInvalidOperationException()
        {
            string input = "Cats and Dogs";
            var result = "";
            var filter = new FilterOutT();

            Assert.Throws<InvalidOperationException>(() => result = filter.ApplyFilter(input));

        }

        [Test]
        public void Filter_WhenCalledWithEmptyToFilterOutParameter_ThrowsArgumentNullException()
        {
            string input = "Cats";
            string toFilterOut = null;
            var result = "";
            var filter = new FilterOutT();

            Assert.Throws<ArgumentNullException>(() => result = filter.Filter(input, toFilterOut));

        }

    }
}
