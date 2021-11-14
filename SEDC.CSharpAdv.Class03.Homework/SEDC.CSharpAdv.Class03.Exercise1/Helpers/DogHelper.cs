using SEDC.CSharpAdv.Class03.Exercise1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class03.Exercise1.Helpers
{
    public static class DogHelper
    {
        public static bool Validate(Dog dog)
        {
            if (dog.Id < 0 || dog.Name.Length < 2 || dog.Color == "")
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
}
