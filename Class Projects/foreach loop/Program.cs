using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter 5 Names");
        string[] names=new string[5];//array declaration in C#
        foreach (string name in names)
        {
            names[i] = Convert.ToString(Console.ReadLine());
        }
        //for (int i = 0; i < 5; i++)
        //{
        //    names[i] = Convert.ToString(Console.ReadLine());
        //}
        Console.WriteLine("The Names you entered are:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}
