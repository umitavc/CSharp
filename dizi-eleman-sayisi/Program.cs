using System;

class Program
{
    static void Main(string[] args)
    {
        int[] sayilar = { 10, 15, 55, 36, 95, 86, 75 };
        int sayac = 0;
        
        Console.Write("Dizideki sayılar: ");
        
        for (int i = 0; i < sayilar.Length; i++)
        {
            Console.Write(sayilar[i]);
            
            if (i < sayilar.Length - 1)
            {
                Console.Write("-");
            }
            
            if (sayilar[i] < 50)
            {
                sayac++;
            }
        }
        
        Console.WriteLine("\nDizi içinde 50'den küçük {0} adet sayı bulunuyor.", sayac);
        Console.ReadKey();
    }
}
