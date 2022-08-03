using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwoDimensionArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int l, b,k=0;
            int t = 0;
            int sumd1 = 0, sumd2 = 0;
            Console.WriteLine("Enter the size of array : ");
            l = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            int[,] ar=new int[l,b];
            int x=l*b;
            int[] a=new int[x];
            Console.WriteLine("Enter the array elements : ");
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write("Enter a elements : ");
                    ar[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //copy the 2d array into 1d array
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    
                    a[k]=ar[i,j];
                    k++;
                }
            }
            Console.WriteLine("\nDisplay the array elements : ");
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(ar[i,j]+"\t");
                }
                Console.WriteLine();
            }
            //sorting the array by bubble sort 
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int te = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = te;
                    }
                }
            }
            //copy the 1d -2d
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < b; j++)
                {

                    ar[i, j]=a[t];
                    t++;
                }
            }
            Console.WriteLine("\nDisplay the array elements After Sorting : ");
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(ar[i, j] + "\t");
                }
                Console.WriteLine();
            }
            //Sum of both daigonal
            if (l == b)
            {
                for (int i = 0; i < l; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        if (i == j)
                        {
                            sumd1 += ar[i, j];
                        }
                    }

                }
                int s = 0;
                for (int i = 0; i < l; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        if (j == i)
                        {
                            s = l - i - 1;
                            sumd2 += ar[s, j];
                        }
                    }
                }
                Console.WriteLine("\nSum of right daigonal" + sumd1);
                Console.WriteLine("\nSum of left daigonal" + sumd2);
            }
            else
                Console.WriteLine("\nDaigonal are not possible");

                Console.ReadLine();
        }
    }
}
