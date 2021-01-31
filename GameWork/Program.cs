using System;

namespace GameWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n"+"--------------- MERNİS SİSTEMİNDEN OYUNCU EKLEME -------------"+"\n");

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                FirstName = "EMRE",
                LastName = "YILMAZ",
                IdentityNumber = 123456,
                BirthYear = 1994

            });
            gamerManager.Delete(new Gamer
            {
                Id = 2,
                FirstName = "BEDİRHAN",
                LastName = "YILMAZ",
                IdentityNumber = 1234567,
                BirthYear = 2018

            });
            Console.WriteLine("\n"+"--------------- OYUN SATIŞ YÖNETİMİ-------------"+"\n");
           
            SallerManager sallerManager = new SallerManager();
            sallerManager.Saller(new Gamer 
            {
                FirstName = "Emre", LastName = "Yılmaz" 
            },
            new Products
            { 
                ProductName="Call Of Duty"            
            });
            Console.WriteLine("\n"+"--------------- OYUN SATIŞ KAMPANYA YÖNETİMİ-------------"+"\n");
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Products
            {
                ProductName = "ASSASSINS CREED"
            },
            new Gamer
            {
                FirstName = "Bedirhan",
                LastName = "Yılmaz"
            },
            new Campaigns
            {
                CampaignName = "% 15 İndirim"

            });
            
            
            Console.WriteLine("Hello World!");
        }
    }
}
