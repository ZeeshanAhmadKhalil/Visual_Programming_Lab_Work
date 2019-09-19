

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any alphabet:");
            char ch = char.Parse(Console.ReadLine());
            switch (ch)
            {
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
                default:
                    Console.WriteLine("Consonant");
                    break;
            }

        }
    }
}