using System;

namespace GameExample.Entities
{
    public class Campaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime LastDate { get; set; }
    }
}
