using SEDC.CSharpAdv.Class01.Task01.Logic.Models;
using SEDC.CSharpAdv.Class01.Task01.Logic.Services;
using System;
using System.Collections.Generic;

namespace SEDC.CSharpAdv.Class01.Task01.App
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = EnterNamesFromSreen();
            Console.WriteLine("Enter text");
            string text = Console.ReadLine();

            SearchService searchService = new SearchService();
            searchService.CountApperancesInText(text, names);
            Console.WriteLine("===============================");

            List<SearchResult> result1 = searchService.CountApperancesInText1(text, names);
            foreach (SearchResult searchResult in result1)
            {
                Console.WriteLine($"The name: {searchResult.Name}, is contained: {searchResult.Apperances} times");
            }

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.WriteLine(text);
            Console.ReadLine();
        }
        static List<string> EnterNamesFromSreen()
        {
            List<string> names = new List<string>();
            Console.WriteLine("Enter name:");
            Console.WriteLine("Enter x to stop adding names");
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "x" || name == "X")
                {
                    break;
                }
                names.Add(name);
            }

            return names;
        }
        
    }
}
