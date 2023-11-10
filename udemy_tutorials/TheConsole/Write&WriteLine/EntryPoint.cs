using System;
internal class EntryPoint
{
    static void Main()
    {

        // Write and WriteLine
        
        Console.Write("I am learning");
        Console.Write(" This is on the same row");
        Console.Write("\nThanks to the backslash n this is not on the same row");
        Console.WriteLine();

        Console.WriteLine("----");

        Console.WriteLine("I am learning");
        Console.WriteLine(" This is on the same row");
        Console.WriteLine("\nThanks to the backslash n this is not on the same row");
        Console.WriteLine();
        

        // String Formatting
        
        string fruit_1 = "Banana";
        string fruit_2 = "Strawberry";
        int my_num_1 = 5;
        int my_num_2 = 123;
        float my_pi = 3.1415926535897F;

        Console.WriteLine("{0} and {1}", fruit_1, fruit_2);
        Console.WriteLine();
        Console.WriteLine("{0, 15}", fruit_1);
        Console.WriteLine("{0, 5}", fruit_1);
        Console.WriteLine("{0, 10}", my_num_1);
        Console.WriteLine("{0, 10}", my_num_2);

        // Number formatting
        Console.WriteLine("{0, 10:C}", my_num_2);
        Console.WriteLine("{0, 10:C1}", my_num_2);
        Console.WriteLine("{0, 10:C0}", my_num_2);

        Console.WriteLine("{0, 10:C}", my_pi);
        Console.WriteLine("{0, 10:C6}", my_pi);
        Console.WriteLine("{0, 10:C3}", my_pi);
        
    }
}

