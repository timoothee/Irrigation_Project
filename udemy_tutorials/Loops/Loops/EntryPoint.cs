using System;
class EntryPoint
{
    static void Main()
    {
        Console.WriteLine("0 1 2 3 4 5 6 7 8 9 10 11 12 ...");

        // Infite loop
        /*
        int number1 = int.Parse(Console.ReadLine());
        int endNumber = int.Parse(Console.ReadLine());

        while(number1 < endNumber)
        {
            Console.WriteLine(number1);
        }
        */

        // While loop
        int number1 = int.Parse(Console.ReadLine());
        int endNumber = int.Parse(Console.ReadLine());

        while (number1 <= endNumber)
        {
            Console.WriteLine(number1);
            number1++;
        }

        // For loop 

        // Increment
        for (int i = 1; i <= 10; i++)
        {
            if (i == 1)
            {
                Console.WriteLine("The for loop was executed {0} time ", i);
            }
            else
            {
                Console.WriteLine("The for loop was executed {0} times", i);
            }
        }

        //Decrement
        for (int i = 10; i >= 1; i--)
        {
            if (i == 1)
            {
                Console.WriteLine("The for loop was executed {0} time ", i);
            }
            else
            {
                Console.WriteLine("The for loop was executed {0} times", i);
            }
        }
    }
}

