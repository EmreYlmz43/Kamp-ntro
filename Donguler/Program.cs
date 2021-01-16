using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç için Temel Kurs";
            string kurs3 = "Java";

            // aray [] - diziler - liste 

            string[] kurslar = new string[] { "yazılım Geliştirici Yetiştirme Kampı", 
                "Programlamaya Başlangıç için Temel Kurs", "Java","python" };
            // length === eleman sayısı
            for (int i = 0; i <kurslar.Length; i++) // i+=1 veya i+=2 şeklinde yazarak kacar kacar yukselecegını söyleriz.
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("sayfa sonu-for Bitti");

            foreach (string kurs in kurslar) // foreach dizileri tek tek dolaşmaya yarar for döngüsü yerine yapılabilir.
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu-footer");
     


            int caseSwitch = 1;
            switch (caseSwitch)
            {
            case 1:
               Console.WriteLine("Casse 1");
               break;
            case 2:
               Console.WriteLine("Casse 2");
               break;           
            default:
               Console.WriteLine("Varsayılan Sayı");
               break;


            }
    }
}
