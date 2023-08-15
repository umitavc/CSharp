using System;

Console.Write("Input: ");
string input = Console.ReadLine();

string sessizHarfler = "bcçdfgğhjklmnprsştvyz"; // Türkçe sessiz harfler

Console.Write("Output: ");

for (int i = 0; i < input.Length - 1; i++)
{
    if (sessizHarfler.Contains(Char.ToLower(input[i])) && sessizHarfler.Contains(Char.ToLower(input[i + 1])))
    {
        Console.Write("True ");
    }
    else
    {
        Console.Write("False ");
    }
}

Console.WriteLine(); // Satır sonuna geç
