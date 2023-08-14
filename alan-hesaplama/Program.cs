using System;

namespace GeometricCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geometrik Şekil Hesaplama Uygulamasına Hoş Geldiniz!");

            while (true)
            {
                Console.WriteLine("Hangi geometrik şekli hesaplamak istersiniz? (Daire, Üçgen, Kare, Dikdörtgen):");
                string shape = Console.ReadLine().ToLower();

                IShapeCalculator calculator;

                if (shape == "daire")
                    calculator = new CircleCalculator();
                else if (shape == "üçgen")
                    calculator = new TriangleCalculator();
                else if (shape == "kare")
                    calculator = new SquareCalculator();
                else if (shape == "dikdörtgen")
                    calculator = new RectangleCalculator();
                else
                {
                    Console.WriteLine("Geçersiz bir şekil girdiniz.");
                    continue;
                }

                calculator.CalculateAndDisplayResult();

                Console.WriteLine("Başka bir hesaplama yapmak istiyor musunuz? (evet/hayır):");
                string continueInput = Console.ReadLine().ToLower();
                if (continueInput != "evet")
                    break;
            }

            Console.WriteLine("Hesaplama uygulaması kapatılıyor. İyi günler!");
        }
    }

    interface IShapeCalculator
    {
        void CalculateAndDisplayResult();
    }

    class CircleCalculator : IShapeCalculator
    {
        public void CalculateAndDisplayResult()
        {
            Circle circle = new Circle();
            circle.CalculateAndDisplay();
        }
    }

    class TriangleCalculator : IShapeCalculator
    {
        public void CalculateAndDisplayResult()
        {
            Triangle triangle = new Triangle();
            triangle.CalculateAndDisplay();
        }
    }

    class SquareCalculator : IShapeCalculator
    {
        public void CalculateAndDisplayResult()
        {
            Square square = new Square();
            square.CalculateAndDisplay();
        }
    }

    class RectangleCalculator : IShapeCalculator
    {
        public void CalculateAndDisplayResult()
        {
            Dikdörtgen rectangle = new Dikdörtgen();
            rectangle.CalculateAndDisplay();
        }
    }

}
