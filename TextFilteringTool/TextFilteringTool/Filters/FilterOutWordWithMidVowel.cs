using System;
using System.Linq;
using TextFilteringTool.ExtensionMethods;
using TextFilteringTool.Interfaces;

namespace TextFilteringTool.Filters
{
    public class FilterOutWordWithMidVowel : BaseFilter, IFilter
    {
        public override string ApplyFilter(string input)
        {
            string _input;
            if (input != null)
            {
                _input = Filter(input.ToString());
                return base.ApplyFilter(_input);
            }
            else
            {
                return null;
            }
        }

        public override string Filter(string input)
        {
            if (input == null || input.Length == 0)
                return null;

            if (input.Contains(' '))
                throw new InvalidOperationException("This method is designed to support a single word only");

            bool vowelFound;
            int wordLength = input.Length;
            int middleIndex = (wordLength / 2);

            if (wordLength % 2 == 0)
                vowelFound = input.Substring(middleIndex - 1, 2).VowelFound();
            else
                vowelFound = input[middleIndex].ToString().VowelFound();

            return vowelFound ? null : input;
        }

    }
}
