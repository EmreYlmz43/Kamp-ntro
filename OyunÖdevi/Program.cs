using System;

namespace OyunÖdevi
{
    class Program
    {
        static void Main(string[] args)
        {
            Players player1 = new Players();
            player1.FirstName = "Emre";
            player1.LastName = "YILMAZ";
            player1.YearOfBirth = 1994;
            player1.NationalityId = "1234567890";

            Players player2 = new Players();
            player2.FirstName = "Bedirhan";
            player2.LastName = "YILMAZ";
            player2.YearOfBirth = 2018;
            player2.NationalityId = "10987654321";

            Players player3 = new Players();
            player3.FirstName = "Engin";
            player3.LastName = "DEMİROĞ";
            player3.YearOfBirth = 1985;
            player3.NationalityId = "24681012140";

            Product product1 = new Product();
            product1.ProductName = "CS Go";
            product1.ProductPrice = 150;

            Product product2 = new Product();
            product2.ProductName = "ASSASİNS CREED: ORİGİNALS";
            product2.ProductPrice = 200;

            Product product3 = new Product();
            product3.ProductName = "VALLORANT";
            product3.ProductPrice = 250;




            Console.WriteLine("---------OYUNCULARI KAYDETME,GÜNCELLEME,SİLME SİMÜLASYONU-------");

            PlayersManager playersManager = new PlayersManager();
            playersManager.Save(player2);
            playersManager.Delete(player1);
            playersManager.Update(player3);

            Console.WriteLine("---------OYUNCULARA SATIŞ YAPMA OTOMASYONU-------");
            


            ProductManager[] productManager = new ProductManager[4]
            {
                new Players {FirstName = "Engin"},
                new Players {LastName = "DEMİROĞ"},
                new Product {ProductName = "CS Go"},
                new Product {ProductPrice= }
            };

            foreach (var sales in productManager)
            {
                Console.WriteLine(sales.FirstName );
            }
            Console.ReadLine();




        }
    }
    class Players: ProductManager
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
    class PlayersManager
    {
        public void Save(Players players)
        { 
            Console.WriteLine(players.FirstName +" "+ players.LastName + ":" +"İsimli Oyuncu Sisteme Başarıyla KAYDEDİLDİ !!!");
        }

        public void Update(Players players)
        {
            Console.WriteLine(players.FirstName +" "+ players.LastName+ ":"+ "İsimli Oyuncunun Sistem Ayarları Başarıyla GÜNCELLENDİ !!!");
        }
        public void Delete(Players players)
        {
            Console.WriteLine(players.FirstName +" "+ players.LastName +":" + "İsimli Oyuncu Sistemden Başarıyla SİLİNDİ !!!");
        }
    }

    class Product:ProductManager
    {
       
    }

    class ProductManager

    {
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
  
}
