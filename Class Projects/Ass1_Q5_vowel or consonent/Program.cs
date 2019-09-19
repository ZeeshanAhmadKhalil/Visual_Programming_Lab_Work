using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter an alphabet:");
        char alphabet = Convert.ToChar(Console.Read());
        switch (alphabet)
        {
            case 'A':
                Console.WriteLine("vowel");
                break;
            case 'E':
                Console.WriteLine("vowel");
                break;
            case 'I':
                Console.WriteLine("vowel");
                break;
            case 'O':
                Console.WriteLine("vowel");
                break;
            case 'U':
                Console.WriteLine("vowel");
                break;
            case 'a':
                Console.WriteLine("vowel");
                break;
            case 'e':
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