using System;

internal class EntryPoint
{
    static void Main()
    {
        // Logical Operators

        Console.WriteLine("{0} -- Should return false", true && false);     // &&
        Console.WriteLine("{0} -- Should return true", true || false);      // ||
        Console.WriteLine("{0} -- Should return true", true ^ false);       // ^
        Console.WriteLine("{0} -- Should return false", !true);             // !

        Console.WriteLine("{0} -- Should return false", ((true || false) && false));
        Console.WriteLine("{0} -- Should return true", ((true || false) && (false ^ true)));

        // If condition 
        if (4 < 5)
        {
            Console.WriteLine("4 is smaller than 5");
        }

        // First example

        Console.WriteLine("Please input your first number");
        int number_1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Please input your second number");
        int number_2 = int.Parse(Console.ReadLine());

        if (number_1 < number_2)
        { Console.WriteLine("The number {0} is smaller than {1}", number_1, number_2); }

        else
        { Console.WriteLine("The number {1} is smaller than {0}", number_1, number_2); }

        // Second example
        Console.WriteLine("Please input your first number");
        number_1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Please input your second number");
        number_2 = int.Parse(Console.ReadLine());

        if (number_1 < number_2 && number_1 == 5)
        { Console.WriteLine("The number {0} is smaller than {1}", number_1, number_2); }

        else if (number_1 > number_2)
        { Console.WriteLine("The number {1} is smaller than {0}", number_1, number_2); }

        else
        { Console.WriteLine("The number {0} is smaller than {1} but number 1 isn't 5", number_1, number_2); }

        // Third example

        if (number_1 % 2 == 0 && number_1 % 3 == 0 && number_1 % 5 == 0)
        {
            Console.WriteLine("The number {0} is divisible both by 2, 3 and 5 without remainder.", number_1);
        }
        else
        {
            Console.WriteLine("The number {0} is NOT divisible both by 2, 3 and 5 without remainder.", number_1);
        }

        // else if

        // Example 1
        Console.WriteLine("Please input your first number");
        number_1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Please input your second number");
        number_2 = int.Parse(Console.ReadLine());

        if (number_1 < number_2)
        { Console.WriteLine("The number {0} is smaller than {1}", number_1, number_2); }

        else if (number_1 == number_2)
        { Console.WriteLine("The numbers are equal !!"); }

        else
        { Console.WriteLine("The number {0} is smaller than {1} but number 1 isn't 5", number_1, number_2); }

        // Example 2
        Console.WriteLine("Please input your first number");
        number_1 = int.Parse(Console.ReadLine());
        if (number_1 == 1)
        {
            Console.WriteLine("one");
        }
        else if (number_1 == 1)
        {
            Console.WriteLine("two");
        }
        else if (number_1 == 1)
        {
            Console.WriteLine("three");
        }
        else if (number_1 == 1)
        {
            Console.WriteLine("four");
        }
        else if (number_1 == 1)
        {
            Console.WriteLine("five");
        }
        else if (number_1 == 1)
        {
            Console.WriteLine("six");
        }
        else if (number_1 == 1)
        {
            Console.WriteLine("seven");
        }
        else if (number_1 == 1)
        {
            Console.WriteLine("eight");
        }
        else if (number_1 == 0)
        {
            Console.WriteLine("zero");
        }
        else
        { Console.WriteLine("The number is bigger than 9, is {0}", number_1); }
    }
}