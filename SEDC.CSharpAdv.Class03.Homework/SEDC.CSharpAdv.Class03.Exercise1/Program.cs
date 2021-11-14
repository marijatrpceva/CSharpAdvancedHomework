using SEDC.CSharpAdv.Class03.Exercise1.Entities;
using SEDC.CSharpAdv.Class03.Exercise1.Helpers;
using System;
using System.Collections.Generic;

namespace SEDC.CSharpAdv.Class03.Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> Dogs = new List<Dog>()
            {
                new Dog(1,"Buck","Black"),
                new Dog(2,"Lucy","White"),
                new Dog(3,"Max","")
            };

            foreach (Dog dog in Dogs)
            {
                if(DogHelper.Validate(dog))
                {
                    DogShelter.ListOfDogs.Add(dog);
                }
                
            }

            DogShelter.PrintAllDogs();
        }
    }
}
