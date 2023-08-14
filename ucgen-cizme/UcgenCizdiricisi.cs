using System;

namespace UcgenCizmeUygulamasi
{
    class UcgenCizdirici
    {
        public void UcgenCiz(int boyut)
        {
            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
