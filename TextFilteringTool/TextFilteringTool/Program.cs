using System;
using TextFilteringTool.Data;
using TextFilteringTool.Filters;

namespace TextFilteringTool
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Here is an example of how to run this program from command prompt:");
                Console.WriteLine(@"TextFilteringTool testdata.txt");
                return;
            }
            try
            {
                var filter1 = new FilterOutWordWithMidVowel();
                var filter2 = new FilterOutMinLengthNotMet();
                var filter3 = new FilterOutT();

                filter1.SetNext(filter2).SetNext(filter3);

                var dr = new TextFileReader(args[0].ToString());

                var dfp = new DataFilteringProcess(filter1);
                var filteredData = dfp.ApplyAllFilters(dr.LoadData());

                Console.WriteLine(string.Join(" ", filteredData));
            }
            catch (Exception e)
            {
                Console.WriteLine("Ooops! An error has occured! {0}", e.Message);
            }

        }
    }
}
