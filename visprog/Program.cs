using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1
{
    public class HW1
    {

        public static long QueueTime(int[] customers, int n)
        {
            int[] a = new int[n];
            int k, time = 0, i;
            
            for ( k = 0; k < n; k++)
            {
                a[k] = customers[k];
            }
            while (k < n || a.Any(c => c > 0))
            {
                for (i = 0; i < n; i++)
                {
                    a[i] -= 1;
                    if (a[i] == 0 && k < customers.Length)
                        a[i] = customers[k++];
                   // time++;
                }
                time++;
            }
   
            return time;
        }
    }

    public class Programm
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(HW1.QueueTime(new int[] { 5, 3, 4 }, 1));
            Console.WriteLine(HW1.QueueTime(new int[] { 10, 2, 3, 3 }, 2));
            Console.WriteLine(HW1.QueueTime(new int[] { 2, 3, 10 }, 2));
        }
    }
}