using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SEDC.CSharpAdv.Class11.Exercise.Classes
{
    public class WriteAndRead
    {
        public void WritingOnFile(string path, string data)
        {
            using(StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(data);
                Console.WriteLine("Succesfully written on the file");
            }
        }

        public string ReadingFromFile(string path)
        {
            string result = string.Empty;
            if(!File.Exists(path))
            {
                throw new Exception("No file found");
            }
            using(StreamReader sr = new StreamReader(path))
            {
                result = sr.ReadToEnd();
                Console.WriteLine("Successfuly read a file!");
            }
            return result;
        }
    }
}
