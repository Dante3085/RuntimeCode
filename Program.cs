
using SomeShit;
using System.IO;

System.IO.Directory.SetCurrentDirectory("F:/Programmierung/Projekte/SomeShit");

Console.WriteLine(5);

var userInput = String.Empty;
while(userInput != "q")
{
    Console.Write(">>");
    userInput = Console.ReadLine();
    if (userInput == "q")
        break;

    var code = @"using System;
                namespace SomeShit
                {
                    class Program
                    {
                        static void Main(string[] args)
                        {" +
                           userInput +
                        @"}
                    }
                }";

    RuntimeCode.Run(code);
}