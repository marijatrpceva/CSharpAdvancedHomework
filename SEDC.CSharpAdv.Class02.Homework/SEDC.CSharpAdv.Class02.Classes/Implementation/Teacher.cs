using SEDC.CSharpAdv.Class02.Classes.AbstractInheritance;
using SEDC.CSharpAdv.Class02.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class02.Classes.Implementation
{
    public class Teacher : User, ITeacher
    {
        public Teacher(int id, string name, string username, string password, string subj)
            : base(id, name, username, password)
        {
            Subject = subj;

        }
        public string Subject { get ; set ; }

        public override void PrintUser()
        {
            Console.WriteLine($"The subject that {Name} teaches is {Subject}");
        }
    }
}
