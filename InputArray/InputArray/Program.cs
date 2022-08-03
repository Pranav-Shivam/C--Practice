using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InputArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of Array : ");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[l];
            Console.WriteLine("Enter the array Elements");
            for (int i = 0; i < l; i++)
            {
                Console.Write("Enter a element : ");
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nDisplay the array Elements");
             for (int i = 0; i < l; i++)
            {
                Console.Write(ar[i] + "\t");
            }
             for (int i = 0; i < l; i++)
             {
                 for (int j = 0; j < l - i - 1 ; j++)
                 {
                     if (ar[j] > ar[j+1])
                     {
                         int t = ar[j];
                         ar[j] = ar[j+1];
                         ar[j+1] = t;
                     }
                 }
             }
             Console.WriteLine("\nDisplay the array Elements After Sorting");
             for (int i = 0; i < l; i++)
             {
                 Console.Write(ar[i] + "\t");
             }

                 Console.ReadLine();
        }
    }
}
