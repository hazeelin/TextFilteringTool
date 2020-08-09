using System;
using System.Collections.Generic;
using System.IO;
using TextFilteringTool.ExtensionMethods;
using TextFilteringTool.Interfaces;

namespace TextFilteringTool.Data
{
    public class TextFileReader : ICommonDataReader
    {
        readonly string _fileOrConnectionString;

        public TextFileReader(string fileOrConnectionString)
        {
            _fileOrConnectionString = fileOrConnectionString;
        }

        public List<string> LoadData()
        {
            List<string> list = new List<string>();

            try
            {
                FileInfo info = new FileInfo(_fileOrConnectionString);
                if (info.Length == 0)
                    throw new Exception("The file is empty!");

                using (StreamReader reader = new StreamReader(_fileOrConnectionString))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        String[] words = line.StripPunctuationsAndSymbols().Split(' ');
                        foreach (var word in words)
                        {
                            list.Add(word);
                        }
                    }
                }
                return list;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
