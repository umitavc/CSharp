 class Circle
    {
        private double radius;
        private double result;

        public void CalculateAndDisplay()
        {
            ReadInput();
            Calculate();
            DisplayResult();
        }

        private void ReadInput()
        {
            Console.Write("Dairenin yarıçapını giriniz: ");
            radius = Convert.ToDouble(Console.ReadLine());
        }

        private void Calculate()
        {
            result = 2 * Math.PI * radius;
        }

        private void DisplayResult()
        {
            Console.WriteLine($"Daire çevresi: {result}");
        }
    }