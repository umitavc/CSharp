 class Square
    {
        private double side;
        private double result;

        public void CalculateAndDisplay()
        {
            ReadInput();
            Calculate();
            DisplayResult();
        }

        private void ReadInput()
        {
            Console.Write("Karenin kenar uzunluğunu giriniz: ");
            side = Convert.ToDouble(Console.ReadLine());
        }

        private void Calculate()
        {
            result = side * side;
        }

        private void DisplayResult()
        {
            Console.WriteLine($"Karenin alanı: {result}");
        }
    }