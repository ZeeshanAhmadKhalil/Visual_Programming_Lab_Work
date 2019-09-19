using System;
namespace inputting_age_and_add_10_years
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter Your age:");
            int age=Convert.ToInt32(Console.ReadLine());
            DateTime time = DateTime.Now;
            Console.WriteLine(time.Year + ":Your age is " + age);
            Console.WriteLine(time.Year +10+ ":Your age is " + (age+10));
        }
    }
}
