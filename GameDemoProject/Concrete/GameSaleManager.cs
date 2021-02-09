using GameDemoProject.Abstract;
using GameDemoProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject.Concrete
{
    class GameSaleManager : ISaleService
    { 
        public double _campaignPrice;
        public GameSaleManager(Game game,Campaign campaign)//constructor
        {
            _campaignPrice = (game.Price * campaign.DiscountRate) / 100;
        }

        public void Sale(Person person, Game game, Campaign campaign)
        {
            
            if (campaign !=null)
            {
                Console.WriteLine(person.FirstName +" "+game.Name+" adlı oyunu "+campaign.CampaignName+ " kampanyasıyla " +_campaignPrice+ " TL indirimle satın aldı");
            }
            else
            {
                Console.WriteLine(person.FirstName + " " + game.Name+ " adlı oyunu kampanyasız aldı");
            }
            
            
            
        }
    }
}
