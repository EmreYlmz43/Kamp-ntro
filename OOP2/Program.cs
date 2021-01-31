using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // soyutlamayı çok iyi anlamak lazım...
            GercekMüsteri müsteri1 = new GercekMüsteri();
            müsteri1.Id = 1;
            müsteri1.MusteriNo = "123456";
            müsteri1.Adı = "Emre";
            müsteri1.Soyadı = "Yılmaz";
            müsteri1.TcNo = "1234567890";

            TüzelMüsteri müsteri2 = new TüzelMüsteri();
            müsteri2.Id = 2;
            müsteri2.MusteriNo = "56465485";
            müsteri2.SirketAdi = "Kodlama.io";
            müsteri2.VergiNo = "1231535132";
            

            Müsteri müsteri3 = new GercekMüsteri();
            Müsteri müsteri4 = new TüzelMüsteri();


            MüsteriManager müsteriManager = new MüsteriManager();
            müsteriManager.Ekle(müsteri1);
           

            



          
            

        }
    }
}
