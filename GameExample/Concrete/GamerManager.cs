using System;
using GameExample.Abstract;
using GameExample.Entities;

namespace GameExample.Concrete
{
    public class GamerManager:IGamerService
    {
        private IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Save(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealGamer(gamer))
            {
                Console.WriteLine("Gamer Added...");
            }

            Console.WriteLine("Invalid Person");
            
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer updated...");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer deleted...");
        }
    }
}
