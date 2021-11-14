using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class04.Exercise.Entities
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public string Size { get; set; }
        public override string PrintInfo()
        {
            return $"This is {Type}, name: {Name}, color: {Color}";
        }
    }
}
