using System;
namespace _10_members_of_squence
{
    class Program
    {
        static void Main()
        {
            int positive_even = 2;
            int negative_odd = -3;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write(positive_even+" ");
                Console.Write(negative_odd+" ");
                positive_even += 2;
                negative_odd -= 2;
            }
            Console.WriteLine();
        }
    }
}
