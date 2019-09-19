using System;
class Program
{
    static void Main()
    {
        Console.Write("How many days Member is late:");
        int days_late = Convert.ToInt32(Console.ReadLine());
        if (days_late < 5)
            Console.WriteLine("No fine");
        else if (days_late == 5)
            Console.WriteLine("Fine is 50 paises");
        else if (days_late >= 6 && days_late <= 10)
            Console.WriteLine("Fine is 1 Rupee");
        else if (days_late >10 && days_late <30)
            Console.WriteLine("Fine is 5 Rupee");
        else if (days_late >= 30)
            Console.WriteLine("Your Membership is cancelled");
    }
}

