using System;
namespace Number_Format
{
    class Program
    {
        static void Main()
        {
            string number = String.Format("{0:n0}", 1101);
            int number1 = 1001;
            Console.WriteLine("The numbers are " + number + " and " + number1);
        }
    }
}
