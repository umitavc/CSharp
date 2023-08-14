class Triangle
    {
         private double side1;
        private double side2;
        private double side3;
        private double result;

        public void CalculateAndDisplay()
        {
            ReadInput();
            Calculate();
            DisplayResult();
        }

        private void ReadInput()
        {
            Console.Write("Üçgenin 1. kenarını giriniz: ");
            side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Üçgenin 2. kenarını giriniz: ");
            side2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Üçgenin 3. kenarını giriniz: ");
            side3 = Convert.ToDouble(Console.ReadLine());
        }

        private void Calculate()
        {
            double s = (side1 + side2 + side3) / 2;
            result = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }

        private void DisplayResult()
        {
            Console.WriteLine($"Üçgen alanı: {result}");
        }
    }