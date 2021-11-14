using SEDC.CSharpAdv.Class11.Exercise.Classes;
using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace SEDC.CSharpAdv.Class11.Exercise
{
    class Program
    {
        static string folderPath = @"..\..\..\OurFile";
        static string filePath = folderPath + @"\OurJson.json";
        static WriteAndRead writeAndRead = new WriteAndRead();
        static void Main(string[] args)
        {
            if(!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(filePath);
            }

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            //List<Dog> dogs = new List<Dog>();
            List<Dog> dogs = JsonConvert.DeserializeObject<List<Dog>>(writeAndRead.ReadingFromFile(filePath));
            while (true)
            {
                if (!ToAddMoreDogs())
                {
                    break;
                }
                Console.WriteLine("Enter dog name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter dog age");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter dog color");
                string color = Console.ReadLine();
                Dog dog1 = new Dog(name, age, color);
                dogs.Add(dog1);
                Console.WriteLine("Dog added succesfully to list");
            }

            
            SerializationAndWritingOnFile(dogs);
            Console.WriteLine("THE FOLLOWING DOGS ARE IN THE FILE: ");
            Console.WriteLine(writeAndRead.ReadingFromFile(filePath)); 


        }

        static void SerializationAndWritingOnFile(List<Dog> dogs)
        {
            string dog1Serialize = JsonConvert.SerializeObject(dogs);
            Console.WriteLine("Serialization ");
            Console.WriteLine(dog1Serialize);
            writeAndRead.WritingOnFile(filePath, dog1Serialize);
        }

        static bool ToAddMoreDogs()
        {
            while (true)
            {

                Console.WriteLine("Do you want to add an dog to the list y or n");
                string answer = Console.ReadLine();
                if (answer == "n")
                {
                    return false;
                }
                else if(answer == "y")
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Enter valid input");
                }
            }

        }
        
    }
}
