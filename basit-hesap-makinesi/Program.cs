﻿
 
int sayi1,sayi2;
char opt;
double sonuc;
 
 
Console.WriteLine("\n\tMenu");
Console.WriteLine("\nTOPLAMA İÇİN + TUŞUNA BASIN");
Console.WriteLine("ÇIKARMA İÇİN - TUŞUNA BASIN");
Console.WriteLine("ÇARPMA İÇİN * TUŞUNA BASIN");
Console.WriteLine("BÖLME İÇİN + TUŞUNA BASIN");
 
Console.Write("\n\n Birinci Sayıyı Girin :");
sayi1 = Convert.ToInt32(Console.ReadLine());
 
Console.Write(" İkinci Sayıyı Girin :");
sayi2 = Convert.ToInt32(Console.ReadLine());
 
Console.Write("\nİŞLEM YAPMAK İÇİN BİR OPERATÖR SEÇİN:\t");
opt = Convert.ToChar(Console.ReadLine());
 
if (opt == '+')
{
sonuc = sayi1 + sayi2;
Console.WriteLine("\n{0} + {1} = {2}", sayi1, sayi2, sonuc);
}
else if (opt == '-')
{
sonuc = sayi1 - sayi2;
Console.WriteLine("\n{0} - {1} = {2}", sayi1, sayi2, sonuc);
}
else if (opt == '*')
{
sonuc = sayi1 * sayi2;
Console.WriteLine("\n{0} x {1} = {2}", sayi1, sayi2, sonuc);
}
else if (opt == '/')
{
sonuc =(double) sayi1 / sayi2;
Console.WriteLine("\n{0} / {1} = {2}", sayi1, sayi2, sonuc);
}
else
{
Console.WriteLine("ÜZGÜNÜN YANLIŞ BİR OPERATÖR GİRDİNİZ!");
}
 
 
Console.ReadKey();