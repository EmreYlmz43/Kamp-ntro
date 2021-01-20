using System;
using System.Collections.Generic;
using System.Text;
 
namespace Metotlar
{
    class SepetManager
    {

        // public void = def (phytonda ki gibi)
        public void Ekle(Urun urun) // Parametre ekliyoruz.. bana hangi ürünü sepete ekleyeceğimi söyle...
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi !!! :" + urun.Adi);
        }

        public void Ekle2(string urunAdı, string urunAciklama, double Fiyati, int stokAdeti )
        {
            Console.WriteLine("Tebrikler Sepete Eklendi :" + urunAdi);
        }


    }
}
