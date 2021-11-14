using SEDC.CSharpAdv.Class06.Homework.Data.Database;
using System;
using System.Linq;

namespace SEDC.CSharpAdv.Class06.Homework.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find and print all persons firstnames  starting with 'R', ordered by Age -DESCENDING ORDER
            var firstNameRDescendingAge = Exercise.Persons.Where(x => x.FirstName.StartsWith("R")).OrderByDescending(x => x.Age).ToList();
            foreach (var item in firstNameRDescendingAge)
            {
                Console.WriteLine($"Name: {item.FirstName}, age: {item.Age}");
            }

            //Find and print all brown dogs names and ages older than 3 years, ordered by Age -ASCENDING ORDER
            var brownDogsOlder3Ascending = Exercise.Dogs.Where(x => x.Color == "Brown" && x.Age >= 3).OrderBy(x => x.Age).ToList();
            foreach (var item in brownDogsOlder3Ascending)
            {
                Console.WriteLine($"The name of the dog is: {item.Name}, age {item.Age}, color: {item.Color}");
            }

            //Find and print all persons with more than 2 dogs, ordered by Name -DESCENDING ORDER
            var personsWith2OrMoreDogs = Exercise.Persons.Where(x => x.Dogs.Count >= 2).OrderByDescending(x => x.FirstName).ToList();
            foreach (var item in personsWith2OrMoreDogs)
            {
                Console.WriteLine($"Person: {item.FirstName} has {item.Dogs.Count()} Dogs");
            }

            //Find and print all Freddy`s dogs names older than 1 year
            var freddyDogsOlderThan1 = Exercise.Persons.First(x => x.FirstName == "Freddy")
                .Dogs.Where(x => x.Age > 1).ToList();
            //.Where(x => x.Dogs.Where(x => x.Age > 1).ToList().Count != 0).ToList();
            Console.WriteLine("Freddys Dogs older than 1 year are:");
            foreach (var item in freddyDogsOlderThan1)
            {
                Console.WriteLine(item.Name);
            }

            //Find and print Nathen`s first dog
            var nathansFirstDog = Exercise.Persons.FirstOrDefault(x => x.FirstName == "Nathen").Dogs[0];
            Console.WriteLine($"Nathans first dog is {nathansFirstDog.Name}");

            //Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name -ASCENDING ORDER
            var whiteDogs = Exercise.Persons
                .Where(x => x.FirstName == "Cristofer" || x.FirstName == "Freddy" || x.FirstName == "Erin" || x.FirstName == "Amelia")
                .Where(x => x.Dogs.Where(x => x.Color == "White").ToList().Count != 0).SelectMany(x => x.Dogs)
                .OrderBy(x => x.Name).ToList();
            Console.WriteLine("White dogs names: ");
            foreach (var item in whiteDogs)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
