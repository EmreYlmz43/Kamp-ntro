using System;
using System.Collections.Generic;
using System.Text;

namespace GameWork
{
    class SallerManager : ISallerServise
    {
        public void Saller(Gamer gamer, Products products)
        {
            Console.WriteLine(gamer.FirstName +" " +gamer.LastName+" "+ products.ProductName +" "+ "isimli oyunu satın aldı !");
        }
    }
}
