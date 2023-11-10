using System;

class EntryPoint
{
    static void Main()
    {
        int number_1 = 20;
        int number_2 = 7;

        int addition = number_1 + number_2;                         // +
        int substraction = number_1 - number_2;                     // -
        int multiplication = number_1 * number_2;                   // *
        int division_int = number_1 / number_2;                     // /
        double division_double = number_1 / number_2;
        double division_double_cast = (double)number_1 / (double)number_2;

        Console.WriteLine("The result of the addition is {0}", addition);
        Console.WriteLine("The result of the substraction is {0}", substraction);
        Console.WriteLine("The result of the multiplication is {0}", multiplication);
        Console.WriteLine("The result of the division is {0}", division_int);
        Console.WriteLine("The result of the division is {0}", division_double);
        Console.WriteLine("The result of the division is {0}", division_double_cast);

        number_1++;                                                 // ++
        Console.WriteLine("The first number is being plus-plus-ed {0}", number_1);

        number_1--;                                                 // --
        number_1--;
        number_1--;
        number_1--;
        Console.WriteLine("The first number is being minus-minus-ed {0}", number_1);

        int remainder_div = number_1 % number_2;                    // %
        Console.WriteLine("Division with remainder {0}", remainder_div);
    }
}
