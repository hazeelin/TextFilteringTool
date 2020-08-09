using System;
using System.Linq;
using TextFilteringTool.Interfaces;

namespace TextFilteringTool.Filters
{
    public class FilterOutMinLengthNotMet : BaseFilter, IFilter
    {
        public override string ApplyFilter(string input)
        {
            string _input;
            if (input != null)
            {
                _input = Filter(input, 3);
                return base.ApplyFilter(_input);
            }
            else
            {
                return null;
            }
        }

        public override string Filter(string input, int intValueForRules)
        {
            if (input == null)
                return null;

            if (input.Contains(' '))
                throw new InvalidOperationException("This method only supports searching by word, not sentence");

            //*** Important note for later: Need to set a limit right now but 
            //*** I will check with the product owner if this is okay
            if (intValueForRules < 0 || intValueForRules > 50)
                throw new InvalidOperationException("Minimum word length must be between 1 and 50");

            return input.Length < intValueForRules
                ? null
                : input;
        }
    }
}
