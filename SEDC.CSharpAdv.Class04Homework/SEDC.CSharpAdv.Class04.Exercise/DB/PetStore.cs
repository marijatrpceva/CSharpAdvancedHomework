using SEDC.CSharpAdv.Class04.Exercise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.CSharpAdv.Class04.Exercise.DB
{
    public class PetStore<T>
        where T : Pet
    {
        public List<T> Db { get; set; }
        

        public PetStore()
        {
            Db = new List<T>();
        }

      
        public void Isert(T item)
        {
            Db.Add(item);
        }

        public void printsPets()
        {
            foreach (T item in Db)
            {
                Console.WriteLine(item.PrintInfo());
            }
        }

        //BuyPet() -Method that takes ‘name’ as parameter,
        //find the first pet by that name,
        //removes it from the list and gives a success  message. If there is no pet by that name, inform the customer

        public void BuyPet(string name)
        {
            T item = Db.FirstOrDefault(x => x.Name == name);
            if(item != null)
            {
                Db.Remove(item);
            }
            else
            {
                Console.WriteLine("No such pet");
            }
            
        }

    }
}
