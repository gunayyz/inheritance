using System;

namespace Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 4;
            Console.WriteLine(number.IsPrime());
            string word = "C# is an object-oriented programming language.";
            Console.WriteLine(word.CustomContains("are"));
            Console.WriteLine(word.CustomContains("c#"));
            Console.WriteLine(word.CustomContains("programming"));
        }
    }
}