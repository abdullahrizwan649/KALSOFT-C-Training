using System;
using System.IO;


namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            string writeText = "AYO! CRIP";//creates a text string//
            File.WriteAllText("filename.txt", writeText); //creates a file and writes the contents of "writeText" string to it//


            string readText = File.ReadAllText("filename.txt");//reads contents of file//
            Console.WriteLine(readText);//outputs the file contents

        }
    }
}
