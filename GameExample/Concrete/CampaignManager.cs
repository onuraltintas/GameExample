using System;
using GameExample.Abstract;
using GameExample.Entities;

namespace GameExample.Concrete
{
    public class CampaignManager:ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign added...");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign update...");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign delete...");
        }
    }
}
