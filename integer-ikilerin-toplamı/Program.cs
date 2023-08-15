using System;
using System.Collections.Generic;

Console.Write("Integer ikililerin sayısını girin (n): ");
int n = int.Parse(Console.ReadLine());

List<int> numbers = new List<int>();

for (int i = 0; i < n; i++)
{
    Console.Write($"[{i + 1}] İlk sayıyı girin: ");
    int firstNumber = int.Parse(Console.ReadLine());

    Console.Write($"[{i + 1}] İkinci sayıyı girin: ");
    int secondNumber = int.Parse(Console.ReadLine());

    int sum = firstNumber + secondNumber;

    if (firstNumber == secondNumber)
    {
        int square = sum * sum;
        Console.WriteLine($"Toplamın karesi: {square}");
    }
    else
    {
        Console.WriteLine($"Toplam: {sum}");
    }
}
