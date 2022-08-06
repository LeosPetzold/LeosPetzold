// Voting system

using System;
using System.IO;

namespace votingsystem
{

    class Program
    {
    
        static void Main(string[] args)
        {
            WriteText("../text.txt", "Hello, world!!");
            WriteText("../text.txt", "Hello, world 2!!");

            Console.WriteLine(ReadText("../text.txt"));
        }

        public static void WriteText(string path, string text)
        {
            File.WriteAllText(path, Text);
        }

        public static void ReadText(path)
        {
            string path = "C:\\CS-Files\\file.txt";
            string readText = File.ReadAllText(path);
            return readText;
        }
    }
}
