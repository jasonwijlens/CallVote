using System.Collections.Generic;

namespace Arechi.CallVote
{
    public class Config
    {
        public string Color { get; set; } = "Yellow";

        public List<Vote> Votes { get; set; } = new List<Vote>
        {
            new Vote("Day", "d", "/day"),
            new Vote("Night", "n", "/night"),
        };
    }
}
