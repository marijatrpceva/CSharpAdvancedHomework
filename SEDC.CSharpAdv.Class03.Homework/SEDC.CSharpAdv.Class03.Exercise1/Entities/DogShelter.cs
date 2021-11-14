using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class03.Exercise1.Entities
{
    public static class DogShelter
    {
        public static List<Dog> ListOfDogs = new List<Dog>();
        
 
        
        public static void PrintAllDogs()
        {
            //foreach(Dog dog in ListOfDogs)
            // {
            //     Console.WriteLine(Name);
            // }
            for (int i = 1; i <= ListOfDogs.Count; i++)
            {
                Console.WriteLine($"1) {ListOfDogs[i-1].Name}");
            }
        }


    }
}
