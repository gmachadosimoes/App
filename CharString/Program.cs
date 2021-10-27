using System;

namespace CharString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Working with Characters and Strings");

            // Single characters with single quotes only!
            char firstLetter = 'a';
            firstLetter = (char)65;
            
            

            Console.WriteLine(firstLetter);
            Console.WriteLine(firstLetter);

            // String of characters with double quotes only!
            string name = "Gabriel";
            string phrase = "These are my first steps with C#";
            string multipleLines = 
@" - .NET
 - Java
 - C++";
            
            Console.WriteLine(name);
            Console.WriteLine(phrase);
            Console.WriteLine(multipleLines);
            Console.ReadLine();
        }
    }
}
