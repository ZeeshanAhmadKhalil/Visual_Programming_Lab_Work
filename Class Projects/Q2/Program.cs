using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int meters = distance * 1000;
            int cms=meters*100;
            double feet = meters * 3.28084;
            Console.WriteLine("Distance between Cities is {0} kms , {1} m , {2} cms",distance,meters,cms);
        }
    }
}
