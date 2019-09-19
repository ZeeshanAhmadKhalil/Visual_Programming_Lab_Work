#define my_comments
using System;
class Program
{
    static void Main()
    {
#if my_comments
        char character = 'a';
        Console.WriteLine("Code of {0} is {1}",character,(int)character);
        character = 'A';
        Console.WriteLine("Code of {0} is {1}", character, (int)character);
        character = 'B';
        Console.WriteLine("Code of {0} is {1}", character, (int)character);
#endif
        object variable = 5;// variable is identifier
        Console.WriteLine(variable);
        variable = "five";
        Console.WriteLine(variable);

    }
}
