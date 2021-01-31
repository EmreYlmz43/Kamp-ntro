using System;
using System.Collections.Generic;
using System.Text;

namespace GameWork
{
    class CampaignManager : ICampaignServise
    {
        public void Add(Products products, Gamer gamer, Campaigns campaigns)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " +
                products.ProductName +" "+ "ürününü" +" " + campaigns.CampaignName +" "+ "kamanyası ile satın aldı");
        }
    }
}
