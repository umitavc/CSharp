class Dikdörtgen
    {
        private double width;
        private double height;
        private double result;

        public void CalculateAndDisplay()
        {
            ReadInput();
            Calculate();
            DisplayResult();
        }

        private void ReadInput()
        {
            Console.Write("Dikdörtgenin genişliğini giriniz: ");
            width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Dikdörtgenin yüksekliğini giriniz: ");
            height = Convert.ToDouble(Console.ReadLine());
        }

        private void Calculate()
        {
            result = width * height;
        }

        private void DisplayResult()
        {
            Console.WriteLine($"Dikdörtgen alanı: {result}");
        }
    }