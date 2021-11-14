using SEDC.CSharpAdv.Class02.Classes.AbstractInheritance;
using SEDC.CSharpAdv.Class02.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class02.Classes.Implementation
{
    public class Student : User, IStudent
    {
        public Student(int id, string name, string username,string password,List<int> grades)
            :base(id,name,username,password)
        {
            Grades = grades;  //new List<int>
        }
        public List<int> Grades { get ; set; }

        public override void PrintUser()
        {
            Console.WriteLine($"The grades of {Name}:");
            foreach (int grade in Grades)
            { 
                Console.Write(grade + ",");
                Console.WriteLine();
            }
        }
    }
}
