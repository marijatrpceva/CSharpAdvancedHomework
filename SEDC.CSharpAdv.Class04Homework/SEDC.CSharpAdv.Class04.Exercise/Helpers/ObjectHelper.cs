using SEDC.CSharpAdv.Class04.Exercise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.CSharpAdv.Class04.Exercise.Helpers
{
    public  class ObjectHelper
    {
        public static List<Pet> AllPets = new List<Pet>();
        public void AddAllPets<T>(List<T> list)
            where T : Pet
        {
            foreach (T item in list)
            {
                AllPets.Add(item);
            }
        }

        public Pet FindPet(string name)
        {
            Pet pet = AllPets.FirstOrDefault(x => x.Name == name);
            return pet;
        }
        //public static void AddAllPets<T>(this List<T> list)
        //    where T : Pet
        //{
        //    foreach (T item in list)
        //    {
        //       AllPets.Add(item);
        //    }
        //}
    }
}
