class DaireCizici
{
    private int yaricap;

    public DaireCizici(int yaricap)
    {
        this.yaricap = yaricap;
    }

    public void DaireyiCiz()
    {
        for (int i = -yaricap; i <= yaricap; i++)
        {
            for (int j = -yaricap; j <= yaricap; j++)
            {
                if (i * i + j * j <= yaricap * yaricap)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }
}