using System;
class Program
{
    static void Main(string[] args)
    {
        string Car;
    label1:
        Console.Clear();
        Console.WriteLine("GREEN LIGHT");
        Console.Write("Is car coming on secondary road(yes/no):");
        Car = Convert.ToString(Console.ReadLine());
        if (Car == "yes")
        {
            Console.Clear();
            Console.WriteLine("RED LIGHT");
            int counter_second = 5;
            DateTime time = DateTime.Now;
            int previous_seconds = time.Second;
            while (true)
            {
                time = DateTime.Now;
                int seconds = time.Second;
                //Console.Clear();
                if (previous_seconds != seconds)
                {
                    Console.Clear();
                    Console.WriteLine("RED LIGHT");
                    previous_seconds = seconds;
                    Console.WriteLine("Counter Seconds=" + counter_second);
                    counter_second--;
                }
                if (counter_second == -1)
                    break;
            }
        }
        goto label1;
        
        

        
    }
}
