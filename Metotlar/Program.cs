using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyatı = 15;
            string aciklama = "Amasya Elması";

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Kapuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine("\n" + "Adı:" + urun.Adi + "\n" + "Fiyatı:" + urun.Fiyati + "\n" + "Açıklama:"+urun.Aciklama + "\n");
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);               
            }

            Console.WriteLine("----------------Metotlar---------------");
            //encapsulation== classta ekleme yaparsan sayfalar patlamaz.... == kapsülleme anlamı taşır..
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,20);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 20,50);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 80,50);

            Console.WriteLine("Hello World!");
        }
    }
}
