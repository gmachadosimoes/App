using System;

namespace VarAttr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variable attribution project");

            int age = 34;
            age = 36;
            int ageOfGabriel = age;

            Console.WriteLine(age);
            Console.WriteLine(ageOfGabriel);

            Console.ReadLine();
        }
    }
}