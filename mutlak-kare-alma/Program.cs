
Console.Write("Sayıları aralarında boşluk bırakarak giriniz: ");
string input = Console.ReadLine();
string[] sayilar = input.Split(' ');

int kucukFarkToplami = 0;
int buyukMutlakKareToplami = 0;

foreach (string sayiString in sayilar)
{
    int sayi = Convert.ToInt32(sayiString);

    if (sayi < 67)
    {
        kucukFarkToplami += 67 - sayi;
    }
    else
    {
        int fark = sayi - 67;
        buyukMutlakKareToplami += fark * fark;
    }
}

Console.WriteLine($"Küçük olan sayıların farklarının toplamı: {kucukFarkToplami}");
Console.WriteLine($"Büyük olan sayıların mutlak karelerinin toplamı: {buyukMutlakKareToplami}");
