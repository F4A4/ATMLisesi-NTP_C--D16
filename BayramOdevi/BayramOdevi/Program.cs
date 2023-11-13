using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BayramOdevi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, sayi2;
            string metin = " ", metin2 = " ";
            Console.Write("Basamak sayısını girin:");
            sayi = Convert.ToInt32(Console.ReadLine());
            int[] m = new int[sayi];
            for (int e = 1; e <= sayi; e++) metin += " ";
            if (sayi == 1) Console.Write("{0} 1", metin);  
            if (sayi == 2) Console.Write("{0}1\n 1 1", metin);
            metin = " ";
            if (sayi > 2)
            {
                for (int e = sayi; e >= 0; e--) 
                metin2 += " ";
                Console.WriteLine("{0}1", metin2);
                metin2 = " ";
                for (int e = sayi; e >= 1; e--) 
                metin2 += " ";
                {
                    Console.WriteLine("{0}1 1", metin2);
                    metin2= " ";
                    m[0] = 1;
                    m[1] = 1;
                    for (int i = 2; i < sayi; i++)
                    {
                        int[] m1 = new int[i];
                        for (sayi2 = 1; sayi2 < i; sayi2++)
                        {
                            m1[sayi2] = m[sayi2] + m[sayi2 - 1];
                            metin = metin+ " " + m1[sayi2].ToString();
                        }
                        for (sayi2 = 1; sayi2 < i; sayi2++)
                        {
                            m[sayi2] = m1[sayi2];
                        }
                        m[i] = 1;
                        for (int e = sayi; e >= i; e--)
                        metin2 += " ";
                        Console.WriteLine("{1}1{0} 1", metin, metin2);
                        metin2 = " ";
                        metin = " ";
                    }
                    Console.ReadKey();
                }
            }
        }

        }
    }
       
   
