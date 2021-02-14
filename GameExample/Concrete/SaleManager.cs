using System;
using GameExample.Abstract;
using GameExample.Entities;

namespace GameExample.Concrete
{
    public class SaleManager:ISaleServices
    {
        public void Add(Sale sale)
        {
            Console.WriteLine("Sale Added...");
        }

        public void Update(Sale sale)
        {
            Console.WriteLine("Sale Updated...");
        }

        public void Delete(Sale sale)
        {
            Console.WriteLine("Sale Deleted...");
        }
    }
}
