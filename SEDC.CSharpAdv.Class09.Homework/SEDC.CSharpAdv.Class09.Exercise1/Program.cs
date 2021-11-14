using System;
using System.IO;

namespace SEDC.CSharpAdv.Class09.Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine($"The current directory is {currentDirectory}");
            string folderPath = currentDirectory + @"\Exercise\";
            string fileName = "calculator.txt";

            if(!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("The folder Exercise was created");
            }
            if(!File.Exists(folderPath + fileName))
            {
                File.Create(folderPath + fileName).Close();
                Console.WriteLine("The file calculator was created");
            }

            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());

            using (StreamWriter sw = new StreamWriter(folderPath + fileName, true))
            {
                Console.WriteLine(SumOfNumbers(num1, num2));
                sw.WriteLine(SumOfNumbers(num1, num2));
            }


        }

        static string SumOfNumbers(int n1, int n2)
        {
            return $"{n1} + {n2} = {n1 + n2}  Time: {DateTime.Now}";
        }
    }
}
