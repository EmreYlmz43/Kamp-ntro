using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun_Ödevi
{
    class CustomerTcNoControlService
    {
        public CustomerTcNoControlService(Customer customer)
        {
            TcNoControl(customer);
        }
        public bool TcNoControl(Customer customer)
        {
            if (customer.CustomerFirstName == "Gürbüz" && customer.CustomerLastName == "Polat" && customer.BirthofYear == 1959 && customer.TcNo == "12345678900")
            {
                Console.WriteLine("Müşteri kimlik bilgileri doğrudur...");
                return true;
            }
            else
            {
                Console.WriteLine("Giriş Başarısız!!! Lütfen kimlik bilgilerinizi kontrol ediniz");
                return false;
            }
        }
    }
}
