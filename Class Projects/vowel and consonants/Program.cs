using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter an alphabet");
        char alphabet = Convert.ToChar(Console.Read());
        switch (alphabet)
        {
               case 'a':
                Console.WriteLine("vowel");
                break;
               case 'E':
                Console.WriteLine("vowel");
                break;
               case 'i':
                Console.WriteLine("vowel");
                break;
               case 'o':
                Console.WriteLine("vowel");
                break;
               case 'u':
                Console.WriteLine("vowel");
                break;
            default:
                Console.WriteLine("Consonent");
                break;

        }

    }
}