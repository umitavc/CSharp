class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Dairenin yarıçapını girin: ");
            int yaricap = Convert.ToInt32(Console.ReadLine());

            if (yaricap <= 0)
            {
                Console.WriteLine("Yarıçap pozitif bir değer olmalıdır.");
                return;
            }

            DaireCizici daireCizici = new DaireCizici(yaricap);
            daireCizici.DaireyiCiz();
        }
        catch (FormatException)
        {
            Console.WriteLine("Geçerli bir sayı girmediniz.");
        }
    }
}