using System;
using System.Collections.Generic;
using System.Text;

namespace WorldOfGamers
{
    class CampaignManager
    {
        
        public void List(Campaign[] campaigns)
        {
            Console.WriteLine("------CAMPAIGNS-------");
            foreach (Campaign campaign in campaigns)
            {
                Console.WriteLine(campaign.Name);
                Console.WriteLine("-----------------");

            }

        }
        public void Apply(Game game, Campaign campaign)
        {
            Console.WriteLine(campaign.Name);
            Console.WriteLine(campaign.DiscountRate+" percent discount applied to the " +game.GameName);
        }
        public void Add(Campaign campaign)
        {
            Console.WriteLine("New campaign is successfully added.");
        }
        public void Dell(Campaign campaign)
        {
            Console.WriteLine(campaign.Name+" is deleted.");
        }
        public void Upgrade(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " is upgraded.");
        }


    }
}
