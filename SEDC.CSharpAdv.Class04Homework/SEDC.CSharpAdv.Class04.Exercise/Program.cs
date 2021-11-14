using SEDC.CSharpAdv.Class04.Exercise.DB;
using SEDC.CSharpAdv.Class04.Exercise.Entities;
using SEDC.CSharpAdv.Class04.Exercise.Enum;
using SEDC.CSharpAdv.Class04.Exercise.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.CSharpAdv.Class04.Exercise
{
    class Program
    {
        public static PetStore<Dog> DogDb = new PetStore<Dog>();
        public static PetStore<Cat> CatDb = new PetStore<Cat>();
        public static PetStore<Fish> FishDb = new PetStore<Fish>();

       

       // public static List<Pet> AllPets = new List<Pet>();

        static void Main(string[] args)
        {
           
            DogDb.Isert(new Dog() { Name = "Buck", Age = 2, Type = TypeOfPet.Dog, FavouriteFood = "Beef", GoodBoy = true });
            DogDb.Isert(new Dog() { Name = "Lucy", Age = 3, Type = TypeOfPet.Dog, FavouriteFood = "Tuna", GoodBoy = true });

            CatDb.Isert(new Cat() { Name = "Mia", Age = 7, Type = TypeOfPet.Cat, Lazy = false, LifesLeft = 2 });
            CatDb.Isert(new Cat() { Name = "Oslo", Age = 5, Type = TypeOfPet.Cat, Lazy = true, LifesLeft = 9 });

            FishDb.Isert(new Fish() { Name = "Bob", Age = 1, Type = TypeOfPet.Fish, Color = "Yellow", Size = "Small" });
            FishDb.Isert(new Fish() { Name = "Shark", Age = 3, Type = TypeOfPet.Fish, Color = "Black", Size = "Medium" });


            ObjectHelper objhelper = new ObjectHelper();
            objhelper.AddAllPets(DogDb.Db);
            objhelper.AddAllPets(CatDb.Db);
            objhelper.AddAllPets(FishDb.Db);

            Console.WriteLine("Enter the name of the pet you want to buy");
            string name = Console.ReadLine();
            Pet petWithName = objhelper.FindPet(name);
            if (petWithName != null)
            {
                if (petWithName.Type == TypeOfPet.Dog)
                {
                    DogDb.BuyPet(name);
                }
                else if(petWithName.Type == TypeOfPet.Cat)
                {
                    CatDb.BuyPet(name);
                } else
                {
                    FishDb.BuyPet(name);
                }
            }
            else { Console.WriteLine("Pet with such name does not exist"); }
            

        
            DogDb.printsPets();
            CatDb.printsPets();
            FishDb.printsPets();
        }
    }
}
