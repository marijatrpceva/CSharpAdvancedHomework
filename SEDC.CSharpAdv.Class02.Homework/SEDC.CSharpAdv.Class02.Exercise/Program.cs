using SEDC.CSharpAdv.Class02.Classes.Implementation;
using System;
using System.Collections.Generic;

namespace SEDC.CSharpAdv.Class02.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher1 = new Teacher(123,"Ana","AnaBanana","123asd","JavaScript");
            Teacher teacher2 = new Teacher(456,"John","JohnStrong","456asd","C#");

            Student student1 = new Student(1245, "Bob", "BobBenson", "1245asd", new List<int>() { 4,3 });
            Student student2 = new Student(1245, "Jen", "JenJenson", "2356asd", new List<int>() { 4,5 });

            teacher1.PrintUser();
            teacher2.PrintUser();
            Console.WriteLine("===============");
            student1.PrintUser();
            student2.PrintUser();
        }
    }
}
