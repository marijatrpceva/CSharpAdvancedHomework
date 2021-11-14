using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class04.Exercise.Entities
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LifesLeft { get; set; }
        public override string PrintInfo()
        {
            return $"This is {Type}, name: {Name}, lifes left: {LifesLeft}";
        }
    }
}
