using System;
class Program
{
    static void Main()
    {
        int salary = Convert.ToInt32(Console.ReadLine());
        decimal dearness_allonce = 40 / 100 * salary;
        //double house_rent_allownce = 20 / 100*salary;
        int gross_salary = salary + (40 / 100 * salary) + (20 / 100 * salary);
        Console.WriteLine("Gross Salary="+dearness_allonce);
    }
}
