using System.Collections.Generic;
using TextFilteringTool.Interfaces;

namespace TextFilteringTool.Data
{
    public class DataFilteringProcess
    {
        private readonly IFilter _filter;

        public DataFilteringProcess(IFilter filter)
        {
            _filter = filter;
        }

        public List<string> ApplyAllFilters(List<string> data)
        {
            var list = new List<string>();

            foreach (var word in data)
            {
                var result = _filter.ApplyFilter(word);
                if (result != null && result.Length != 0)
                    list.Add(result);

            }
            return list;
        }
    }
}
