using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2__03_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] massiv = { 1, 2, 3, 8, 5, 6, 7, 6, 7, 10, 1 };
            int eyni = 0;


            for (int i = 0; i < massiv.Length; i++)
            {
                for (int j = i + 1; j < massiv.Length; j++)
                {
                    if (massiv[i] == massiv[j])
                    {
                        eyni++;
                        Console.WriteLine(massiv[i]);
                        Console.WriteLine(massiv[i] + "=" + massiv[j]);
                       
                    }
                }
            }

            Console.WriteLine("Eyni ededlerin sayi : " + eyni);


            {

            }


        }


    }





}
 


