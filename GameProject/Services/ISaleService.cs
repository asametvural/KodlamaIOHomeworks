using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ISaleService
    {
        void Sale(Game game, Gamer gamer);
        void CampaignSale(Game game, Gamer gamer, Campaign campaign);

    }
}
