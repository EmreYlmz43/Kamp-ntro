using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            //Başvuran bilgilerini degerlendirme
            
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            // bu durumda hesaplama sadece konut kredısıne bağlı olarak çalışır 
            krediManager.Hesapla();
            loggerService.Log();
            //Method İnjection (Logger)
            // böylece tüm kredileri hesaplar...
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

       
    }
}
