using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class04.Exercise.Entities
{
    public class Dog : Pet
    {
        public bool GoodBoy { get; set; }
        public string FavouriteFood { get; set; }
        public override string PrintInfo()
        {
            return $"This is {Type}, name: {Name}, favourite food: {FavouriteFood}";
        }


    }
}
