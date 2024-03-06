using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class StoryCard
    {
        public int id { get; }
        public string name { get; }
        public int minPlayers { get; }
        public bool breed { get; }
        public List<int> professions { get; }
        public List<int> items { get; }
        public string opening { get; }
        public string goodend { get; }
        public string badend { get; }

        public StoryCard(int id, string name, int minPlayers, bool breed, List<int> professions, List<int> items, string opening, string goodend, string badend)
        {
            this.id = id;
            this.name = name;
            this.minPlayers = minPlayers;
            this.breed = breed;
            this.professions = professions;
            this.items = items;
            this.opening = opening;
            this.goodend = goodend;
            this.badend = badend;
        }
    }
}
