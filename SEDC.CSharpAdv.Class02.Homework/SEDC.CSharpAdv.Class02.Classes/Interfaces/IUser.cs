using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class02.Classes.Interfaces
{
    public interface IUser
    {
        int Id { get; set; }
        string Name { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        void PrintUser();
    }
}
