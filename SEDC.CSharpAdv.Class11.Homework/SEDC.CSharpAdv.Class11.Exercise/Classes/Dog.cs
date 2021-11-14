using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class11.Exercise.Classes
{
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }

        public Dog(string name, int age, string color)
        {
            this.Name = name;
            this.Age = age;
            this.Color = color;
        }
    }
}
