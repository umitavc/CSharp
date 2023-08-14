

double miktarTL, miktarUSD, miktarEUR;
double dolarkuru, avrokuru;
double toplam;

Console.Write("Dolar kurunu giriniz:");
dolarkuru = double.Parse(Console.ReadLine());

Console.Write("Avro kurunu giriniz:");
avrokuru = double.Parse(Console.ReadLine());

Console.Write("Türk Lirası(TL) miktarını giriniz:");
miktarTL = double.Parse(Console.ReadLine());

Console.Write("Dolar(USD) miktarını giriniz:");
miktarUSD = double.Parse(Console.ReadLine());

Console.Write("Avro(EUR) miktarını giriniz:");
miktarEUR = double.Parse(Console.ReadLine());

toplam = miktarUSD * dolarkuru + miktarEUR * avrokuru + miktarTL;
Console.WriteLine("{0} kadar TL'niz var.", toplam);
