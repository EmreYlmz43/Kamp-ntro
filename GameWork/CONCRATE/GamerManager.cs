using System;
using System.Collections.Generic;
using System.Text;

namespace GameWork
{
    // Artık hiçbir sınıf çıplak bırakılmayacak bu yüzaden operasyonlardan önce interface oluşturulacak
    class GamerManager : IGamerService
    {
        // mernis kontrolü için ;

        // bu constractor ben gamerManager in içerisinde bir kullanıcı doğrulama servisi kullanacağım (soyut fake yapı)
        IUserValidation _userValidation;

        public GamerManager(IUserValidation userValidation)
        {
            _userValidation = userValidation;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidation.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt Oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız, Kayıt Başarısız");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi"+":"+gamer.FirstName+" "+gamer.LastName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }
    }
}
