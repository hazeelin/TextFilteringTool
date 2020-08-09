using System.Linq;
using System.Text;

namespace TextFilteringTool.ExtensionMethods
{
    public static class StringExtensions
    {
        public static bool VowelFound(this string word)
        {
            if (word == null)
                return false;
            return word.Where(c => "AaEeIiOoUu".Contains(c)).Any();
        }

        public static string StripPunctuationsAndSymbols(this string input)
        {
            var sb = new StringBuilder();
            if (!(input == null))
            {
                foreach (char c in input)
                {
                    if (!char.IsPunctuation(c) && (!char.IsSymbol(c)))
                        sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}
