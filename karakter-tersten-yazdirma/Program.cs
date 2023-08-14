using System;

namespace CharacterSwapApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();

            string output = SwapCharacters(input);

            Console.WriteLine("Output: " + output);
        }

        static string SwapCharacters(string input)
        {
            char[] charArray = input.ToCharArray();

            for (int i = 0; i < charArray.Length - 1; i += 2)
            {
                char temp = charArray[i];
                charArray[i] = charArray[i + 1];
                charArray[i + 1] = temp;
            }

            return new string(charArray);
        }
    }
}
