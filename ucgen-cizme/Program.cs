using System;

namespace UcgenCizmeUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üçgen çizme uygulamasına hoş geldiniz!");
            Console.Write("Üçgenin boyutunu girin: ");
            int boyut = int.Parse(Console.ReadLine());

            UygulamaCalistirici uygulamaCalistirici = new UygulamaCalistirici();
            uygulamaCalistirici.Baslat(boyut);

            Console.WriteLine("Çıkış için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
