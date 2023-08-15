using System;
using System.IO;
using System.Collections.Generic;

namespace ATMUygulamasi
{
    class Program
    {
        static string kullaniciAdi = "kullanici";
        static string parola = "sifre";
        static decimal bakiye = 1000;

        static List<string> islemListesi = new List<string>
        {
            "1. Para Çekme",
            "2. Para Yatırma",
            "3. Ödeme Yapma",
            "4. Gün Sonu İşlemi",
            "5. Çıkış"
        };

        static void Main(string[] args)
        {
            GirisYap();

            bool devam = true;
            while (devam)
            {
                MenuGoster();

                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        ParaCek();
                        break;
                    case 2:
                        ParaYatir();
                        break;
                    case 3:
                        OdemeYap();
                        break;
                    case 4:
                        GunSonuIslemi();
                        break;
                    case 5:
                        devam = false;
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim.");
                        break;
                }
            }
        }

        static void GirisYap()
        {
            Console.Write("Kullanıcı Adı: ");
            string girilenKullaniciAdi = Console.ReadLine();

            Console.Write("Parola: ");
            string girilenParola = Console.ReadLine();

            if (girilenKullaniciAdi == kullaniciAdi && girilenParola == parola)
            {
                Console.WriteLine("Giriş başarılı. Hoş geldiniz!");
            }
            else
            {
                Console.WriteLine("Hatalı giriş. Program sonlandırılıyor.");
                Environment.Exit(0);
            }
        }

        static void MenuGoster()
        {
            Console.WriteLine("İşlem Seçenekleri:");
            foreach (string islem in islemListesi)
            {
                Console.WriteLine(islem);
            }
            Console.Write("Lütfen bir işlem seçin: ");
        }

        static void ParaCek()
        {
            Console.Write("Çekmek istediğiniz miktarı girin: ");
            decimal cekilenMiktar = Convert.ToDecimal(Console.ReadLine());

            if (cekilenMiktar <= bakiye)
            {
                bakiye -= cekilenMiktar;
                Console.WriteLine("Para çekme işlemi başarılı. Yeni bakiye: " + bakiye);
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye.");
            }
        }

        static void ParaYatir()
        {
            Console.Write("Yatırmak istediğiniz miktarı girin: ");
            decimal yatirilanMiktar = Convert.ToDecimal(Console.ReadLine());

            bakiye += yatirilanMiktar;
            Console.WriteLine("Para yatırma işlemi başarılı. Yeni bakiye: " + bakiye);
        }

        static void OdemeYap()
        {
            Console.WriteLine("Ödeme yapma işlemi seçildi.");
            
        }

        static void GunSonuIslemi()
        {
            Console.WriteLine("Gün sonu işlemi seçildi.");

            
            string loglar = "Transaction Logları:\n..."; 
            loglar += "\n\nHatalı Giriş Denemeleri:\n..."; 

          
            string dosyaAdi = DateTime.Now.ToString("ddMMyyyy") + ".txt";
            string dosyaYolu = Path.Combine(Directory.GetCurrentDirectory(), dosyaAdi);
            File.WriteAllText(dosyaYolu, loglar);

            Console.WriteLine("Gün sonu işlemi tamamlandı. Loglar dosyaya kaydedildi: " + dosyaYolu);
        }
    }
}
