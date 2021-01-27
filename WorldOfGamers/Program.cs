using System;

namespace WorldOfGamers
{
    class Program
    {
        static void Main(string[] args)
        {
            NewUser user1 = new NewUser {
                ID = 1,
                NickName = "Mafaldasu",
                Password="12345"

            };
            RegisteredUser user2 = new RegisteredUser {
            ID =2,
            NickName="DarkHorizon",
            Password="12345"
            };
            NewUser user3 = new NewUser {
                ID=1,
                NickName="Blakcie",
                Password="12345"

            };
            RegisteredUser user4 = new RegisteredUser { 
                ID = 2,
            NickName="BetaQQ",
            Password="12345"
            };
            UserManager userManager = new UserManager();
            userManager.Register(user1);
            userManager.Register(user3);
            userManager.Delete(user2);
            userManager.Upgrade(user4);

            Game game1 = new Game { GameName="Leaguage of Legends",GamePrice=15 };
            Game game2 = new Game { GameName = "Dota2", GamePrice = 30 };
            Game game3 = new Game { GameName = "Counter-Strike", GamePrice = 50 };
            Game[] games = new Game[] {game1,game2,game3 };

            Customer customer1 = new Customer
            {
                Name = "Sude Naz",
                Surname ="Akkaya",
                IDNumber=12345,
                YearOfBirth=2000,
                CreditCardNumber=564347457,
                CVC=111
            };
            Campaign campaign1 = new Campaign { Name="Valantine's Day Discount",DiscountRate=20 };
            Campaign campaign2 = new Campaign { Name ="Black Friday",DiscountRate=50};
            Campaign[] campaigns = new Campaign[] { campaign1,campaign2};

            CampaignManager campaignManager = new CampaignManager();
            StoreManager storeManager = new StoreManager();
            storeManager.List(games);
            campaignManager.List(campaigns);
            campaignManager.Apply(game3,campaign1);
            storeManager.GetCustomerInfo(customer1);
            storeManager.Sell(game3);


        }
    }
}
