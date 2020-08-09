namespace TextFilteringTool.Interfaces
{
    public interface IFilter
    {
        string ApplyFilter(string input);
        string Filter(string input);
        string Filter(string input, int intValueForRules);
        string Filter(string input, string intValueForRules);
    }
}