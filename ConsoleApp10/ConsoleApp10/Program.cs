using System;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[5];
            string[] hayvanlar = { "Lamalar", "Maymunlar", "Bal Porsukları" };
            int[] sayilar;
            sayilar = new int[10];


            renkler[0] = "Pembe";
            Console.WriteLine(hayvanlar[2]);
            sayilar[8] = 90909;
            Console.WriteLine(sayilar[8]);
            Console.WriteLine(renkler[0]);


            /////
            ///
            Console.WriteLine("Lütfen Dizinin Eleman Sayısınız Giriniz");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("Lütfen Sayı Giriniz", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;

            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
                Console.WriteLine("Ortalama"+toplam/diziUzunlugu);
            }
        }
    }
}
