using System;
class Program
{
    static void Main()
    {
        int host1=0; 
        int host2=0;
        int host3=0;
        int hosts=0;
        for (host1=0; host1 <=255; host1++)
        {
            for (host2=0; host2 <=255; host2++)
            {
                for (host3 = 0; host3 <= 255; host3++)
                {
                    //Console.WriteLine("Here");
                    //Console.WriteLine(hosts + " " + host1 + "." + host2 + "." + host3);
                    if (hosts != 16769024)
                        hosts++;
                    else
                        goto end_it;
                }
            }
        }
    end_it:
    if (host1 > 0)
        host1--;
    if (host2 > 0)
        host2--;
    if (host3 > 0)
        host3--;
        Console.WriteLine("IP Address=122.{0}.{1}.{2}", host1,host2,host3);
        Console.WriteLine("Total Hosts=" + hosts);

    }
}
