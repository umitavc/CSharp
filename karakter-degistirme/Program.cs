

Console.Write("Bir string ifade girin: ");
string input = Console.ReadLine();

if (!string.IsNullOrEmpty(input) && input.Length >= 2)
{
    string firstChar = input.Substring(0, 1);
    string lastChar = input.Substring(input.Length - 1, 1);
    string middlePart = input.Substring(1, input.Length - 2);

    string output = lastChar + middlePart + firstChar;
    Console.WriteLine("Sonuç: " + output);
}
else
{
    Console.WriteLine("Geçersiz giriş! Lütfen en az 2 karakterden oluşan bir string girin.");
}
