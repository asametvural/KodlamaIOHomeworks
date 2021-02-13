using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SaleManager : ISaleService
    {
        public void CampaignSale(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(game.GameName + " oyununu " +campaign.CampaignDiscount+"% indirimle "+ gamer.FirstName + " oyuncusu aldı.");
        }

        public void Sale(Game game, Gamer gamer)
        {
            Console.WriteLine(game.GameName+" oyununu"+gamer.FirstName+" oyuncusu aldı.");
        }
    }
}
