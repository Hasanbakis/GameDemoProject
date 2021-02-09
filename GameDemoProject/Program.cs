using GameDemoProject.Concrete;
using GameDemoProject.Entities;
using System;

namespace GameDemoProject
{
    class Program
    {
        public static GameSaleManager GameSaleManager { get; private set; }

        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager(new UserValidationManager());
            Person person1 = new Person();

            person1.Id = 1;
            person1.FirstName = "HASAN";
            person1.LastName = "BAKIŞ";
            person1.DateOfBirthYear = 1998;
            person1.NationalIdentity = 3057696;
            personManager.Condition(person1);
            

            Campaign campaign = new Campaign();

            campaign.Id = 1;
            campaign.CampaignName = "Star";
            campaign.DiscountRate = 45;


            Game game = new Game();
            game.UnitStock = 160;
            game.Name = "Mortal Kombat";
            game.Price = 150;
            

           GameSaleManager gameSaleManager = new GameSaleManager(game,campaign,new UserValidationManager());

           gameSaleManager.Sale(person1, game, campaign);



        }
    }
}
