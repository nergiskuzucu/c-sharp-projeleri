/*
Ortalama Hesaplama
Kulanıcıdan alınan derinliğe göre fibonacci serisindeki rakamların ortalamasını alıp ekrana yazdıran uygulamayı yazınız.

Dikkat Edilmesi Gereken Noktalar :

Kod tekrarından kaçınılmalı
Single Responsibility kuralına uygun şekilde, uygulama sınıflara ve metotlara bölünmeli.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrtalamaHesapla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci Hesaplama");
            Fibonacci fibo = new Fibonacci();

            fibo.FirstOp();

            Console.ReadLine();
        }
    }

    public class Fibonacci
    {
        public int n1 = 0, n2 = 1, n3,
                   x, top = 0, ort = 0;
        public void FirstOp()  // getting the length of serie from the user
        {
            Console.Write("Uzunlugu Girin : ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write(n1 + " " + n2 + " ");
            for (int i = 2; i < x; ++i)
            {
                n3 = n1 + n2;

                Console.Write(n3 + " ");

                n1 = n2;
                n2 = n3;
                top += x;
            }

            Console.WriteLine("\n");

            ort = top / x;
            Console.WriteLine($"The average: {ort}");

        }

    }
}
