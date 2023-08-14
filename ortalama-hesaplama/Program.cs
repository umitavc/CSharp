
class Program
{
    static void Main(string[] args)
    {
        Actions action =new Actions();
        System.Console.WriteLine("***************************************");
        System.Console.WriteLine("Bu Projede Kullanıcı Bir Derinlik değeri giricek\n"
                                +"Girilen değer deriniliğinde bir fibonacci serisi oluşturulucak\n"
                                +"fibonacci Serisindeki değerlerin ortalamasi alinir Ekrana yazdirilicaktir.");
        System.Console.Write("\n\n Fibonacci sayisinin değerlerini giriniz. (Tam sayi olabilir) : ");
        int derinlikref = int.Parse(Console.ReadLine());
        action.CreateFibonacci(derinlikref);
  
    }
}