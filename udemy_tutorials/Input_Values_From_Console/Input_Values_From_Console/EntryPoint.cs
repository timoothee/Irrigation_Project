using System;
internal class EntryPoint
{
    static void Main()
    {
        // Name
        Console.WriteLine("What is your name?");
        string firstName = Console.ReadLine();
        Console.WriteLine(firstName);

        // Age
        Console.WriteLine("How old are you");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine(age);


    }
}