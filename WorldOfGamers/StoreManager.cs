using System;
using System.Collections.Generic;
using System.Text;

namespace WorldOfGamers
{
    class StoreManager
    {
        public void List(Game[] games)

        {
            Console.WriteLine("*******STORE********");
            foreach (var game in games)
            {
                Console.WriteLine("Name : "+game.GameName);
                Console.WriteLine("Price : "+game.GamePrice);
                Console.WriteLine("*************************");

            }

        }
        public void Sell(Game game)
        {
            Console.WriteLine(game.GameName+" is succesfully added your library. ");

        }
        public void GetCustomerInfo(Customer customer)
        {
            Console.WriteLine("Customer information verified.");


        }
    }
}
