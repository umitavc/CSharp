using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();

            // '-' işaretlerini kaldır
            string cleanedInput = input.Replace("-", "");

            string[] parts = cleanedInput.Split(',');

            if (parts.Length != 2)
            {
                Console.WriteLine("Invalid input format.");
                return;
            }

            string text = parts[0];
            int index;

            if (!int.TryParse(parts[1], out index))
            {
                Console.WriteLine("Invalid index value.");
                return;
            }

            if (index < 0 || index >= text.Length)
            {
                Console.WriteLine("Index out of range.");
                return;
            }

            string result = text.Remove(index, 1);
            Console.WriteLine("Output: " + result);
        }
    }
}
