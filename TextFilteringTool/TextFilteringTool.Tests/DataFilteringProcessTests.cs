using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using TextFilteringTool.Data;
using TextFilteringTool.Filters;
using TextFilteringTool.Interfaces;

namespace TextFilteringTool.Tests
{
    [TestFixture]
    public class DataFilteringProcessTests
    {
        [Test]
        public void ExecuteAllFilters_WhenDataSupplied_ReturnsFilteredData()
        {
            var filter1 = new FilterOutWordWithMidVowel();
            var filter2 = new FilterOutMinLengthNotMet();
            var filter3 = new FilterOutT();
            var fakeData = new List<string>();
            var expectedList = new List<string>();

            var fileReader = new Mock<ICommonDataReader>();

            fakeData.Add("Alice");
            fakeData.Add("and");
            fakeData.Add("she");
            fakeData.Add("do");
            fakeData.Add("reading");
            fakeData.Add("cupboards");
            fakeData.Add("dear");
            fakeData.Add("thought");
            fakeData.Add("hedgeIn");
            fakeData.Add("shelves");


            expectedList.Add("and");
            expectedList.Add("she");
            expectedList.Add("reading");
            expectedList.Add("hedgeIn");
            expectedList.Add("shelves");

            fileReader.Setup(fr => fr.LoadData()).Returns(fakeData);

            var obj = new DataFilteringProcess(filter1);
            var result = obj.ApplyAllFilters(fileReader.Object.LoadData());

            Assert.That(result, Is.EqualTo(expectedList));
        }
    }
}
