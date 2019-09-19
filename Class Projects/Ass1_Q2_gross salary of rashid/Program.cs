using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter total salary:");
        decimal total_salary = Convert.ToInt32(Console.ReadLine());
        decimal dearness_allowence = total_salary * 40 / 100;
        decimal rent_allownce = total_salary * 20 / 100;
        decimal gross_salary = total_salary + dearness_allowence + rent_allownce;
        Console.WriteLine("Dearness Allownce:" + dearness_allowence);
        Console.WriteLine("House rent Allownce:" + rent_allownce);
        Console.WriteLine("Gross Salary:" + gross_salary);
    }
}
