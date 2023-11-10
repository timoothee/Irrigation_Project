using System;

internal class EntryPoint
{
    static void Main()
    {
        // Primitive data types
        /*
        int mynumber = 5;
        Console.WriteLine(mynumber);

        string mystring = "Hello World";
        Console.WriteLine(mystring);

        char mychar = 'a';
        Console.WriteLine(mychar);

        bool mybool = true;
        Console.WriteLine(mybool);

        float myfloat = 3.14F;  // You need to add letter F at the end
        Console.WriteLine(myfloat);
        */

        // Data Values
        /*
        // int type holds 32bit numbers
        int myint = 5;
        Console.WriteLine("Integer Min and Max Values");
        Console.WriteLine(int.MinValue);
        Console.WriteLine(int.MaxValue);

        uint myuint = 1;
        Console.WriteLine("UInteger Min and Max Values");
        Console.WriteLine(uint.MinValue);
        Console.WriteLine(uint.MaxValue);

        // byte type holds 8bit numbers

        byte mybyte = 255;
        Console.WriteLine("Byte Min and Max Values");
        Console.WriteLine(byte.MinValue);
        Console.WriteLine(byte.MaxValue);

        sbyte my_neg_byte = -1; //signed byte range -128 -> 127
        Console.WriteLine("UByte Min and Max Values");
        Console.WriteLine(sbyte.MinValue);
        Console.WriteLine(sbyte.MaxValue);

        // long type holds 64bit numbers 

        long mylong = 12345678;
        Console.WriteLine("Long Min and Max Values");
        Console.WriteLine(long.MinValue);
        Console.WriteLine(long.MaxValue);

        ulong myulong = 0;
        Console.WriteLine("ULong Min and Max Values");
        Console.WriteLine(ulong.MinValue);
        Console.WriteLine(ulong.MaxValue);
        */

        // String 
        /*
        string string_1 = "C# Course";
        string string_2 = "for Begginers";
        string free_space = " ";

        Console.WriteLine(string_1);
        Console.WriteLine(string_2);

        // Concatenation

        Console.WriteLine(string_1 + free_space +string_2);
        Console.WriteLine("I am taking my first {0}{1}{2} and i am really happy", string_1, free_space, string_2);
        */

        // Arrays
        /*
        string myarray = "array";

        Console.WriteLine(myarray[4]);

        // First way on how to asigne values to an array.

        string[] my_string_array = new string[3];
        my_string_array[0] = "First Item";
        my_string_array[2] = "Third Item";

        my_string_array[0] = "Item 1";

        // Second way on how to asigne values to an array.

        string[] my_string_array_1 = {"Item 1", "Item 2"};
        Console.WriteLine(my_string_array_1[1]);
        Console.WriteLine(my_string_array_1.Length);

        // Integer array
        int[] my_int_array = new int[3];
        my_int_array[0] = 123;
        
        // same thing with other data types ..
        */

    }
}
