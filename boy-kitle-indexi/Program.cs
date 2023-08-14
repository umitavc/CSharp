

double boy, kilo, bki;
Console.Write("Boy Giriniz:");
boy = double.Parse(Console.ReadLine());

Console.Write("Kilo Giriniz:");
kilo = double.Parse(Console.ReadLine());
// kilo = Convert.ToDouble( Console.ReadLine());

bki = kilo / (boy * boy);
Console.WriteLine("Boy= {0}, Kilo={1}, Boy Kitle İndeksi={2}", boy, kilo, bki);

if (bki <= 18.4)
    Console.WriteLine("Zayıf");

else if (bki >= 18.5 && bki <= 24.9)
    Console.WriteLine("Normal");

else if (bki >= 25 && bki <= 29.9)
    Console.WriteLine("Fazla Kilolu");

else if (bki >= 30 && bki <= 34.9)
    Console.WriteLine("Şişman (1.Sınıf)");

else if (bki >= 35 && bki <= 44.9)
    Console.WriteLine("Şişman (2.Sınıf)");

else if (bki >= 45)
    Console.WriteLine("Aşırı Şişman");
