using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer {
                Id = 1,
                BirthYear = 1998,
                FirstName = "Samet",
                LastName = "Vural",
                IdentityNumber = 12345
            };
            Gamer gamer2 = new Gamer
            {
                Id = 2,
                BirthYear = 1997,
                FirstName = "Sezer",
                LastName = "Bozbıyık",
                IdentityNumber = 12345
            };

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer1);
            gamerManager.Add(gamer2);
            gamerManager.Add(gamer1);

            Game game1 = new Game { GameName="Counter Strike",GamePrice=150};
            Game game2 = new Game { GameName = "Pubg", GamePrice = 250 };

            Campaign campaign1 = new Campaign { CampaignId = 1, CampaignName = "Yaz", CampaignDiscount = 10 };
            Campaign campaign2 = new Campaign { CampaignId = 2, CampaignName = "Kış", CampaignDiscount = 5 };

            SaleManager saleManager = new SaleManager();
            saleManager.CampaignSale(game1, gamer2, campaign2);
        }
    }
}
