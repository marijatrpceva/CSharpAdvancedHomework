using SEDC.CSharpAdv.Class04.Exercise.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class04.Exercise.Entities
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public TypeOfPet Type { get; set; }

        public abstract string PrintInfo();
    }


}
