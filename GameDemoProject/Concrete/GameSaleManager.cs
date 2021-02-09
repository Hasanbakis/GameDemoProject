using GameDemoProject.Abstract;
using GameDemoProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject.Concrete
{
    class GameSaleManager : ISaleService
    {

        UserValidationManager _userValidationManager;
        public GameSaleManager(UserValidationManager userValidationManager)//Constructor
        {
            _userValidationManager = userValidationManager;

        }
        public double _campaignPrice;
        public GameSaleManager(Game game,Campaign campign, UserValidationManager userValidationManager)//constructor
        {
            _campaignPrice = (game.Price * campign.DiscountRate) / 100;
        }

        public void Sale(Person person, Game game, Campaign campign)
        {
            
            if (campign !=null)
            {
                Console.WriteLine(person.FirstName +" "+game.Name+" adlı oyunu "+campign.CampaignName+ " kampanyasıyla " +_campaignPrice+ " TL indirimle satın aldı");
            }
            else
            {
                Console.WriteLine(person.FirstName + " " + game.Name+ " adlı oyunu kampanyasız aldı");
            }
            
            
            
        }
    }
}
