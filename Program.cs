using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // arrays

            string[] renkler = new string[5];
            string[] hayvanlar = {"kedi","kopek","fil","aslan"};
            int[] dizi;
            dizi = new int[5];

            // array definition

            renkler[0] = "mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[0]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            // using arrays with loops
            // The program that calculate to avareage of n numbers which reading from keyboard

            Console.WriteLine("Lütfen dizin eleman sayısını giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz: ",i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam=0;
            foreach (var sayi in sayiDizisi)
            {
                toplam +=sayi; 
            }
            Console.WriteLine("Ortalama: "+(toplam/diziUzunlugu));

            
        }
    }
}
