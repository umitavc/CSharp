using System;
using System.Collections.Generic;

Dictionary<string, int> categoryVotes = new Dictionary<string, int>();
Dictionary<string, string> users = new Dictionary<string, string>();

while (true)
{
    Console.WriteLine("Hoşgeldiniz!");
    Console.WriteLine("1. Oy Ver");
    Console.WriteLine("2. Sonuçları Görüntüle");
    Console.WriteLine("3. Çıkış");
    Console.Write("Seçiminizi yapın: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Vote();
            break;
        case "2":
            ShowResults();
            break;
        case "3":
            Console.WriteLine("Uygulama kapatılıyor...");
            return;
        default:
            Console.WriteLine("Geçersiz seçenek!");
            break;
    }
}

void Vote()
{
    Console.Write("Kullanıcı adınızı girin: ");
    string username = Console.ReadLine();

    if (!users.ContainsKey(username))
    {
        Console.WriteLine("Yeni kullanıcı kaydı oluşturuluyor...");
        users[username] = username;
    }

    Console.WriteLine("Mevcut kategoriler: Film, Tech Stack, Spor");
    Console.Write("Oy vermek istediğiniz kategori: ");
    string category = Console.ReadLine();

    if (!categoryVotes.ContainsKey(category))
    {
        categoryVotes[category] = 0;
    }

    categoryVotes[category]++;

    Console.WriteLine("Oyunuz başarıyla kaydedildi!");
}

void ShowResults()
{
    Console.WriteLine("Voting Sonuçları:");
    foreach (var category in categoryVotes)
    {
        Console.WriteLine($"{category.Key}: {category.Value} oy");
    }

    int totalVotes = 0;
    foreach (var votes in categoryVotes.Values)
    {
        totalVotes += votes;
    }

    Console.WriteLine($"Toplam oy sayısı: {totalVotes}");

    foreach (var category in categoryVotes)
    {
        double percentage = (double)category.Value / totalVotes * 100;
        Console.WriteLine($"{category.Key} oy yüzdesi: {percentage:F2}%");
    }
}
