using SEDC.CSharpAdv.Class01.Task01.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.CSharpAdv.Class01.Task01.Logic.Services
{
    public class SearchService
    {  
        public List<SearchResult> CountApperancesInText1(string text, List<string> names)
        {
            string[] searchText = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            return names.Select(name =>
            new SearchResult
            {
                Name = name,
                Apperances = searchText.Where(word => word.Equals(name, StringComparison.OrdinalIgnoreCase)).Count()
            }).ToList();

        }
        public void CountApperancesInText(string text,List<string> names)
        {
            string[] searchText = text.Split(" ");

            int counter = 0;

            foreach (string name in names)
            {
                foreach (string word in searchText)
                {
                    if(word.Trim().ToLower() == name.Trim().ToLower())
                    {
                        counter++;
                    }
                }
                Console.WriteLine($"The name: {name}, is contained: {counter} times");
                counter = 0;

            }
        }
    }
}
