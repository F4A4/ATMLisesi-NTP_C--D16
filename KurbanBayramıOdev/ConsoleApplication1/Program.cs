using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sayi, Sayi2;  

            string aralık = "", aralık2 = "";

            Console.Write("Satır sayısını giriniz :");

            Sayi = Convert.ToInt32(Console.ReadLine());  

            int[] m = new int[Sayi];

            for (int g = 1; g <= Sayi; g++) aralık += " ";  

            if (Sayi == 1) Console.Write("{0} 1", aralık);

            if (Sayi == 2) Console.Write("{0}1\n 1 1", aralık);

            aralık = "";  

            if (Sayi > 2)
            {

                for (int g = Sayi; g >= 0; g--) aralık2 += " ";

                Console.WriteLine("{0}1", aralık2);

                aralık2 = "";  

                for (int g = Sayi; g >= 1; g--) aralık2 += " ";

                Console.WriteLine("{0}1 1", aralık2);

                aralık2 = "";

                m[0] = 1;  
                m[1] = 1;
                for (int i = 2; i < Sayi; i++)
                {  
                    int[] m1 = new int[i];

                    for (Sayi2 = 1; Sayi2 < i; Sayi2++)
                    {
                        m1[Sayi2] = m[Sayi2] + m[Sayi2 - 1];

                        aralık = aralık+ " " + m1[Sayi2].ToString();
                    }

                    for (Sayi2 = 1; Sayi2 < i; Sayi2++)
                    {  

                        m[Sayi2] = m1[Sayi2];

                    }

                    m[i] = 1;

                    for (int g = Sayi; g >= i; g--) aralık2 += " ";

                    Console.WriteLine("{1}1{0} 1", aralık, aralık2);

                    aralık2 = "";

                    aralık = "";  
                }

            }

            Console.ReadKey(); 
        }
    }
}
