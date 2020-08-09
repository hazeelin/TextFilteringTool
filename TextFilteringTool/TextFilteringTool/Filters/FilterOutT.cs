using System;
using System.Linq;
using TextFilteringTool.Interfaces;

namespace TextFilteringTool.Filters
{
    public class FilterOutT : BaseFilter, IFilter
    {
        public override string ApplyFilter(string input)
        {
            string _input;
            if (input != null)
            {
                _input = Filter(input, "t");
                return base.ApplyFilter(_input);
            }
            else
                return null;
        }

        public override string Filter(string input, string toFilterOut)
        {
            if (toFilterOut == null)
                throw new ArgumentNullException("toFilterOut argument cannot be null");

            if (toFilterOut != null)
            {
                if (input == null)
                    return null;
                if (toFilterOut.Contains(' '))
                    throw new ArgumentNullException("This method does not support searching for spaces");
                if (input.Contains(' '))
                    throw new InvalidOperationException("This method only supports searching by word, not sentence");
                return input.ToLower().Where(c => toFilterOut.ToLower().Contains(c)).Any()
                    ? null
                    : input;
            }

            return input;
        }

    }
}
