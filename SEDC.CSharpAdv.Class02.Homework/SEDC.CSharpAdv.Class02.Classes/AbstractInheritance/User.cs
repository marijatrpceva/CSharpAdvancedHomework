using SEDC.CSharpAdv.Class02.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class02.Classes.AbstractInheritance
{
    public abstract class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public abstract void PrintUser();

        public User(int id, string name, string username, string password)
        {
            Id = id;
            Name = name;
            UserName = username;
            Password = password;
        }
       
    }
}
