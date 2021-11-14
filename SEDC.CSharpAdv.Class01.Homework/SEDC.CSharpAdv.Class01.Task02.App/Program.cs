using SEDC.CSharpAdv.Class01.Task02.Logic.Services;
using System;

namespace SEDC.CSharpAdv.Class01.Task02.App
{
    class Program
    {
        static void Main(string[] args)
        {
            FreeDayService freeDayService = new FreeDayService();
            DateTime date = new DateTime(2001, 1, 1);
            bool isFree = freeDayService.CheckIfDateIsNonWorkingDay(date);
            Console.WriteLine(isFree);

            Console.WriteLine(freeDayService.CheckIfDateIsNonWorkingDay2(date));
        }
    }
}
